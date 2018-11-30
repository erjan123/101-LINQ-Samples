using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        // Element Operators
        // This sample uses First to return the first matching element
        // as a Product, instead of as a sequence containing a Product.
        public void Linq58()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                Products.Product product12 = (
                    from prod in products
                    where prod.ProductID == 12
                    select prod)
                    .First();

            ObjectDumper.Write(product12);

            #endregion
        }

        public void Linq58A()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                Products.Product product12 = products.Where(prod => prod.ProductID == 12).First();

                 Console.WriteLine();
                 Console.WriteLine("*****************************");
                 Console.WriteLine("Linq with Linq");
                 ObjectDumper.Write(product12);

            #endregion
        }
    }
}
