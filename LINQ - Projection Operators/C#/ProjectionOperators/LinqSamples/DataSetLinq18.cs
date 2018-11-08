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
        [Description("This sample uses multiple from clauses so that filtering on customers can " +
             "be done before selecting their orders.  This makes the query more efficient by " +
             "not selecting and then discarding orders for customers outside of Washington.")]
        public void DataSetLinq18()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();
            DateTime cutoffDate = new DateTime(1997, 1, 1);

            #region  Make Sure to try yourself before looking at the code

                var myOrders =
                    from c in customers
                    where c.Field<string>("Region") == "WA"
                    from o in orders
                    where c.Field<string>("CustomerID") == o.Field<string>("CustomerID")
                    && (DateTime)o["OrderDate"] >= cutoffDate
                    select new { CustomerID = c.Field<string>("CustomerID"), OrderID = o.Field<int>("OrderID") };

            #endregion

            ObjectDumper.Write(myOrders);
        }
    }
}
