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
        public DataSet testDS;

        public LinqSamplesProjectionOperators()
        {
           testDS = TestHelper.CreateTestDataset();
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence of ints one higher than " +
             "those in an existing array of ints.")]
        public void DataSetLinq6()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var numsPlusOne =
                    from n in numbers
                    select n.Field<int>(0) + 1;

                Console.WriteLine("Numbers + 1:");
                foreach (var i in numsPlusOne)
                {
                    Console.WriteLine(i);
                }

            #endregion
        }
    }
}
