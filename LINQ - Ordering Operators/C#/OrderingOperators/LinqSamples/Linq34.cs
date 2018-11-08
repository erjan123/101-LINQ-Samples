using LinqSamplesCommon.LinqSamplesHelpers;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses method syntax to call OrderByDescending because it " +
            " enables you to use a custom comparer.")]
        public void Linq34()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region Make Sure to try yourself before looking at the code

                var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

                ObjectDumper.Write(sortedWords);

            #endregion
        }
    }
}
