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
        [Description("This sample uses select to produce a sequence containing text " +
             "representations of digits and whether their length is even or odd.")]
        public void DataSetLinq10()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();
            var digits = testDS.Tables["Digits"];
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region  Make Sure to try yourself before looking at the code

                var digitOddEvens = numbers.
                      Select(n => new
                      {
                          Digit = digits.Rows[n.Field<int>("number")]["digit"],
                          Even = (n.Field<int>("number") % 2 == 0)
                      });

                foreach (var d in digitOddEvens)
                {
                    Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
                } 

            #endregion
        }
    }
}
