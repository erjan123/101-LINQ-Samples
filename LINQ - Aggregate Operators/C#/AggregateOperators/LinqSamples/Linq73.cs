using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        private List<Products.Product> productList = Products.GetProductList();
        private List<Customers.Customer> customerList = Customers.GetCustomerList();

        [Category("Aggregate Operators")]
        [Description("This sample uses Count to get the number of unique prime factors of 300.")]
        public void Linq73()
        {
            int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };

            #region MyRegion

            int uniqueFactors = primeFactorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique prime factors of 300.", uniqueFactors);

            #endregion
        }
    }
}
