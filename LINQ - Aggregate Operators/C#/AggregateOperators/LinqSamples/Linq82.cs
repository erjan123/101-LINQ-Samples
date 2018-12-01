using System;
using System.ComponentModel;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        [Category("Aggregate Operators")]
        [Description("This sample uses Min to get the length of the shortest word in an array.")]
        public void Linq82()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code

                int shortestWord = words.Min(w => w.Length);

            #endregion

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }
    }
}
