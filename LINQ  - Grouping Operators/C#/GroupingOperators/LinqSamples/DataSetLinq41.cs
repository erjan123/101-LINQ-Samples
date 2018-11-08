using System;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        [Category("Grouping Operators")]
        [Description("This sample uses group by to partition a list of words by " +
             "their first letter.")]
        public void DataSetLinq41()
        {
            var words4 = testDS.Tables["Words4"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var wordGroups =
                    from w in words4
                    group w by w.Field<string>("word")[0] into g
                    select new { FirstLetter = g.Key, Words = g };

                foreach (var g in wordGroups)
                {
                    Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                    foreach (var w in g.Words)
                    {
                        Console.WriteLine(w.Field<string>("word"));
                    }
                }

            #endregion
        }
    }
}
