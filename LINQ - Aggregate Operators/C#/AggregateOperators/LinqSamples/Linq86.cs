using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Max to get the length of the longest word in an array.
        public void Linq86()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code

                int longestLength = words.Max(w => w.Length);

            #endregion

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }
    }
}
