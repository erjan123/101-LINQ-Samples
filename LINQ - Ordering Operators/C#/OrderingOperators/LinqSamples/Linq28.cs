using System;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses orderby to sort a list of words alphabetically.
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

        public void Linq28A()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region With Lambda - Make Sure to try yourself before looking at the code

                var sortedWords =    words.OrderBy(word => word);

                Console.WriteLine();
                Console.WriteLine("**********************************");
                Console.WriteLine("With Lambda - The sorted list of words:");
                foreach (var w in sortedWords)
                {
                    Console.WriteLine(w);
                }

            #endregion
        }
    }
}
