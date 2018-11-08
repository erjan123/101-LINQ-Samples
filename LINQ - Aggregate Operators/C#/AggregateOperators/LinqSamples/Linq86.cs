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
        [Description("This sample uses Max to get the length of the longest word in an array.")]
        public void Linq86()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int longestLength = words.Max(w => w.Length);

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }
    }
}
