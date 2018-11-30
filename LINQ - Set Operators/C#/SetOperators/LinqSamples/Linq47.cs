using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        // Set Operators
        // This sample uses Distinct to find the unique Category names.
        public void Linq47()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categoryNames = (
                    from prod in products
                    select prod.Category)
                    .Distinct();

                Console.WriteLine("Category names:");
                foreach (var n in categoryNames)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }

        public void Linq47A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - SMake Sure to try yourself before looking at the code

            var categoryNames = (products.Select( prod => prod.Category)).Distinct();

                Console.WriteLine();
                Console.WriteLine("*******************************");
                Console.WriteLine("Linq with Lambda.");
                Console.WriteLine("Category names:");
                foreach (var n in categoryNames)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
