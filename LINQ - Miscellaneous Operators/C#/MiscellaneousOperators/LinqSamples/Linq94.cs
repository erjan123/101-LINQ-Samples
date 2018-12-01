using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiscellaneousOperators
{
    public partial class LinqSamplesMiscellaneousOperators
    {
        private List<Products.Product> productList = Products.GetProductList();
        private List<Customers.Customer> customerLis = Customers.GetCustomerList();

        //Miscellaneous Operators
        //This sample uses Concat to create one sequence that contains each array's 
        //values, one after the other.
        public void Linq94()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            #region Make Sure to try yourself before looking at the code

                var allNumbers = numbersA.Concat(numbersB);

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
