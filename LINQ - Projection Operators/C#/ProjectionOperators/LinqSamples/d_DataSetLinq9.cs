using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses select to produce a sequence of the uppercase 
        //and lowercase versions of each word in the original array    
        public void DataSetLinq9()
        {
            //Note: This sample uses lamda and anonymous types and I will convert it to query syntax

            var words = testDS.Tables["Words"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var upperLowerWords = words.Select(p => new
                {
                    Upper = (p.Field<string>(0)).ToUpper(),
                    Lower = (p.Field<string>(0)).ToLower()
                });

                foreach (var ul in upperLowerWords)
                {
                    Console.WriteLine("Uppercase: " + ul.Upper + ", Lowercase: " + ul.Lower);
                } 

            #endregion
        }

        // With Query Syntax - read comment above
        public void DataSetLinq9A()
        {
            var words = testDS.Tables["Words"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var upperLowerWords = from p in words
                                      select( new { Upper = p.Field<string>("word").ToUpper(),
                                                    Lower = p.Field<string>("word").ToLower()
                                                  });

                Console.WriteLine("****************************************");
                Console.WriteLine("With Query Syntax!");
                foreach (var ul in upperLowerWords)
                {
                    Console.WriteLine("Uppercase: " + ul.Upper + ", Lowercase: " + ul.Lower);
                }

            #endregion
        }
    }
}
