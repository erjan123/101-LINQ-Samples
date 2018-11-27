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

        public void DataSetLinq8A()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();
            int[] numbersTemp = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //for (int i = 0; i < numbersTemp.Length; i++)
            //{
            //    Console.WriteLine(strings[numbersTemp[i]]);
            //}
            IEnumerable<string> result1 = 
                      from num in numbersTemp
                      select strings[num];

            IEnumerable<string> result2 = numbersTemp.Select(num => strings[num]);

            IEnumerable<string> result3 =
                                    from num in numbers
                                    select strings[num.Field<int>("number")];

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            result3.ToList().ForEach(number => Console.WriteLine(number));


        }
    }
}
