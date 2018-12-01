using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        //Join Operators
        //A left outer join produces a result set that includes all the left hand side elements at 
        //least once, even if they don't match any right hand side elements.
        public void Linq105()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var supplierCusts =
                    from sup in suppliers
                    join cust in customers on sup.Country equals cust.Country into cs
                    from c in cs.DefaultIfEmpty()  // DefaultIfEmpty preserves left-hand elements that have no matches on the right side 
                        orderby sup.SupplierName
                    select new
                    {
                        sup.Country,
                        CompanyName = c == null ? "(No customers)" : c.CompanyName,
                        sup.SupplierName
                    };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            foreach (var item in supplierCusts.Take(15))
            {
                Console.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
        }

        public void Linq105A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var supplierCusts = suppliers
                    .GroupJoin(customers, sup => sup.Country, cust => cust.Country,
                    (sup, c) => new
                    {
                        sup.Country,
                        sup.SupplierName,
                        c
                    })
                    .SelectMany(x => x.c, (sup, c) => new
                    {
                        sup.Country,
                        sup.SupplierName,
                        CompanyName = c == null ? "(No customers)" : c.CompanyName
                    })
                    .OrderBy(sup => sup.SupplierName);

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Linq with Lambda.");
            foreach (var item in supplierCusts.Take(15))
            {
                Console.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
        }
    }
}
