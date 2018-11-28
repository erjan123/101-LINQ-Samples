using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses select to produce a sequence containing text
        //representations of digits and whether their length is even or odd.
        public void DataSetLinq10()
        {
            // Note: This example is in Linq with Lambda
            var numbers = testDS.Tables["Numbers"].AsEnumerable();
            var digits = testDS.Tables["Digits"];
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region  Make Sure to try yourself before looking at the code

                var digitOddEvens = numbers.
                      Select(n => new
                      {
                          Digit = digits.Rows[n.Field<int>("number")]["digit"],
                          Even = (n.Field<int>("number") % 2 == 0)
                      });

                foreach (var d in digitOddEvens)
                {
                    Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
                } 

            #endregion
        }

        // Linq Query syntax
        public void DataSetLinq10A()
        {
            // To make it easy to read or implement I created simpler arrays
            // Since the example is Lambda I converted it to Query syntax
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region  Make Sure to try yourself before looking at the code

                var digitOddEvens =
                            from num in numbers
                            select ( new {
                                            Digit = digits[num],
                                            Even = digits[num].Length % 2 == 0
                                         });
                Console.WriteLine();
                Console.WriteLine("******************************************");
                foreach (var d in digitOddEvens)
                {
                    Console.WriteLine("With Query syntax - The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
                }

            #endregion
        }
    }
}
