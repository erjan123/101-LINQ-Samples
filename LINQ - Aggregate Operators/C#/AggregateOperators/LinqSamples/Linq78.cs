using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Sum to add all the numbers in an array.
        public void Linq78()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                double numSum = numbers.Sum();

            #endregion

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
        }
    }
}
