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
        [Description("This sample uses Count to get the number of odd ints in the array.")]
        public void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }
    }
}
