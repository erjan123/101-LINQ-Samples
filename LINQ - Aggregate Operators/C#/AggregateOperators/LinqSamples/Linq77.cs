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
        [Description("This sample uses Count to return a list of categories and how many products " +
             "each has.")]
        public void Linq77()
        {
            List<Products.Product> products = Products.GetProductList();

            var categoryCounts =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };

            ObjectDumper.Write(categoryCounts);
        }
    }
}
