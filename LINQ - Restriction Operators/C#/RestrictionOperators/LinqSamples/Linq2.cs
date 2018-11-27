using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
    public static class ExtentionMethods
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (action == null)
                return;

            foreach (T str in source)
                action(str);
        }
    }
    public partial class LinqSamplesRestrictionOperators
    {

        // Find all numbers that are out of stock
        [Description("This sample uses the where clause to find all products that are out of stock.")]
        public void Linq2()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code 

                var soldOutProducts =
                    from prod in products
                    where prod.UnitsInStock == 0
                    select prod;

                Console.WriteLine("Sold out products:");
                foreach (var product in soldOutProducts)
                {
                    Console.WriteLine("{0} is sold out!", product.ProductName);
                } 

            #endregion
        }

        // Linq with Lambda
        public void Linq2A()
        {
            List<Products.Product> products = Products.GetProductList();

            IEnumerable<string> outOfStockProductsQueryString =
                                     from prod in products
                                     where prod.UnitsInStock == 0
                                     select prod.ProductName;

            IEnumerable<string> outOfStockProductsLambda =  products
                                                             .Where(prod => prod.UnitsInStock == 0)
                                                             .Select(prod => prod.ProductName);

            IEnumerable<string> outOfStockProductsEnumerator =                               
                                                                Enumerable.Select(
                                                                    Enumerable.Where(products, 
                                                                    prod => prod.UnitsInStock == 0),
                                                                prod => prod.ProductName);

            //foreach(string product in outOfStockProductsEnumerator)
            //{
            //    Console.WriteLine(product);
            //}


            // outOfStockProductsEnumerator.ToList().ForEach(product => Console.WriteLine(product));
            // outOfStockProductsEnumerator.ToList().ForEach(
            //                                             delegate (string product) 
            //                                             {
            //                                                     Console.WriteLine(product);
            //                                             });
            // Action<string> mySpecialAction = GetOutOfStockProducts;

            //outOfStockProductsEnumerator.ToList().ForEach((product => GetOutOfStockProducts(product)));

            // outOfStockProductsEnumerator.ToList().ForEach(product => mySpecialAction(product));

            outOfStockProductsEnumerator.ForEach(product => Console.WriteLine(product));
        }

        public static void GetOutOfStockProducts(string s)
        {
            Console.WriteLine(s);
        }

    }
}
