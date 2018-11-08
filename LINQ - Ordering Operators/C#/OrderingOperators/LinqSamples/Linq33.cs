using LinqSamplesCommon.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses orderby to sort a list of products by units in stock " +
             "from highest to lowest.")]
        public void Linq33()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var sortedProducts =
                    from prod in products
                    orderby prod.UnitsInStock descending
                    select prod;

                ObjectDumper.Write(sortedProducts);

            #endregion
        }
    }
}
