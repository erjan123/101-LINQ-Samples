using System;
using System.ComponentModel;
using System.Linq;

namespace ConversionOperators
{
    public partial class LinqSamplesConversionOperators
    {
        [Category("Conversion Operators")]
        [Description("This sample uses ToArray to immediately evaluate a sequence into an array.")]
        public void Linq54()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            #region Make Sure to try yourself before looking at the code 

                var sortedDoubles =
                       from d in doubles
                       orderby d descending
                       select d;
                var doublesArray = sortedDoubles.ToArray();

                Console.WriteLine("Every other double from highest to lowest:");
                for (int d = 0; d < doublesArray.Length; d += 2)
                {
                    Console.WriteLine(doublesArray[d]);
                } 

            #endregion
        }
    }
}
