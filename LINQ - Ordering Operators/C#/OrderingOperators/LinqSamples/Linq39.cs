using System;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses Reverse to create a list of all digits in the array whose
        // second letter is 'i' that is reversed from the order in the original array.
        public void Linq39()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code

                var reversedIDigits = (
                    from digit in digits
                    where digit[1] == 'i'
                    select digit)
                    .Reverse();

                Console.WriteLine("A backwards list of the digits with a second character of 'i':");
                foreach (var d in reversedIDigits)
                {
                    Console.WriteLine(d);
                }

            #endregion
        }

        public void Linq39A()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code

                var reversedIDigits = digits
                                        .Where(digit => digit[1] == 'i')
                                        .Reverse();

                Console.WriteLine();
                Console.WriteLine("*****************************");
                Console.WriteLine("Linq with Lambda.");
                Console.WriteLine("A backwards list of the digits with a second character of 'i':");
                foreach (var d in reversedIDigits)
                {
                    Console.WriteLine(d);
                }

            #endregion
        }
    }
}
