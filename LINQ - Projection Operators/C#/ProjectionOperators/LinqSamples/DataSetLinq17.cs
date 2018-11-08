using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        [Category("Projection Operators")]
        [Description("This sample uses a compound from clause to select all orders where the " +
             "order total is greater than 2000.00 and uses from assignment to avoid " +
             "requesting the total twice.")]
        public void DataSetLinq17()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

            var myOrders =
                    from c in customers
                    from o in orders
                    let total = o.Field<decimal>("Total")
                    where c.Field<string>("CustomerID") == o.Field<string>("CustomerID")
                        && total >= 2000.0M
                    select new { CustomerID = c.Field<string>("CustomerID"), OrderID = o.Field<int>("OrderID"), total };

            #endregion

            ObjectDumper.Write(myOrders);
        }
    }
}
