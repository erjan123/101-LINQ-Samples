using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // This sample uses the where clause to find all products that are in stock and 
        // cost more than 3.00 per unit.")]
        public void Linq3()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code 

                var expensiveInStockProducts =
                    from prod in products
                    where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                    select prod;

                Console.WriteLine("Linq with Query syntax - In-stock products that cost more than 3.00:");
                Console.WriteLine();
                foreach (var product in expensiveInStockProducts)
                {
                    Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
                } 

            #endregion
        }

        // Linq with Lambda
        public void Linq3A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code 

                var expensiveInStockProducts = products.Where(
                                                    prod => prod.UnitsInStock >= 0 && 
                                                    prod.UnitPrice >= 3.00M
                                                    );

                Console.WriteLine("************************************************************************");
                Console.WriteLine("Linq with Lambda expression - In-stock products that cost more than 3.00:");
                Console.WriteLine();
                foreach (var product in expensiveInStockProducts)
                {
                    Console.WriteLine("{0} is in stock and costs {1}.", product.ProductName, product.UnitPrice);
                }

            #endregion

        }
    }
}
