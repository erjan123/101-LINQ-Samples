using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using LinqSamplesCommon.LinqSamplesHelpers;


namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        // Projection Operators
        // 1. "Select" - The operator projects values on basis of a transform function
        // 2. "SelectMany" - "The operator project the sequences of values which are based 
        // on a transform function as well as flattens them into a single sequence

        public DataSet testDS;
        public LinqSamplesProjectionOperators()
        {
           testDS = TestHelper.CreateTestDataset();
        }

        // Category: Projection Operators
        // This sample uses select to produce a sequence of ints one higher than 
        // those in an existing array of ints.
        public void DataSetLinq6()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var numsPlusOne =
                    from n in numbers
                    select n.Field<int>(0) + 1;

                Console.WriteLine("Linq query syntax - Numbers + 1:");
                foreach (var i in numsPlusOne)
                {
                    Console.WriteLine(i);
                }

            #endregion
        }

        public void DataSetLinq6A()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var numsPlusOne = numbers.Select(n => n.Field<int>(0) + 1);

                Console.WriteLine();
                Console.WriteLine("Linq Expression syntax - Numbers + 1:");
                foreach (var i in numsPlusOne)
                {
                    Console.WriteLine(i);
                }

            #endregion
        }
    }
}
