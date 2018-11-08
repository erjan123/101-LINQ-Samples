using LinqSamplesCommon.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace OrderingOperators
{
    public partial class LinqSamplesOrderingOperators
    {
        [Category("Ordering Operators")]
        [Description("This sample uses a compound orderby to sort a list of products, " +
                     "first by category, and then by unit price, from highest to lowest.")]
        public void Linq37()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var sortedProducts =
                    from prod in products
                    orderby prod.Category, prod.UnitPrice descending
                    select prod;

                ObjectDumper.Write(sortedProducts);

            #endregion
        }

    }
}
