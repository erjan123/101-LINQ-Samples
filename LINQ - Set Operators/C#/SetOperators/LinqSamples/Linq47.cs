using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SetOperators
{
    public partial class LinqSamplesSetOperators
    {
        [Category("Set Operators")]
        [Description("This sample uses Distinct to find the unique Category names.")]
        public void Linq47()
        {
            List<Products.Product> products = Products.GetProductList();

            #region Make Sure to try yourself before looking at the code

                var categoryNames = (
                    from prod in products
                    select prod.Category)
                    .Distinct();

                Console.WriteLine("Category names:");
                foreach (var n in categoryNames)
                {
                    Console.WriteLine(n);
                }

            #endregion
        }
    }
}
