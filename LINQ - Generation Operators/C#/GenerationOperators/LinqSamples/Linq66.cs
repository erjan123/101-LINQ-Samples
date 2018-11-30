using System;
using System.Linq;

namespace GenerationOperators
{
    public partial class LinqSamplesGenerationOperators
    {
        // Generation Operators
        // This sample uses Repeat to generate a sequence that contains the number 7 ten times.
        public void Linq66()
        {
            var numbers = Enumerable.Repeat(7, 10);
            
            Console.WriteLine("101 Linq examples - no chages.");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
