using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
{
    public partial class LinqSamplesQuantifiers
    {
        // Quantifiers
        // This sample uses Any to return a grouped a list of products only for categories 
        // that have at least one product that is out of stock.")]
        public void Linq69()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Orginal Linq with Query syntax

                var productGroups =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    where prodGroup.Any(p => p.UnitsInStock == 0)
                    select new { Category = prodGroup.Key, Products = prodGroup };

                ObjectDumper.Write(productGroups.Take(1), 1); 

            #endregion
        }

        public void Linq69A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var productGroups = products
                    .GroupBy(prod => prod.Category)
                    .Where(prodGroup => prodGroup.Any(p => p.UnitsInStock == 0))
                    .Select(prodGroup => new { Category = prodGroup.Key, Products = prodGroup });

                Console.WriteLine();
                Console.WriteLine("***********************************");
                Console.Write("Linq with Lambda.");
                ObjectDumper.Write(productGroups.Take(1), 1);

            #endregion


        }
    }
}
