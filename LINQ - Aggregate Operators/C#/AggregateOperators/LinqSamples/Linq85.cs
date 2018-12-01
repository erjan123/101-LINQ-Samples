using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Max to get the highest number in an array. Note that the method returns a single value.
        public void Linq85()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                int maxNum = numbers.Max();

            #endregion

            Console.WriteLine("Orginal 101 Linq example.");
            Console.WriteLine("The maximum number is {0}.", maxNum);
        }
    }
}
