using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence of the uppercase " +
             "and lowercase versions of each word in the original array.")]
        public void DataSetLinq9()
        {
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

        public void DataSetLinq9A()
        {
            var words = testDS.Tables["Words"].AsEnumerable();

            IEnumerable<string> upperLower =
                                        from str in words
                                        select 
                                        "Uppercase : " + str.Field<string>("word").ToUpper() +
                                        " Lowercase : " + str.Field<string>("word").ToLower();

            IEnumerable<string> upperLowerLambda =
                                             words.Select(str => "Uppercase : " + str.Field<string>("word").ToUpper() +
                                                                 " Lowercase : " + str.Field<string>("word").ToLower());

            foreach (var item in upperLowerLambda)
            {
                Console.WriteLine(item);
            }

        }
    }
}
