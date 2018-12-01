using System;
using System.Linq;

namespace GenerationOperators
{
    public partial class LinqSamplesGenerationOperators
    {
        // Generation Operators
        // This sample uses Range to generate a sequence of numbers from 100 to 149 
        // that is used to find which numbers in that range are odd and even.
        public void Linq65()
        {
            var numbers =
                from n in Enumerable.Range(100, 50)
                select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers.Take(10))
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }

        //Linq with Lambda
        public void Linq65A()
        {
            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var numbers = Enumerable.Range(100, 50)
                            .Select(n => new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" });

            #endregion

            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("Linq with Lambda.");
            foreach (var n in numbers.Take(10))
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }
    }
}
