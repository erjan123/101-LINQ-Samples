using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
{
    public partial class LinqSamplesQuantifiers
    {
        // Quantifiers
        // This sample uses All to return a grouped a list of products only for categories 
        // at have all of their products in stock.
        public void Linq72()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var productGroups =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    where prodGroup.All(p => p.UnitsInStock > 0)
                    select new { Category = prodGroup.Key, Products = prodGroup };

            #endregion

            ObjectDumper.Write(productGroups.Take(1), 1);
        }

        public void Linq72A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var productGroups = products
                    .GroupBy(prod => prod.Category)
                    .Where(prodGroup => prodGroup.All(p => p.UnitsInStock > 0))
                    .Select(prodGroup => new { Category = prodGroup.Key, Products = prodGroup });

            #endregion

            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("With Lambda.");
            Console.WriteLine();
            ObjectDumper.Write(productGroups.Take(1), 1);
        }
    }
}
