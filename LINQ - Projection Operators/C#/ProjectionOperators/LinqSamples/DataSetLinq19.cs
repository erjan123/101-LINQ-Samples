using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {

        //Projection Operators
        //This sample uses an indexed SelectMany clause to select all orders, 
        //while referring to customers by the order in which they are returned 
        //from the query.
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

                foreach (var c in customerOrders.Take(10))
                {
                    Console.WriteLine("Customer Index: " + c.CustomerIndex +
                                        " has an order with OrderID " + c.OrderID);
                }

            #endregion
        }

        public void DataSetLinq19A()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  With Query syntax - Make Sure to try yourself before looking at the code

            var customerOrders =
                    from cust in customers.Select((value, index) => new { value, index })
                    from o in orders
                    where cust.value.Field<string>("CustomerID") == o.Field<string>("CustomerID")
                    select new { CustomerIndex = cust.index + 1, OrderID = o.Field<int>("OrderID") };

                Console.WriteLine();
                Console.WriteLine("**************************************");
                Console.WriteLine("With Query syntax.");
                foreach (var c in customerOrders.Take(10))
                {
                    Console.WriteLine("Customer Index: " + c.CustomerIndex +
                                        " has an order with OrderID " + c.OrderID);
                }

            #endregion
        }
    }
}
