using LinqSamplesCommon.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of products by name. " +
            "Use the \"descending\" keyword at the end of the clause to perform a reverse ordering.")]
        public void Linq30()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var sortedProducts =
                    from prod in products
                    orderby prod.ProductName
                    select prod;

                ObjectDumper.Write(sortedProducts);

            #endregion
        }
    }
}
