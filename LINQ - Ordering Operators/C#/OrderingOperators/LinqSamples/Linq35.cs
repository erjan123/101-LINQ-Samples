using System;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses a compound orderby to sort a list of digits, 
        // first by length of their name, and then alphabetically by the name itself.
        public void Linq35()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code

                var sortedDigits =
                    from digit in digits
                    orderby digit.Length, digit
                    select digit;

                Console.WriteLine("Sorted digits:");
                foreach (var d in sortedDigits)
                {
                    Console.WriteLine(d);
                }

            #endregion
        }

        public void Linq35A()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var sortedDigits = digits.OrderBy(digit => digit.Length).ThenBy(digit => digit);

                Console.WriteLine();
                Console.WriteLine("**************************************");
                Console.WriteLine("Linq with Lambda - Sorted digits:");
                foreach (var d in sortedDigits)
                {
                    Console.WriteLine(d);
                }

            #endregion
        }
    }
}
