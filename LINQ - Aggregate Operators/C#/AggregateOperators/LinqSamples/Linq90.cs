using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Average to get the average length of the words in the array.
        public void Linq90()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code

                double averageLength = words.Average(w => w.Length);

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("The average word length is {0} characters.", averageLength);
        }
    }
}
