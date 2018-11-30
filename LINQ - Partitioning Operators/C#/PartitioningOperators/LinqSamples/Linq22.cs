using System;
using System.Linq;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning Operators
        // This sample uses Skip to get all but the first four elements of the array.
        public void Linq22()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                var allButFirst4Numbers = numbers.Skip(4);

                Console.WriteLine("All but first 4 numbers:");
                foreach (var n in allButFirst4Numbers)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
