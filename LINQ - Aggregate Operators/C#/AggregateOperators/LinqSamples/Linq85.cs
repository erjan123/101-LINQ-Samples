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
        [Description("This sample uses Max to get the highest number in an array. Note that the method returns a single value.")]
        public void Linq85()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int maxNum = numbers.Max();

            Console.WriteLine("The maximum number is {0}.", maxNum);
        }
    }
}
