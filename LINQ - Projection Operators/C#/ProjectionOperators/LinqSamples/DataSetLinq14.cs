using System;
using System.Linq;
using System.ComponentModel;
using System.Data;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {

        [Category("Projection Operators")]
        [Description("This sample uses a compound from clause to make a query that returns all pairs " +
                     "of numbers from both arrays such that the number from numbersA is less than the number " +
                     "from numbersB.")]
        public void DataSetLinq14()
        {
            var numbersA = testDS.Tables["NumbersA"].AsEnumerable();
            var numbersB = testDS.Tables["NumbersB"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

            var pairs =
                    from a in numbersA
                    from b in numbersB
                    where a.Field<int>("number") < b.Field<int>("number")
                    select new { a = a.Field<int>("number"), b = b.Field<int>("number") };

                Console.WriteLine("Pairs where a < b:");
                foreach (var pair in pairs)
                {
                    Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
                }

            #endregion
        }
    }
}
