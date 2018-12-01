using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Count to return a list of customers and how many orders each has.
        public void Linq76()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Make Sure to try yourself before looking at the code

                var orderCounts = 
                    from cust in customers
                    select new { cust.CustomerID, OrderCount = cust.Orders.Count()};

            #endregion

            Console.WriteLine("Orginal 101 Linq() examples.");
            ObjectDumper.Write(orderCounts.Take(10));
        }

        public void Linq76A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code

                var orderCounts = customers.Select(cust => new { cust.CustomerID, OrderCount = cust.Orders.Count() });

            #endregion

            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine("Linq with Lambda.");
            ObjectDumper.Write(orderCounts.Take(10));
        }
    }
}
