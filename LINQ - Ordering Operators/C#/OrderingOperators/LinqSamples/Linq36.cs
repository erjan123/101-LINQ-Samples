using LinqSamplesCommon.LinqSamplesHelpers;
using System;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // The first query in this sample uses method syntax to call OrderBy and ThenBy with a custom comparer to " +
        // sort first by word length and then by a case-insensitive sort of the words in an array. 
        // The second two queries show another way to perform the same task.
        public void Linq36()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region Make Sure to try yourself before looking at the code

                var sortedWords =
                    words.OrderBy(a => a.Length)
                         .ThenBy(a => a, new CaseInsensitiveComparer());

                // Another way. TODO is this use of ThenBy correct? It seems to work on this sample array.
                var sortedWords2 =
                    from word in words
                    orderby word.Length
                    select word;

                var sortedWords3 = sortedWords2.ThenBy(a => a, new CaseInsensitiveComparer());

                Console.WriteLine("Both examples are from 101 Linq() examples");
                ObjectDumper.Write(sortedWords);

                Console.WriteLine();
                Console.WriteLine("********************************");
                ObjectDumper.Write(sortedWords3);

            #endregion
        }
    }
}
