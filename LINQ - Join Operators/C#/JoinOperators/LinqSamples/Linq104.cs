using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        [Category("Join Operators")]
        [Description("The group join operator is more general than join, as this slightly more verbose " +
    "version of the cross join sample shows.")]
        public void Linq104()
        {
            string[] categories = new string[]{
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood" };

            List<Products.Product> products = Products.GetProductList();

            var prodByCategory =
                from cat in categories
                join prod in products on cat equals prod.Category into ps
                from p in ps
                select new { Category = cat, p.ProductName };

            foreach (var item in prodByCategory)
            {
                Console.WriteLine(item.ProductName + ": " + item.Category);
            }
        }
    }
}
