using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Sum to get the total units in stock for each product category.
        public void Linq80()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    select new { Category = prodGroup.Key, TotalUnitsInStock = prodGroup.Sum(p => p.UnitsInStock) };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            ObjectDumper.Write(categories);
        }

        public void Linq80A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories = products
                    .GroupBy(prod => prod.Category)
                    .Select(prodGroup => new { Category = prodGroup.Key, TotalUnitsInStock = prodGroup.Sum(p => p.UnitsInStock) });

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 50)));
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(categories);
        }
    }
}
