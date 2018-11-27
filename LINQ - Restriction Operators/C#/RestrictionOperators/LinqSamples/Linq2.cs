﻿using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
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
    }
}
