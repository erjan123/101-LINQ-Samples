using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        // Ordering Operators
        // This sample uses orderby to sort a list of products by units in stock
        // from highest to lowest
        public void Linq33()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                // Slightly modified used "Take(10)" to make it compare the results
                var sortedProducts =
                    (from prod in products
                    orderby prod.UnitsInStock descending
                    select prod).Take(10);

                // Could apply take to "sortedProducts"
                // ObjectDumper.Write(sortedProducts.Take(10));
                ObjectDumper.Write(sortedProducts);

            #endregion
        }

        public void Linq33A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region With Lambda - Make Sure to try yourself before looking at the code

            var sortedProducts = products.OrderByDescending(prod => prod.UnitsInStock).Take(10);

                Console.WriteLine();
                Console.WriteLine("********************************");
                Console.WriteLine("OrderBy descending with Lambda.");
                ObjectDumper.Write(sortedProducts);

            #endregion
        }
    }
}
