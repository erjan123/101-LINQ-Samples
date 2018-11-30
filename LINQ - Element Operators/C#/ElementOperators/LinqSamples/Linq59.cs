using System;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        // Element Operators
        // This sample uses First to find the first element in the array that starts with 'o'.
        public void Linq59()
        {
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code

                string startsWithO = strings.First(s => s[0] == 'o');

                Console.WriteLine("A string starting with 'o': {0}", startsWithO);

            #endregion
        }
    }
}
