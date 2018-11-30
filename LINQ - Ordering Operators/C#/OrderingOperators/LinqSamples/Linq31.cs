using LinqSamplesCommon.LinqSamplesHelpers;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses an OrderBy clause with a custom comparer to 
        // do a case-insensitive sort of the words in an array.
        public void Linq31()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region Make Sure to try yourself before looking at the code

                var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

                ObjectDumper.Write(sortedWords);

            #endregion
        }
    }
}
