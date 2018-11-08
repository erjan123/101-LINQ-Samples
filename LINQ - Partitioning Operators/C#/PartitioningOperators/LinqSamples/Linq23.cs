using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using LinqSamplesCommon.Model;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        [Category("Partitioning Operators")]
        [Description("This sample uses Take to get all but the first 2 orders from customers " +
             "in Washington.")]
        public void Linq23()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Make Sure to try yourself before looking at the code

                var waOrders =
                    from cust in customers
                    from order in cust.Orders
                    where cust.Region == "WA"
                    select new { cust.CustomerID, order.OrderID, order.OrderDate };

                var allButFirst2Orders = waOrders.Skip(2);

                Console.WriteLine("All but first 2 orders in WA:");
                foreach (var order in allButFirst2Orders)
                {
                    ObjectDumper.Write(order);
                }

            #endregion
        }
    }
}
