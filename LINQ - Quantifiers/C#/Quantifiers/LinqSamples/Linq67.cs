using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace Quantifiers
{
    public partial class LinqSamplesQuantifiers
    {
        [Category("Quantifiers")]
        [Description("This sample uses Any to determine if any of the words in the array " +
             "contain the substring 'ei'.")]
        public void Linq67()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            //DONE fixed typo in writeline
            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);
        }
    }
}
