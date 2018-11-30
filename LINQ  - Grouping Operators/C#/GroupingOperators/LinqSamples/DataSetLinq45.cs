using System;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        // Grouping Operators
        // This sample uses GroupBy to partition trimmed elements of an array using 
        // a custom comparer that matches words that are anagrams of each other, 
        // and then converts the results to uppercase.
        public void DataSetLinq45()
        {
            var anagrams = testDS.Tables["Anagrams"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var orderGroups = anagrams.GroupBy(
                    w => w.Field<string>("anagram").Trim(),
                    a => a.Field<string>("anagram").ToUpper(),
                    new AnagramEqualityComparer()
                    );

                foreach (var g in orderGroups)
                {
                    Console.WriteLine("Key: {0}", g.Key);
                    foreach (var w in g)
                    {
                        Console.WriteLine("\t" + w);
                    }
                }

            #endregion
        }
    }
}
