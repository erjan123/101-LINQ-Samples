using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using LinqSamplesCommon.Model;

namespace PartitioningOperators
{
    public partial class LinqSamplesPartitioningOperators
    {
        // Partitioning Operators
        // This sample uses Take to get all but the first 2 orders from customers in Washington.
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

        public void Linq23A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Slightly modified - Make Sure to try yourself before looking at the code

            var allButFirst2Orders =
                    (from cust in customers
                    from order in cust.Orders
                    where cust.Region == "WA"
                    select new { cust.CustomerID, order.OrderID, order.OrderDate })
                    .Skip(2);

                //   var allButFirst2Orders = waOrders.Skip(2);

                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine("Slightly modified - All but first 2 orders in WA:");
                foreach (var order in allButFirst2Orders)
                {
                    ObjectDumper.Write(order);
                }

            #endregion
        }
    }
}
