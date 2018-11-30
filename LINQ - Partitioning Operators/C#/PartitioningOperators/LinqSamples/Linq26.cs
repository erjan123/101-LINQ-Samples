using System;
using System.Linq;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning Operators
        // This sample uses SkipWhile to get the elements of the array
        // starting from the first element divisible by 3.
        public void Linq26()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // In the lambda expression, 'n' is the input parameter that identifies each
            // element in the collection in succession. It is is inferred to be
            // of type int because numbers is an int array.

            #region Make Sure to try yourself before looking at the code

                var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

                Console.WriteLine("All elements starting from first element divisible by 3:");
                foreach (var n in allButFirst3Numbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
