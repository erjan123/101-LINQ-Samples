using System;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // Select all numbers greater than 5
        [Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code 

                    var lowNums =
                        from num in numbers
                        where num < 5
                        select num;

                    Console.WriteLine("Numbers < 5:");
                    foreach (var x in lowNums)
                    {
                        Console.WriteLine(x);
                    } 

            #endregion
        }

        // Linq with Lambda
        public void Linq1A()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code 

                var lowNums =
                        from num in numbers
                        where num < 5
                        select num;

                Console.WriteLine("Numbers < 5:");
                foreach (var x in lowNums)
                {
                    Console.WriteLine(x);
                }

            #endregion
        }
    }
}
