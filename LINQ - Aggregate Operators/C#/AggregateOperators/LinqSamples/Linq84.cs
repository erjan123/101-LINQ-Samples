using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Min to get the products with the lowest price in each category.
        public void Linq84()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    let minPrice = prodGroup.Min(p => p.UnitPrice)
                    select new { Category = prodGroup.Key, CheapestProducts = prodGroup.Where(p => p.UnitPrice == minPrice) };

            #endregion

            Console.WriteLine("Orginal 101 Linq example. ");
            ObjectDumper.Write(categories.Take(5), 1);
        }

        public void Linq84A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var categories = products
                    .GroupBy(prod =>prod.Category)
                    .Select(prodGroup => new { prodGroup, minPrice = prodGroup.Min(p => p.UnitPrice)})
                    .Select(pG => new {
                                    Category = pG.prodGroup.Key,
                                    CheapestProducts = pG.prodGroup.Where(p => p.UnitPrice == pG.minPrice) });

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 50)));
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(categories.Take(5), 1);
        }
    }
}
