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

        //Projection Operators
        //This sample uses a compound from clause to select all orders where the order 
        //was made in 1998 or later.
        public void DataSetLinq16()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var myOrders =
                    from c in customers.Take(10)
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
            // Linq 101 Example
            Console.WriteLine("101 Linq orginal exmple");
            ObjectDumper.Write(myOrders.Take(10));
        }

        public void DataSetLinq16A()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region Query syntax join statement - Make Sure to try yourself before looking at the code

                var myOrders =
                    from c in customers.Take(10)
                    join o in orders
                    on c.Field<string>("CustomerID") equals o.Field<string>("CustomerID")
                    where o.Field<DateTime>("OrderDate") >= new DateTime(1998, 1, 1)
                    select new
                    {
                        CustomerID = o.Field<string>("CustomerID"),
                        OrderID = o.Field<int>("OrderID"),
                        OrderDate = o.Field<DateTime>("OrderDate")
                    };

                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("Query syntax join statement");
                ObjectDumper.Write(myOrders.Take(10));

            #endregion

            #region With Lambda Join statement - Make Sure to try yourself before looking at the code

                var myOrdersLambda =
                    customers
                    .Join(orders, c => c.Field<string>("CustomerID"), o => o.Field<string>("CustomerID"),
                    (c, o) => new
                    {
                        CustomerID = c.Field<string>("CustomerID"),
                        OrderID = o.Field<int>("OrderID"),
                        OrderDate = o.Field<DateTime>("OrderDate")
                    })
                    .Where(o => o.OrderDate >= new DateTime(1998, 1, 1));

                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("Lambda Join statement");
                ObjectDumper.Write(myOrders.Take(10));

            #endregion
        }
    }
}
