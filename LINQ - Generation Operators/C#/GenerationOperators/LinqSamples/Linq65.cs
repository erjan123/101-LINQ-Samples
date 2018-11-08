using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace GenerationOperators
{
    public partial class LinqSamplesGenerationOperators
    {
        [Category("Generation Operators")]
        [Description("This sample uses Range to generate a sequence of numbers from 100 to 149 " +
             "that is used to find which numbers in that range are odd and even.")]
        public void Linq65()
        {
            var numbers =
                from n in Enumerable.Range(100, 50)
                select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers)
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }

        //Linq with Lambda
        public void Linq65A()
        {
            var numbers =
                from n in Enumerable.Range(100, 50)
                select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers)
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }
    }
}
