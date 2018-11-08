using System;
using System.ComponentModel;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        [Category("Element Operators")]
        [Description("This sample uses ElementAt to retrieve the second number greater than 5 " +
             "from an array.")]
        public void Linq64()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region Make Sure to try yourself before looking at the code

                int fourthLowNum = (
                    from num in numbers
                    where num > 5
                    select num)
                    .ElementAt(1);  // second number is index 1 because sequences use 0-based indexing

                Console.WriteLine("Second number > 5: {0}", fourthLowNum);

            #endregion
        }
    }
}
