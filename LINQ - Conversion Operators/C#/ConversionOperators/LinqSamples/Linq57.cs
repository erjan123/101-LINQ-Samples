using System;
using System.Linq;

namespace ConversionOperators
{
    public partial class LinqSamplesConversionOperators
    {
        // Conversion Operators
        // This sample uses OfType to return only the elements of the array that are of type double.
        public void Linq57()
        {
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            #region Make Sure to try yourself before looking at the code 

                var doubles = numbers.OfType<double>();

                Console.WriteLine("Numbers stored as doubles:");
                foreach (var d in doubles)
                {
                    Console.WriteLine(d);
                } 

            #endregion
        }


    }
}
