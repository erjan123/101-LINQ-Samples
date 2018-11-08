using System;
using System.ComponentModel;
using System.Linq;

namespace ConversionOperators
{
    public partial class LinqSamplesConversionOperators
    {
        [Category("Conversion Operators")]
        [Description("This sample uses ToList to immediately evaluate a sequence into a List<T>.")]
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
    }
}
