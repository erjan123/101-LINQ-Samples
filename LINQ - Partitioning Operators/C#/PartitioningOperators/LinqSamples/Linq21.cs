using System;
using System.Linq;
using Customer = LinqSamplesCommon.Model.Customers;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning Operators
        // This sample uses Take to get the first 3 orders from customers
        // in Washington.
        public void Linq21()
        {
           var customers = Customer.GetCustomerList();

            #region Make Sure to try yourself before looking at the code

                var first3WAOrders = (
                    from cust in customers
                    from order in cust.Orders
                    where cust.Region == "WA"
                    select new { cust.CustomerID, order.OrderID, order.OrderDate })
                    .Take(3);

                Console.WriteLine("First 3 orders in WA:");
                foreach (var order in first3WAOrders)
                {
                    ObjectDumper.Write(order);
                }

            #endregion
        }
    }
}
