using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiscellaneousOperators
{
    public partial class LinqSamplesMiscellaneousOperators
    {
        //Miscellaneous Operators
        //This sample uses Concat to create one sequence that contains the names of
        //all customers and products, including any duplicates.
        public void Linq95()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var customerNames =
                    from cust in customers
                    select cust.CompanyName;
                var productNames =
                    from prod in products
                    select prod.ProductName;

                var allNames = customerNames.Concat(productNames);

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }

        public void Linq95A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var allNames = customers
                                    .Select(cust => cust.CompanyName)
                                    .Concat(products.Select(prod => prod.ProductName));

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 50)));
            Console.WriteLine("Linq with Lambda.");
            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
