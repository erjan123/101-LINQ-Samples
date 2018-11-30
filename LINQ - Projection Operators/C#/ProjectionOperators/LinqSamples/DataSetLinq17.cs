using System;
using System.Data;
using System.Linq;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses a compound from clause to select all orders where the
        //order total is greater than 2000.00 and uses from assignment to avoid 
        //requesting the total twice.
        //Note: Use "Let" keyword
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

                Console.WriteLine("Linq 101 orginal query result.");
                ObjectDumper.Write(myOrders.Take(10));

            #endregion

        }

        public void DataSetLinq17A()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();
            var orders = testDS.Tables["Orders"].AsEnumerable();

            #region  With Query syntax and join - Make Sure to try yourself before looking at the code

            var myOrders =
                    from c in customers
                    join o in orders on
                    c.Field<string>("CustomerID") equals o.Field<string>("CustomerID")
                    let total = o.Field<decimal>("Total")
                    where total >= 2000.0M
                    select new { CustomerID = c.Field<string>("CustomerID"), OrderID = o.Field<int>("OrderID"), total };

                    Console.WriteLine();
                    Console.WriteLine("**************************************");
                    Console.WriteLine("With Query syntax and join.");
                    ObjectDumper.Write(myOrders.Take(10));

            #endregion

            #region Lambda syntax and join - Make Sure to try yourself before looking at the code
                // Note: In Linq Lambda syntax "let" becomes "Select", however this
                // example is not a good example to demonstrate "let" conversion
                var myOrders2 =
                    customers
                    .Join(orders, c => c.Field<string>("CustomerID"), o => o.Field<string>("CustomerID"),
                     (c, o) => new {
                         CustomerID = c.Field<string>("CustomerID"),
                         OrderID = o.Field<int>("OrderID"),
                         Total = o.Field<decimal>("Total")
                     })
                    .Where(o => o.Total >= 2000.0M);
              
                Console.WriteLine();
                Console.WriteLine("**************************************");
                Console.WriteLine("With Lambda syntax and join.");
                ObjectDumper.Write(myOrders.Take(10));

            #endregion
        }
    }
}
