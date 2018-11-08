using System;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        [Category("Grouping Operators")]
        [Description("This sample uses group by to partition a list of products by category.")]
        public void DataSetLinq42()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var productGroups =
                    from p in products
                    group p by p.Field<string>("Category") into g
                    select new { Category = g.Key, Products = g };

                foreach (var g in productGroups)
                {
                    Console.WriteLine("Category: {0}", g.Category);
                    foreach (var w in g.Products)
                    {
                        Console.WriteLine("\t" + w.Field<string>("ProductName"));
                    }
                }

            #endregion
        }
    }
}
