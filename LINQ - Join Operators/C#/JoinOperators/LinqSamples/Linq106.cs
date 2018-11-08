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
        [Description("For each customer in the table of customers, this query returns all the suppliers " +
             "from that same country, or else a string indicating that no suppliers from that country were found.")]
        public void Linq106()
        {

            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            var custSuppliers =
                from cust in customers
                join sup in suppliers on cust.Country equals sup.Country into ss
                from s in ss.DefaultIfEmpty()
                orderby cust.CompanyName
                select new
                {
                    Country = cust.Country,
                    CompanyName = cust.CompanyName,
                    SupplierName = s == null ? "(No suppliers)" : s.SupplierName
                };

            foreach (var item in custSuppliers)
            {
                Console.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }
        }
    }
}
