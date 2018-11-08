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
        [Description("This sample uses Min to get the lowest number in an array.")]
        public void Linq81()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int minNum = numbers.Min();

            Console.WriteLine("The minimum number is {0}.", minNum);
        }
    }
}
