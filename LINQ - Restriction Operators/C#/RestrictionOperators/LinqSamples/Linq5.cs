using System;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        [Description("This sample demonstrates an indexed where clause that returns digits whose name is " +
        "shorter than their value.")]
        public void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code 

                var shortDigits = digits.Where((digit, index) => digit.Length < index);

                Console.WriteLine("Short digits:");
                foreach (var d in shortDigits)
                {
                    Console.WriteLine("The word {0} is shorter than its value.", d);
                } 

            #endregion
        }

        // Linq with Lambda
        public void Linq5A()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code 

                var shortDigits = digits.Where((digit, index) => digit.Length < index);

                Console.WriteLine("Short digits:");
                foreach (var d in shortDigits)
                {
                    Console.WriteLine("The word {0} is shorter than its value.", d);
                }

            #endregion
        }
    }
}
