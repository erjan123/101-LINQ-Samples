using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        // Aggregate Operators
        //This sample uses Min to get the lowest number in an array.
        public void Linq81()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                int minNum = numbers.Min();

            #endregion

            Console.WriteLine("The minimum number is {0}.", minNum);
        }
    }
}
