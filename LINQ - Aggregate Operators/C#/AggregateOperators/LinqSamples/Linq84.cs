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
        [Category("Aggregate Operators")]
        [Description("This sample uses Min to get the products with the lowest price in each category.")]
        public void Linq84()
        {
            List<Products.Product> products = Products.GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                let minPrice = prodGroup.Min(p => p.UnitPrice)
                select new { Category = prodGroup.Key, CheapestProducts = prodGroup.Where(p => p.UnitPrice == minPrice) };

            ObjectDumper.Write(categories, 1);
        }
    }
}
