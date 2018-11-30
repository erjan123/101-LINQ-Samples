using LinqSamplesCommon.LinqSamplesHelpers;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses an OrderBy and a ThenBy clause with a custom comparer to
        // sort first by word length and then by a case-insensitive descending sort 
        // of the words in an array.
        public void Linq38()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region Make Sure to try yourself before looking at the code

                var sortedWords =
                    words.OrderBy(a => a.Length)
                         .ThenByDescending(a => a, new CaseInsensitiveComparer());

                ObjectDumper.Write(sortedWords);

            #endregion
        }
    }
}
