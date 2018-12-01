using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Average to get the average of all numbers in an array.
        public void Linq89()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                double averageNum = numbers.Average();

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("The average number is {0}.", averageNum);
        }
    }
}
