using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        // Set Operators
        // This sample uses Intersect to create one sequence that contains the common first letter 
        // from both product and customer names.
        public void Linq51()
        {
            List<Products.Product> products = Products.GetProductList();
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Make Sure to try yourself before looking at the code

                var productFirstChars =
                    from prod in products
                    select prod.ProductName[0];
                var customerFirstChars =
                    from cust in customers
                    select cust.CompanyName[0];

                var commonFirstChars = productFirstChars.Intersect(customerFirstChars);

                Console.WriteLine("Common first letters from Product names and Customer names:");
                foreach (var ch in commonFirstChars.Take(10))
                {
                    Console.WriteLine(ch);
                }

            #endregion
        }

        public void Linq51A()
        {
            List<Products.Product> products = Products.GetProductList();
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

            var productFirstChars = products.Select(prod => prod.ProductName[0]);
                var customerFirstChars = customers.Select(cust => cust.CompanyName[0]);

                var commonFirstChars = productFirstChars.Intersect(customerFirstChars);

                Console.WriteLine();
                Console.WriteLine("***************************");
                Console.WriteLine("Partially converted to Linq with Lambda.");
                Console.WriteLine("Common first letters from Product names and Customer names:");
                foreach (var ch in commonFirstChars.Take(10))
                {
                    Console.WriteLine(ch);
                }

            #endregion
        }
    }
}
