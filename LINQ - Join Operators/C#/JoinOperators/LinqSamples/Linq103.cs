using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        //Join Operators
        //A group join produces a hierarchical sequence. The following query is an inner join
        //that produces a sequence of objects, each of which has a key and an inner sequence of all matching elements.
        public void Linq103()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var custSupQuery =
                    from sup in suppliers
                    join cust in customers on sup.Country equals cust.Country into cs
                    select new { Key = sup.Country, Items = cs };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            foreach (var item in custSupQuery)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var element in item.Items)
                {
                    Console.WriteLine("   " + element.CompanyName);
                }
            }
        }

        public void Linq103A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var custSupQuery = suppliers
                                       .GroupJoin(customers, sup => sup.Country, cust => cust.Country, 
                                        (sup, cs) => new { Key = sup.Country, Items = cs });

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Linq with Lambda.");
            foreach (var item in custSupQuery)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var element in item.Items)
                {
                    Console.WriteLine("   " + element.CompanyName);
                }
            }
        }
    }
}
