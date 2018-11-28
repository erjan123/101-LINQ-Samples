using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses select to produce a sequence of strings representing 
        //the text version of a sequence of ints
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

        // Linq with Lambda
        public void DataSetLinq8A()
        {
            // Another way to populate an array from 0 to 10
            // Also this will make our query simpler to understand, we don't have to deal 
            // with a dataset data
            var numbers = Enumerable.Range(0, 10);
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region  Make Sure to try yourself before looking at the code

                var textNums = numbers.Select(n => strings[n]);

                Console.WriteLine("*************************************");
                Console.WriteLine("Linq with Lambda - Number strings:");
                foreach (var s in textNums)
                {
                    Console.WriteLine(s);
                }

            #endregion
        }
    }
}
