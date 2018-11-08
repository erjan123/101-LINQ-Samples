using System;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of words alphabetically.")]
        public void Linq28()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code

                var sortedWords =
                    from word in words
                    orderby word
                    select word;

                Console.WriteLine("The sorted list of words:");
                foreach (var w in sortedWords)
                {
                    Console.WriteLine(w);
                }

            #endregion
        }
    }
}
