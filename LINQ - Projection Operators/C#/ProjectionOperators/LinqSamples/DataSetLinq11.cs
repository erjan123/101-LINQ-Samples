using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses select to produce a sequence containing some properties
        //of Products, including UnitPrice which is renamed to Price
        //in the resulting type.
        public void DataSetLinq11()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var productInfos = products.
                       Select(n => new
                       {
                           ProductName = n.Field<string>("ProductName"),
                           Category = n.Field<string>("Category"),
                           Price = n.Field<decimal>("UnitPrice")
                       });

                Console.WriteLine("Product Info:");
                foreach (var productInfo in productInfos)
                {
                    Console.WriteLine("{0} is in the category {1} and costs {2} per unit.", productInfo.ProductName, productInfo.Category, productInfo.Price);
                } 

            #endregion
        }

        // Query syntax
        public void DataSetLinq11A()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var productInfos = from n in products
                                   select( new {
                                                ProductName = n.Field<string>("ProductName"),
                                                Category = n.Field<string>("Category"),
                                                Price = n.Field<decimal>("UnitPrice")
                                            });
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine("With Query Syntax - Product Info:");
                foreach (var productInfo in productInfos)
                {
                    Console.WriteLine("{0} is in the category {1} and costs {2} per unit.", productInfo.ProductName, productInfo.Category, productInfo.Price);
                }

            #endregion
        }
    }
}
