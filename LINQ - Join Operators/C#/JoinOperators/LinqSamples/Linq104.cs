using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        //Join Operators
        //The group join operator is more general than join, as this slightly more verbose 
        //version of the cross join sample shows.
        public void Linq104()
        {
            string[] categories = new string[]{
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood" };

            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var prodByCategory =
                    from cat in categories
                    join prod in products on cat equals prod.Category into ps
                    from p in ps
                    select new { Category = cat, p.ProductName };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            foreach (var item in prodByCategory.Take(10))
            {
                Console.WriteLine(item.ProductName + ": " + item.Category);
            }
        }

        public void Linq104A()
        {
            string[] categories = new string[]{
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood" };

            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var prodByCategory = categories
                        .GroupJoin(products, cat => cat, prod => prod.Category,
                        (cat, ps) => new { Category = cat, ps})
                        .SelectMany(x => x.ps, (cat,ps) => new { cat.Category, ps.ProductName });

            #endregion

            Console.WriteLine();
            Console.WriteLine("************************************************");
            Console.WriteLine("Linq with Lambda.");
            foreach (var item in prodByCategory.Take(10))
            {
                Console.WriteLine(item.ProductName + ": " + item.Category);
            }
        }
    }
}
