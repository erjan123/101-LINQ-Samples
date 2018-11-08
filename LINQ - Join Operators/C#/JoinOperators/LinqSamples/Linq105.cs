using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        [Category("Join Operators")]
        [Description("A left outer join produces a result set that includes all the left hand side elements at " +
        "least once, even if they don't match any right hand side elements.")]
        public void Linq105()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            var supplierCusts =
                from sup in suppliers
                join cust in customers on sup.Country equals cust.Country into cs
                from c in cs.DefaultIfEmpty()  // DefaultIfEmpty preserves left-hand elements that have no matches on the right side 
                    orderby sup.SupplierName
                select new
                {
                    Country = sup.Country,
                    CompanyName = c == null ? "(No customers)" : c.CompanyName,
                    SupplierName = sup.SupplierName
                };

            foreach (var item in supplierCusts)
            {
                Console.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
        }
    }
}
