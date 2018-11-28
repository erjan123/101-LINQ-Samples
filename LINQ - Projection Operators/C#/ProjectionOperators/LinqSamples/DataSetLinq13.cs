using System;
using System.Linq;
using System.Data;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample combines select and where to make a simple query that returns
        //the text form of each digit less than 5.
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

        // Linq with Lambda
        public void DataSetLinq13A()
        {
            //var numbers = testDS.Tables["Numbers"].AsEnumerable();
            //var digits = testDS.Tables["Digits"];
            
            // To make it simpler I use a simple version of same data
            var numbers = Enumerable.Range(0, 9);
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region  Make Sure to try yourself before looking at the code

                // With Query syntax and simpler arrays
                var lowNums =  from num in numbers
                               where num < 5
                               select digits[num];

                var lowNumsWithLambda = numbers
                                          .Where(num => num < 5)
                                          .Select(index => digits[index]);
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine("With Query syntax and simple arrays - Numbers < 5:");
                foreach (var num in lowNums)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine("With Lambda and simple arrays - Numbers < 5:");
                foreach (var num in lowNumsWithLambda)
                {
                    Console.WriteLine(num);
                }

            #endregion

        }
    }
}
