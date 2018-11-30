using System;
using System.Linq;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning OperatSors
        // This sample uses SkipWhile to get the elements of the array
        // starting from the first element less than its position (index).
        public void Linq27()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code 

                var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

                Console.WriteLine("All elements starting from first element less than its position:");
                foreach (var n in laterNumbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
