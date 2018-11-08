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
        [Description("For each supplier in the table of suppliers, this query returns all the customers " +
             "from the same city and country, or else a string indicating that no customers from that city/country were found. " +
             "Note the use of anonymous types to encapsulate the multiple key values.")]
        public void Linq107()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            var supplierCusts =
                from sup in suppliers
                join cust in customers on new { sup.City, sup.Country } equals new { cust.City, cust.Country } into cs
                from c in cs.DefaultIfEmpty() //Remove DefaultIfEmpty method call to make this an inner join
                    orderby sup.SupplierName
                select new
                {
                    Country = sup.Country,
                    City = sup.City,
                    SupplierName = sup.SupplierName,
                    CompanyName = c == null ? "(No customers)" : c.CompanyName
                };

            foreach (var item in supplierCusts)
            {
                Console.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
        }
    }
}
