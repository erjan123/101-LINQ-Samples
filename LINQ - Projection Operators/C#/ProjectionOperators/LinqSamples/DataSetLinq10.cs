using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace ProjectionOperators
{
    delegate void MyLovleyDelegate(string digit, string oddEven);

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

        public void DataSetLinq10A()
        {
             var numbers = testDS.Tables["Numbers"].AsEnumerable();
             var digits = testDS.Tables["Digits"];

            int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            var result = numbers2.Select(num => strings[num]);
            var result2 = numbers2.Select(num => num % 2 == 0 ? "even" : "odd");

            var result3 = numbers2.Select(num => new
                                                    {
                Digit = strings[num],
                Even = num % 2 == 0 ? "even" : "odd"

                                                    });

            var result4 = numbers.Select(num => new
            {
                Digit = digits.Rows[num.Field<int>("number")]

                                        });

            //foreach (var d in result3)
            //{
            //    Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even);
            //}

            //result3.ToList().ForEach(d => Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even));

            MyLovleyDelegate myNewDelegate = new MyLovleyDelegate(ForEachDelegateMethod);
            MyLovleyDelegate myLovleyDelegate2;
            myLovleyDelegate2 = ForEachDelegateMethod;

             result3.ToList().ForEach(item => ForEachDelegateMethod(item.Digit, item.Even));

             result3.ToList().ForEach(d => myLovleyDelegate2(d.Digit, d.Even));

           // result3.ToList().ForEach( delegate (string d, string e) { }); ???????????
        }

        public void ForEachDelegateMethod(string digit, string oddEven)
        {
            Console.WriteLine("The digit {0} is {1}.", digit, oddEven);
        }
    }

}
