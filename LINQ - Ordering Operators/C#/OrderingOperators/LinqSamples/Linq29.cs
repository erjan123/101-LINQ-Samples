using System;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses orderby to sort a list of words by length.
        public void Linq29()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code

                var sortedWords =
                    from word in words
                    orderby word.Length
                    select word;

                Console.WriteLine("The sorted list of words (by length):");
                foreach (var w in sortedWords)
                {
                    Console.WriteLine(w);
                }

            #endregion
        }

        public void Linq29A()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region With Linq - Make Sure to try yourself before looking at the code

                var sortedWords = words.OrderBy(word => word.Length);

                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("With Linq - The sorted list of words (by length):");
                foreach (var w in sortedWords)
                {
                    Console.WriteLine(w);
                }

            #endregion
        }
    }
}
