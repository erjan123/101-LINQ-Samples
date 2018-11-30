using System;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        // Element Operators
        // This sample uses ElementAt to retrieve the second number greater than 5 
        // from an array.
        public void Linq64()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                int fourthLowNum = (
                    from num in numbers
                    where num > 5
                    select num)
                    .ElementAt(1);  // second number is index 1 because sequences use 0-based indexing

                Console.WriteLine("Second number > 5: {0}", fourthLowNum);

            #endregion
        }

        public void Linq64A()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                int fourthLowNum = numbers.Where(num => num > 5).ElementAt(1);  // second number is index 1 
                                                                                // because sequences use 0-based indexing

                Console.WriteLine();
                Console.WriteLine("**********************************");
                Console.WriteLine("Linq with Lambda");
                Console.WriteLine("Second number > 5: {0}", fourthLowNum);

            #endregion
        }
    }
}
