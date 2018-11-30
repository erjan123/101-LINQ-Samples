using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        private List<Products.Product> productList;
        private List<Customers.Customer> customerList;

        // Set Operators
        // This sample uses Distinct to remove duplicate elements in a sequence of 
        // factors of 300.
        public void Linq46()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            #region Make Sure to try yourself before looking at the code

                var uniqueFactors = factorsOf300.Distinct();

                Console.WriteLine("Prime factors of 300:");
                foreach (var f in uniqueFactors)
                {
                    Console.WriteLine(f);
                }

            #endregion
        }
    }
}
