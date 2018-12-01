using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Sum to get the total number of characters of all words in the array.
        public void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code

                double totalChars = words.Sum(w => w.Length);

            #endregion

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }
    }
}
