using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace MiscellaneousOperators
{
    public partial class LinqSamplesMiscellaneousOperators
    {
        [Category("Miscellaneous Operators")]
        [Description("This sample uses Concat to create one sequence that contains the names of " +
             "all customers and products, including any duplicates.")]
        public void Linq95()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Products.Product> products = Products.GetProductList();

            var customerNames =
                from cust in customers
                select cust.CompanyName;
            var productNames =
                from prod in products
                select prod.ProductName;

            var allNames = customerNames.Concat(productNames);

            Console.WriteLine("Customer and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
