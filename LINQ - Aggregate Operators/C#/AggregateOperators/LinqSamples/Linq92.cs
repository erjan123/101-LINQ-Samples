using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Aggregate to create a running product on the array that
        //calculates the total product of all elements.
        public void Linq92()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            #region Make Sure to try yourself before looking at the code

                double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("Total product of all numbers: {0}", product);
        }
    }
}
