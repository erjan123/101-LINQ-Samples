using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryExecution
{
    public partial class LinqSamplesQueryExecution
    {
        private List<Products.Product> productList = Products.GetProductList();
        private List<Customers.Customer> customerList = Customers.GetCustomerList();

        //Query Execution
        //The following sample shows how query execution is deferred until the query is 
        //enumerated at a foreach statement.
        public void Linq99()
        {

            // Queries are not executed until you enumerate over them.
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var simpleQuery =
                from num in numbers
                select ++i;

            // The local variable 'i' is not incremented
            // until the query is executed in the foreach loop.
            Console.WriteLine("The current value of i is {0}", i); //i is still zero

            foreach (var item in simpleQuery)
            {
                Console.WriteLine("v = {0}, i = {1}", item, i); // now i is incremented          
            }
        }
    }
}
