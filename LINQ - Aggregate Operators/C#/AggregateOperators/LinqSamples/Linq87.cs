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
        [Description("This sample uses Max to get the most expensive price among each category's products.")]
        public void Linq87()
        {
            List<Products.Product> products = Products.GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, MostExpensivePrice = prodGroup.Max(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }
    }
}
