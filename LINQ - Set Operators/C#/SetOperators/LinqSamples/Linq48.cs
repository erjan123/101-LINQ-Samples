using System;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        // Set Operators
        // This sample uses Union to create one sequence that contains the unique values 
        // from both arrays.
        public void Linq48()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            #region Make Sure to try yourself before looking at the code

                var uniqueNumbers = numbersA.Union(numbersB);

                Console.WriteLine("Unique numbers from both arrays:");
                foreach (var n in uniqueNumbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
