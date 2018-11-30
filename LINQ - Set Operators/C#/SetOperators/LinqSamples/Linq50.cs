using System;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        // Set Operators
        // This sample uses Intersect to create one sequence that contains the common values
        // shared by both arrays.
        public void Linq50()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            #region Make Sure to try yourself before looking at the code

                var commonNumbers = numbersA.Intersect(numbersB);

                Console.WriteLine("Common numbers shared by both arrays:");
                foreach (var n in commonNumbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
