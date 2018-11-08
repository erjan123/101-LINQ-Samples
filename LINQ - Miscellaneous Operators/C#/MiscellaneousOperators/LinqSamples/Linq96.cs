using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MiscellaneousOperators
{
    public partial class LinqSamplesMiscellaneousOperators
    {
        [Category("Miscellaneous Operators")]
        [Description("This sample uses SequenceEquals to see if two sequences match on all elements " +
             "in the same order.")]
        public void Linq96()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine("The sequences match: {0}", match);
        }
    }
}
