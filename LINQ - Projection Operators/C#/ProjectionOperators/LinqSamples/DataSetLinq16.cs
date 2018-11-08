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
                     "order was made in 1998 or later.")]
        public void DataSetLinq16()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

            var myOrders =
                    from c in customers
                    from o in orders
                    where c.Field<string>("CustomerID") == o.Field<string>("CustomerID") &&
                    o.Field<DateTime>("OrderDate") >= new DateTime(1998, 1, 1)
                    select new
                    {
                        CustomerID = c.Field<string>("CustomerID"),
                        OrderID = o.Field<int>("OrderID"),
                        OrderDate = o.Field<DateTime>("OrderDate")
                    };

            #endregion

            ObjectDumper.Write(myOrders);
        }
    }
}
