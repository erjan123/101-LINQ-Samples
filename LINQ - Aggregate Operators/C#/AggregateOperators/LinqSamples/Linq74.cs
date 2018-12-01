using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Count to get the number of odd ints in the array.
        public void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                int oddNumbers = numbers.Count(n => n % 2 == 1);

            #endregion
            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }
    }
}
