using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses multiple from clauses so that filtering on customers can 
        //be done before selecting their orders.  This makes the query more efficient by 
        //not selecting and then discarding orders for customers outside of Washington.
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

                    Console.WriteLine("Linq 101 orginal query result.");
                    ObjectDumper.Write(myOrders);

            #endregion
        }

        public void DataSetLinq18A()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();
            DateTime cutoffDate = new DateTime(1997, 1, 1);

            #region With Lambda syntax - Make Sure to try yourself before looking at the code

            var myOrders = 
                        customers
                            .Where(c => c.Field<string>("Region") == "WA")
                            .Join(orders, c => c.Field<string>("CustomerID"), o => o.Field<string>("CustomerID"),
                                (c, o) => new {
                                    CustomerID = c.Field<string>("CustomerID"),
                                    OrderID = o.Field<int>("OrderID"),
                                    OrderDate = (DateTime)o["OrderDate"]
                            })
                            .Where(o => o.OrderDate > cutoffDate);

            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("With Lambda syntax and join.");
            ObjectDumper.Write(myOrders);

            #endregion
        }
    }
}
