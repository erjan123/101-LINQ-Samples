using System;
using System.Linq;

namespace QueryExecution
{
    public partial class LinqSamplesQueryExecution
    {
        //Query Execution
        //The following sample shows how queries can be executed immediately, and their results 
        //stored in memory, with methods such as ToList.
        public void Linq100()
        {
            // Methods like ToList(), Max(), and Count() cause the query to be
            // executed immediately.            
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var immediateQuery = (
                from num in numbers
                select ++i)
                .ToList();

            Console.WriteLine("The current value of i is {0}", i); //i has been incremented

            foreach (var item in immediateQuery)
            {
                Console.WriteLine("v = {0}, i = {1}", item, i);
            }
        }
    }
}
