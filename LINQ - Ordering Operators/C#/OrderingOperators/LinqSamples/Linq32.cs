using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses orderby and descending to sort a list of " +
             "doubles from highest to lowest.")]
        public void Linq32()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            #region Make Sure to try yourself before looking at the code

            var sortedDoubles =
                from d in doubles
                orderby d descending
                select d;

            Console.WriteLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                Console.WriteLine(d);
            }

            #endregion
        }
    }
}
