using System;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // Restriction (Filtering Operators) Operators:
        // "where"  ==>	Filters values based on a predicate function
        // "OfType" ==> Filter values based on their ability to be as a specified type

        // This sample uses the where clause to find all elements of an array 
        // with a value less than 5. 
        // Linq with Query syntax
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code 

                    var lowNums =
                        from num in numbers
                        where num < 5
                        select num;

                    Console.WriteLine("Linq with Query syntax:");
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

                Console.WriteLine();
                Console.WriteLine("Result with Lambda : ");

                var result = numbers.Where(num => num < 5);

                foreach (var x in result)
                {
                    Console.WriteLine(x);
                }

            #endregion
        }

    }
}
