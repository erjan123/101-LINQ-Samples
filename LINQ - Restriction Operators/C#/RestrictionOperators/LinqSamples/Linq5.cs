using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;


namespace RestrictionOperators
{
    public static class MySpecialExtensionClass
    { 
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            if(source == null)
            {
                throw new ArgumentNullException("Common men, the source is null!");
            }
            if(predicate == null)
            {
                throw new ArgumentNullException("Predicate can't be null my love!");
            }

            int index = -1;

            foreach(TSource src in source)
            {
                index = index + 1;
                if (predicate(src, index))
                    yield return src;
            }
        }
    }
    public partial class LinqSamplesRestrictionOperators
    {
        [Description("This sample demonstrates an indexed where clause that returns digits whose name is " +
        "shorter than their value.")]
        public void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region Make Sure to try yourself before looking at the code 

                var shortDigits = digits.Where((digit, index) => digit.Length < index);

                Console.WriteLine("Short digits:");
                foreach (var d in shortDigits)
                {
                    Console.WriteLine("The word {0} is shorter than its value.", d);
                } 

            #endregion
        }

        // Linq with Lambda
        public void Linq5A()
        {
            // Note:   query expression syntax doesn't have support for those Where overloads with indexing. 

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = digits.Where((digit, index) => digit.Length < index);

            // just returns length and index
            var result2 =
                from temp in digits.Select((digit, index) => new
                {
                                                                digit,
                                                                stringLength = digit.Length,
                                                                stringIndex = index
                                                            })
                                                            
                                                            where temp.stringLength < temp.stringIndex
                                                            select temp;


            Console.WriteLine("Short digits:");
            foreach (var d in result)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }

            foreach (var v in result2)
            {
                Console.WriteLine(v.digit + " " + v.stringIndex + " " + v.stringLength);
            }
        }
    }
}
