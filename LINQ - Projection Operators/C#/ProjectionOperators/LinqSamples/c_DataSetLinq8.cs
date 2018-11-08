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
        [Description("This sample uses select to produce a sequence of strings representing " +
             "the text version of a sequence of ints.")]
        public void DataSetLinq8()
        {

            var numbers = testDS.Tables["Numbers"].AsEnumerable();
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region  Make Sure to try yourself before looking at the code

                var textNums = numbers.Select(p => strings[p.Field<int>("number")]);

                    Console.WriteLine("Number strings:");
                    foreach (var s in textNums)
                    {
                        Console.WriteLine(s);
                    } 

            #endregion
        }
    }
}
