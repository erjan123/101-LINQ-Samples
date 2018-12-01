using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Average to get the average price of each category's products.
        public void Linq91()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categories =
                    from prod in products
                    group prod by prod.Category into prodGroup
                    select new { Category = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            ObjectDumper.Write(categories);
        }

        public void Linq91A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var categories = products
                    .GroupBy(prod => prod.Category)
                    .Select(prodGroup => new {
                                            Category = prodGroup.Key,
                                            AveragePrice = prodGroup.Average(p => p.UnitPrice) });

            #endregion

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(categories);
        }
    }
}
