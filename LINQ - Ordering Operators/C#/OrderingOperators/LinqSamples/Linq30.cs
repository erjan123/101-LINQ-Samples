using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses orderby to sort a list of products by name.
        // Use the \"descending\" keyword at the end of the clause to perform a reverse ordering.
        public void Linq30()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var sortedProducts =
                    from prod in products
                    orderby prod.ProductName descending
                    select prod;

                Console.WriteLine("Linq 101 orginal.");
                ObjectDumper.Write(sortedProducts.Take(10));

            #endregion
        }

        public void Linq30A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region With Lambda - Make Sure to try yourself before looking at the code

                var sortedProducts = products.OrderByDescending(prod => prod.ProductName);

                Console.WriteLine();
                Console.WriteLine("****************************************");
                Console.WriteLine("With Lambda.");
                ObjectDumper.Write(sortedProducts.Take(10));

            #endregion
        }
    }
}
