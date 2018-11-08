using System;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses a compound orderby to sort a list of digits, " +
             "first by length of their name, and then alphabetically by the name itself.")]
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
    }
}
