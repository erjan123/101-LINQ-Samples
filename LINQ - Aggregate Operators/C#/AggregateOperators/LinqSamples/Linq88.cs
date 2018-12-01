using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Max to get the products with the most expensive price in each category.
        public void Linq88()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    let maxPrice = prodGroup.Max(p => p.UnitPrice)
                    select new { Category = prodGroup.Key, MostExpensiveProducts = prodGroup.Where(p => p.UnitPrice == maxPrice) };

            #endregion

            Console.WriteLine("Orginal 101 Linq example.");
            ObjectDumper.Write(categories.Take(5), 1);
        }

        public void Linq88A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

            var categories = products
                    .GroupBy(prod => prod.Category)
                    .Select(prodGroup => new { prodGroup, maxPrice = prodGroup.Max(p => p.UnitPrice) })
                    .Select(pG => new {
                                        Category = pG.prodGroup.Key,
                                        MostExpensiveProducts = pG.prodGroup.Where(p => p.UnitPrice == pG.maxPrice) });

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 50)));
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(categories.Take(5), 1);
        }
    }
}
