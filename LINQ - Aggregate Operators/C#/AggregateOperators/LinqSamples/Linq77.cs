using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Count to return a list of categories and how many products
        //each has.
        public void Linq77()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categoryCounts =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            ObjectDumper.Write(categoryCounts);
        }

        public void Linq77A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categoryCounts = products
                                        .GroupBy( prod => prod.Category)  
                                        .Select(prodGroup => new {
                                                                Category = prodGroup.Key,
                                                                ProductCount = prodGroup.Count()
                                                                });
            
            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*",50)));
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(categoryCounts);
        }
    }
}
