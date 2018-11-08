using LinqSamplesCommon.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ElementOperators
{
    public partial class LinqSamplesElementOperators
    {
        [Category("Element Operators")]
        [Description("This sample uses First to return the first matching element " +
             "as a Product, instead of as a sequence containing a Product.")]
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
    }
}
