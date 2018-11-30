using System;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        // Element Operators
        // This sample uses FirstOrDefault to try to return the first element of the sequence,
        // unless there are no elements, in which case the default value for that type
        // is returned. FirstOrDefault is useful for creating outer joins.
        public void Linq61()
        {
            int[] numbers = { };

            #region Make Sure to try yourself before looking at the code

                int firstNumOrDefault = numbers.FirstOrDefault();

                Console.WriteLine(firstNumOrDefault);

            #endregion
        }
    }
}
