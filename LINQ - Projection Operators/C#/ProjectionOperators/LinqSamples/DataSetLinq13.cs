using System;
using System.Linq;
using System.ComponentModel;
using System.Data;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        [Category("Projection Operators")]
        [Description("This sample combines select and where to make a simple query that returns " +
             "the text form of each digit less than 5.")]
        public void DataSetLinq13()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();
            var digits = testDS.Tables["Digits"];

            #region  Make Sure to try yourself before looking at the code

                var lowNums =
                    from n in numbers
                    where n.Field<int>("number") < 5
                    select digits.Rows[n.Field<int>("number")].Field<string>("digit");

                Console.WriteLine("Numbers < 5:");
                foreach (var num in lowNums)
                {
                    Console.WriteLine(num);
                }

            #endregion

        }
    }
}
