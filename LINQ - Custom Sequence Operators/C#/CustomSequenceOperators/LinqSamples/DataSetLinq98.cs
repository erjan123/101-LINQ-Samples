using LinqSamplesCommon.LinqSamplesHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CustomSequenceOperators
{
    public static class CombineExtension
    {
        public static IEnumerable<S> Combine<S>(this IEnumerable<DataRow> first, IEnumerable<DataRow> second, System.Func<DataRow, DataRow, S> func)
        {
            using (IEnumerator<DataRow> e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    yield return func(e1.Current, e2.Current);
                }
            }
        }
    }
    public class LinqSamplesCustomSequenceOperators
    {
        private DataSet testDS;

        public LinqSamplesCustomSequenceOperators()
        {
            testDS = TestHelper.CreateTestDataset();
        }

        //Custom Sequence Operators
        //This sample uses a user-created sequence operator, Combine, to calculate the
        //dot product of two vectors.
        public void DataSetLinq98()
        {
            var numbersA = testDS.Tables["NumbersA"].AsEnumerable();
            var numbersB = testDS.Tables["NumbersB"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code

                int dotProduct = numbersA.Combine(
                                    numbersB, 
                                    (a, b) => a.Field<int>("number") * b.Field<int>("number")).Sum();

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("Dot product: {0}", dotProduct);
        }
    }
}
