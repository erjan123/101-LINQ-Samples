using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        [Category("Aggregate Operators")]
        [Description("This sample uses Average to get the average of all numbers in an array.")]
        public void Linq89()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double averageNum = numbers.Average();

            Console.WriteLine("The average number is {0}.", averageNum);
        }
    }
}
