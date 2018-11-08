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
        [Description("This sample uses an indexed SelectMany clause to select all orders, " +
                     "while referring to customers by the order in which they are returned " +
                     "from the query.")]
        public void DataSetLinq19()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var customerOrders =
                    customers.SelectMany(
                        (cust, custIndex) =>
                        orders.Where(o => cust.Field<string>("CustomerID") == o.Field<string>("CustomerID"))
                            .Select(o => new { CustomerIndex = custIndex + 1, OrderID = o.Field<int>("OrderID") }));

                foreach (var c in customerOrders)
                {
                    Console.WriteLine("Customer Index: " + c.CustomerIndex +
                                        " has an order with OrderID " + c.OrderID);
                }

            #endregion
        }
    }
}
