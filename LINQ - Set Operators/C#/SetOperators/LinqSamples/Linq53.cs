using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        // Set Operators
        // This sample uses Except to create one sequence that contains the first letters 
        // of product names that are not also first letters of customer names.
        public void Linq53()
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

                var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

                Console.WriteLine("First letters from Product names, but not from Customer names:");
                foreach (var ch in productOnlyFirstChars)
                {
                    Console.WriteLine(ch);
                }

            #endregion
        }

        public void Linq53A()
        {
            List<Products.Product> products = Products.GetProductList();
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Partially converted - Make Sure to try yourself before looking at the code

                var productFirstChars = products.Select(prod => prod.ProductName[0]);
                var customerFirstChars = customers.Select(cust => cust.CompanyName[0]);

                var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine("Partially converted to Linq with Lambda.");
                Console.WriteLine("First letters from Product names, but not from Customer names:");
                foreach (var ch in productOnlyFirstChars)
                {
                    Console.WriteLine(ch);
                }

            #endregion
        }
    }
}
