using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        [Category("Projection Operators")]
        [Description("This sample uses an indexed Select clause to determine if the value of ints " +
             "in an array match their position in the array.")]
        public void DataSetLinq12()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var numsInPlace = numbers.Select((num, index) => new
                {
                    Num = num.Field<int>("number"),
                    InPlace = (num.Field<int>("number") == index)
                });

                Console.WriteLine("Number: In-place?");
                foreach (var n in numsInPlace)
                {
                    Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
                } 

            #endregion
        }
    }
}
