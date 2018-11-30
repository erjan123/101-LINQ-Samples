using System;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        // Grouping Operators
        // This sample uses group by to partition a list of words by
        // their first letter.
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

        public void DataSetLinq41A()
        {
            var words4 = testDS.Tables["Words4"].AsEnumerable();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code 

                var wordGroups = words4
                                    .GroupBy(w =>  w.Field<string>("word")[0]) 
                                    .Select(g => new { FirstLetter = g.Key, Words = g });

                Console.WriteLine();
                Console.WriteLine("********************************");
                Console.WriteLine("Linq with Lambda.");
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
