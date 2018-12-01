using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        //Join Operators
        //For each supplier in the table of suppliers, this query returns all the customers 
        //from the same city and country, or else a string indicating that no customers from that city/country were found. 
        //Note the use of anonymous types to encapsulate the multiple key values.
        public void Linq107()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var supplierCusts =
                    from sup in suppliers
                    join cust in customers on new { sup.City, sup.Country } equals new { cust.City, cust.Country } into cs
                    from c in cs.DefaultIfEmpty() //Remove DefaultIfEmpty method call to make this an inner join
                        orderby sup.SupplierName
                    select new
                    {
                        sup.Country,
                        sup.City,
                        sup.SupplierName,
                        CompanyName = c == null ? "(No customers)" : c.CompanyName
                    };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");

            foreach (var item in supplierCusts.Take(10))
            {
                Console.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
        }

     
        public void Linq107A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var supplierCusts = suppliers
                    .GroupJoin(customers, sup => new { sup.City, sup.Country }, cust => new { cust.City, cust.Country }
                                            , (sup, cs) => new
                                            {
                                                sup.Country,
                                                sup.City,
                                                sup.SupplierName,
                                                cs
                                            })
                    .SelectMany(x => x.cs.DefaultIfEmpty(), (sub, cs) => new
                    {
                        sub.Country,
                        sub.City,
                        sub.SupplierName,
                        CompanyName = cs == null ? "(No customers)" : cs.CompanyName
                    })
                    .OrderBy(sup => sup.SupplierName);
             
            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Linq with Lambda.");
            foreach (var item in supplierCusts.Take(10))
            {
                Console.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
        }
    }
}
