using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        [Category("Grouping Operators")]
        [Description("This sample uses GroupBy to partition trimmed elements of an array using " +
             "a custom comparer that matches words that are anagrams of each other.")]
        public void DataSetLinq44()
        {
            var anagrams = testDS.Tables["Anagrams"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

            var orderGroups = anagrams.GroupBy(w => w.Field<string>("anagram").Trim(), new AnagramEqualityComparer());

                foreach (var g in orderGroups)
                {
                    Console.WriteLine("Key: {0}", g.Key);
                    foreach (var w in g)
                    {
                        Console.WriteLine("\t" + w.Field<string>("anagram"));
                    }
                }

            #endregion
        }
    }
}
