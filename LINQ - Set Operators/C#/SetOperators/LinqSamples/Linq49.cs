using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        [Category("Set Operators")]
        [Description("This sample uses the Union method to create one sequence that contains the unique first letter " +
             "from both product and customer names. Union is only available through method syntax.")]
        public void Linq49()
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

                var uniqueFirstChars = productFirstChars.Union(customerFirstChars);

                Console.WriteLine("Unique first letters from Product names and Customer names:");
                foreach (var ch in uniqueFirstChars)
                {
                    Console.WriteLine(ch);
                }

            #endregion
        }
    }
}
