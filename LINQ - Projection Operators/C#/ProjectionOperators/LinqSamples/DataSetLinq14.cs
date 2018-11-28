using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {

        //Projection Operators
        //This sample uses a compound from clause to make a query that returns all pairs
        //of numbers from both arrays such that the number from numbersA is less than the number
        //from numbersB.
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

        //Linq with Lambda
        public void DataSetLinq14A()
        {
            // var numbersA = testDS.Tables["NumbersA"].AsEnumerable();
            // var numbersB = testDS.Tables["NumbersB"].AsEnumerable();

            // using a simpler version of the same data
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            #region  Make Sure to try yourself before looking at the code

                // With Query syntax and simpler arrays
                var pairs = from a in numbersA
                            from b in numbersB
                            where a < b
                            select new { a, b };

                Console.WriteLine();
                Console.WriteLine("***********************************");
                Console.WriteLine("Query syntax with simple array - Pairs where a < b:");
                foreach (var pair in pairs)
                {
                    Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
                }

            #endregion
        }
    }
}
