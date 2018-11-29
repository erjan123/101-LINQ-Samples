using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses a compound from clause to select all orders where the
        //order total is less than 500.00.
        public void DataSetLinq15()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var smallOrders =
                    from c in customers
                    from o in orders
                    where c.Field<string>("CustomerID") == o.Field<string>("CustomerID")
                        && o.Field<decimal>("Total") < 500.00M
                    select new
                    {
                        CustomerID = c.Field<string>("CustomerID"),
                        OrderID = o.Field<int>("OrderID"),
                        Total = o.Field<decimal>("Total")
                    };

            #endregion

            ObjectDumper.Write(smallOrders);
        }
    }
}
