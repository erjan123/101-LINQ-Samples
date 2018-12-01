using System;
using System.Linq;

namespace MiscellaneousOperators
{
    public partial class LinqSamplesMiscellaneousOperators
    {
        //Miscellaneous Operators
        //This sample uses SequenceEqual to see if two sequences match on all elements
        //in the same order.
        public void Linq97()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            #region Make Sure to try yourself before looking at the code

                bool match = wordsA.SequenceEqual(wordsB);

            #endregion

            Console.WriteLine("The sequences match: {0}", match);
        }
    }
}
