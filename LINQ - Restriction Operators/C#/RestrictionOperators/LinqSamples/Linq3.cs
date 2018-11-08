using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // List all products that are in stock that cost more than 3.00 per unit. 
        [Description("This sample uses the where clause to find all products that are in stock and " +
         "cost more than 3.00 per unit.")]
        public void Linq3()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code 

                var expensiveInStockProducts =
                    from prod in products
                    where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                    select prod;

                Console.WriteLine("In-stock products that cost more than 3.00:");
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

                var expensiveInStockProducts =
                    from prod in products
                    where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                    select prod;

                Console.WriteLine("In-stock products that cost more than 3.00:");
                foreach (var product in expensiveInStockProducts)
                {
                    Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
                }

            #endregion
        }
    }
}
