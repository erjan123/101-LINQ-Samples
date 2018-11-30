using System;
using System.Linq;

namespace ConversionOperators
{
    public partial class LinqSamplesConversionOperators
    {
        // Conversion Operators
        // This sample uses ToDictionary to immediately evaluate a sequence and a 
        // related key expression into a dictionary.
        public void Linq56()
        {
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                        new {Name = "Bob"  , Score = 40},
                                        new {Name = "Cathy", Score = 45}
                                    };

            #region Make Sure to try yourself before looking at the code 

                var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

                Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]); 

            #endregion
        }

    }
}
