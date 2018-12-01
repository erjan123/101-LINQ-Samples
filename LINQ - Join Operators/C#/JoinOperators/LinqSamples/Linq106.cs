using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        //Join Operators
        //For each customer in the table of customers, this query returns all the suppliers 
        //from that same country, or else a string indicating that no suppliers from that country were found.
        public void Linq106()
        {

            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var custSuppliers =
                    from cust in customers
                    join sup in suppliers on cust.Country equals sup.Country into ss
                    from s in ss.DefaultIfEmpty()
                    orderby cust.CompanyName
                    select new
                    {
                        cust.Country,
                        cust.CompanyName,
                        SupplierName = s == null ? "(No suppliers)" : s.SupplierName
                    };

            #endregion

            Console.WriteLine();
            Console.WriteLine("Orginal 101 Linq example.");
            foreach (var item in custSuppliers.Take(10))
            {
                Console.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }
        }

        public void Linq106A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var custSuppliers = customers
                    .GroupJoin(suppliers, cust => cust.Country, sup => sup.Country
                                , (cust, ss) => new
                                {
                                    cust.Country,
                                    cust.CompanyName,
                                    ss
                                })
                                .SelectMany(x => x.ss.DefaultIfEmpty(),
                                (cust, ss) => new
                                {
                                    cust.Country,
                                    cust.CompanyName,
                                    SupplierName = ss == null ? "(No suppliers)" : ss.SupplierName
                                })
                    .OrderBy(cust => cust.CompanyName);

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Linq with Lambda.");
            foreach (var item in custSuppliers.Take(10))
            {
                Console.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }
        }
    }
}
