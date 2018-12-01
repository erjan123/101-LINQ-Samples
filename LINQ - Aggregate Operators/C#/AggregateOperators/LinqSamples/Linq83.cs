using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Min to get the cheapest price among each category's products.
        public void Linq83()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    select new { Category = prodGroup.Key, CheapestPrice = prodGroup.Min(p => p.UnitPrice) };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            ObjectDumper.Write(categories);
        }

        public void Linq83A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories = products
                    .GroupBy(prod => prod.Category) 
                    .Select(prodGroup => new {
                                                Category = prodGroup.Key,
                                                CheapestPrice = prodGroup.Min(p => p.UnitPrice)
                                             });

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*",50)));
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(categories);
        }
    }
}
