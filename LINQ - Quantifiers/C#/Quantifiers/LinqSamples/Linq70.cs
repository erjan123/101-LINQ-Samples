using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Quantifiers
{
    public partial class LinqSamplesQuantifiers
    {
        [Category("Quantifiers")]
        [Description("This sample uses All to determine whether an array contains " +
             "only odd numbers.")]
        public void Linq70()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }
    }
}
