using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        [Category("Projection Operators")]
        [Description("This sample uses select to return a sequence of just the names of a list of products.")]
        public void DataSetLinq7()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var productNames =
                       from p in products
                       select p.Field<string>("ProductName");

                Console.WriteLine("Product Names:");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                } 

            #endregion
        }

        public void DataSetLinq7A()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            IEnumerable<string> productNames =
                                    from names in products
                                    select names.Field<string>("ProductName");

            IEnumerable<string> productNames2 =
                                    products
                                    .Select(names => names.Field<string>("ProductName"));
            Console.WriteLine("Hello from DatasetLinq7A !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //foreach (string name in productNames2)
            //{
            //    Console.WriteLine(name);
            //}

            productNames2.ToList().ForEach(number => Console.WriteLine(number));

            // foreach (string prodNames in productNames)
            //    Console.WriteLine(productNames);
        }
    }
}
