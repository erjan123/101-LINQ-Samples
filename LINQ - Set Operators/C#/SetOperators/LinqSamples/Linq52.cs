using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        // Set Operators"
        // This sample uses Except to create a sequence that contains the values from numbersA
        // that are not also in numbersB.
        public void Linq52()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            #region Make Sure to try yourself before looking at the code

                IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);

                Console.WriteLine("Numbers in first array but not second array:");
                foreach (var n in aOnlyNumbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
