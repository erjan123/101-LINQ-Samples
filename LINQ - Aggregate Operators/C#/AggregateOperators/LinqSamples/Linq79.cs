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
        [Description("This sample uses Sum to get the total number of characters of all words " +
             "in the array.")]
        public void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(w => w.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }
    }
}
