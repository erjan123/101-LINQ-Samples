using LinqSamplesCommon.LinqSamplesHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        public DataSet testDS;

        public LinqSamplesGroupingOperators()
        {
           testDS = TestHelper.CreateTestDataset();
        }

        private class AnagramEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return getCanonicalString(x) == getCanonicalString(y);
            }

            public int GetHashCode(string obj)
            {
                return getCanonicalString(obj).GetHashCode();
            }

            private string getCanonicalString(string word)
            {
                char[] wordChars = word.ToCharArray();
                Array.Sort<char>(wordChars);
                return new string(wordChars);
            }
        }

        // Grouping Operators
        // This sample uses group by to partition a list of numbers by
        // their remainder when divided by 5.
        public void DataSetLinq40()
        {
          EnumerableRowCollection<DataRow>  numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var numberGroups =
                    from n in numbers
                    group n by n.Field<int>("number") % 5 into g
                    select new { Remainder = g.Key, Numbers = g };

                foreach (var g in numberGroups)
                {
                    Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
                    foreach (var n in g.Numbers)
                    {
                        Console.WriteLine(n.Field<int>("number"));
                    }
                }

            #endregion
        }

        public void DataSetLinq40A()
        {
            EnumerableRowCollection<DataRow> numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code 

                var numberGroups =
                            numbers
                            .GroupBy( n => n.Field<int>("number") % 5)
                            .Select(g => new { Remainder = g.Key, Numbers = g });

                Console.WriteLine();
                Console.WriteLine("***********************************");
                Console.WriteLine("Linq with Lambda.");
                foreach (var g in numberGroups)
                {
                    Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
                    foreach (var n in g.Numbers)
                    {
                        Console.WriteLine(n.Field<int>("number"));
                    }
                }

            #endregion
        }
    }
}
