using LinqSamplesCommon.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses a compound orderby to sort a list of products,
        // first by category, and then by unit price, from highest to lowest.
        public void Linq37()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var sortedProducts =
                    from prod in products
                    orderby prod.Category, prod.UnitPrice descending
                    select prod;

                ObjectDumper.Write(sortedProducts.Take(10));

            #endregion
        }

        public void Linq37A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var sortedProducts = products
                                            .OrderBy(prod => prod.Category)
                                            .ThenByDescending(prod => prod.UnitPrice).Take(10);

                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine("Linq with Lambda.");
                ObjectDumper.Write(sortedProducts);

            #endregion
        }
    }
}
