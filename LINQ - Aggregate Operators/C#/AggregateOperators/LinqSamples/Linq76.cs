using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        [Category("Aggregate Operators")]
        [Description("This sample uses Count to return a list of customers and how many orders " +
             "each has.")]
        public void Linq76()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            var orderCounts =
                from cust in customers
                select new { cust.CustomerID, OrderCount = cust.Orders.Count() };

            ObjectDumper.Write(orderCounts);
        }
    }
}
