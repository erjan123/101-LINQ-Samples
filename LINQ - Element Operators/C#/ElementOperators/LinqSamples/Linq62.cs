using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        // Element Operators
        // This sample uses FirstOrDefault to return the first product whose ProductID is 789 
        // as a single Product object, unless there is no match, in which case null is returned.
        public void Linq62()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                Products.Product product789 = products.FirstOrDefault(p => p.ProductID == 789);

                Console.WriteLine("Product 789 exists: {0}", product789 != null);

            #endregion
        }
    }
}
