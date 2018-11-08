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
        [Description("This sample uses Min to get the length of the shortest word in an array.")]
        public void Linq82()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }
    }
}
