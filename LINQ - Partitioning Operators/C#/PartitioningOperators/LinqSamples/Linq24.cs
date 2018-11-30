using System;
using System.ComponentModel;
using System.Linq;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning Operators
        // This sample uses TakeWhile to return elements starting from the
        // beginning of the array until a number is read whose value is not less than 6.
        public void Linq24()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

                Console.WriteLine("First numbers less than 6:");
                foreach (var num in firstNumbersLessThan6)
                {
                    Console.WriteLine(num);
                }

            #endregion
        }
    }
}
