using System;
using System.Linq;

namespace ConversionOperators
{
    public partial class LinqSamplesConversionOperators
    {
        // Conversion Operators
        // This sample uses ToList to immediately evaluate a sequence into a List<T>.
        public void Linq55()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code 

                var sortedWords =
                        from w in words
                        orderby w
                        select w;
                var wordList = sortedWords.ToList();

                Console.WriteLine("The sorted word list:");
                foreach (var w in wordList)
                {
                    Console.WriteLine(w);
                } 

            #endregion
        }

        public void Linq55A()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            #region Make Sure to try yourself before looking at the code 

                var sortedWords = words.OrderBy(w => w).ToList();

                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine("Linq with Lambda.");
                Console.WriteLine("The sorted word list:");
                foreach (var w in sortedWords)
                {
                    Console.WriteLine(w);
                }

            #endregion
        }
    }
}
