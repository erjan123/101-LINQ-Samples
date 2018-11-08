using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace GenerationOperators
{
    public partial class LinqSamplesGenerationOperators
    {
        [Category("Generation Operators")]
        [Description("This sample uses Repeat to generate a sequence that contains the number 7 ten times.")]
        public void Linq66()
        {
            var numbers = Enumerable.Repeat(7, 10);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        // Linq with Lambda
        public void Linq66A()
        {
            var numbers = Enumerable.Repeat(7, 10);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
