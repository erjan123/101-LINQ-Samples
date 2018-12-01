using System;
using System.Linq;

namespace Quantifiers
{
    public partial class LinqSamplesQuantifiers
    {
        // Quantifiers
        // This sample uses Any to determine if any of the words in the array 
        // contain the substring 'ei'.
        public void Linq67()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);
        }
    }
}
