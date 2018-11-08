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
        private List<Products.Product> productList = Products.GetProductList();
        private List<Customers.Customer> customerLis = Customers.GetCustomerList();

        [Category("Miscellaneous Operators")]
        [Description("This sample uses Concat to create one sequence that contains each array's " +
             "values, one after the other.")]
        public void Linq94()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var allNumbers = numbersA.Concat(numbersB);

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
