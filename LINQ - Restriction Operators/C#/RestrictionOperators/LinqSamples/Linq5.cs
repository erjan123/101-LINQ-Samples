using System;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // This can't be implemented in Query syntax
        // This sample demonstrates an indexed where clause that returns digits whose name is 
        // shorter than their value.
        public void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code 

                var shortDigits = digits.Where((digit, index) => digit.Length < index);

                Console.WriteLine("With Lambda expression - Short digits:");
                Console.WriteLine();
                foreach (var d in shortDigits)
                {
                    Console.WriteLine("The word {0} is shorter than its value.", d);
                } 

            #endregion
        }
    }
}
