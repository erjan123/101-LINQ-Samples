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
        [Description("This sample uses Average to get the average price of each category's products.")]
        public void Linq91()
        {
            List<Products.Product> products = Products.GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }
    }
}
