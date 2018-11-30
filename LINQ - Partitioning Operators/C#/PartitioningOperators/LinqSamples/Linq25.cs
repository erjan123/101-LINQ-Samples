using System;
using System.Linq;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning Operators
        // This sample uses TakeWhile to return elements starting from the
        // beginning of the array until a number is hit that is less than its position (index)
        // in the array.
        public void Linq25()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

                Console.WriteLine("First numbers not less than their position:");
                foreach (var n in firstSmallNumbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
