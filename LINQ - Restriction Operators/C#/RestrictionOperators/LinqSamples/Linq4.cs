using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // Display order ID and order date for all customers in Washington (Region == "WA")
        // This sample uses the where clause to find all customers in Washington
        // and then it uses a foreach loop to iterate over the orders collection that belongs 
        // to each customer.
        public void Linq4()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Make Sure to try yourself before looking at the code 

                var waCustomers =
                    from cust in customers
                    where cust.Region == "WA"
                    select cust;

                Console.WriteLine("With Query syntax - Customers from Washington and their orders:");
                Console.WriteLine();
                foreach (var customer in waCustomers)
                {
                    Console.WriteLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                    }
                } 

            #endregion
        }

        // Linq with Lambda
        public void Linq4A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Make Sure to try yourself before looking at the code 

            var waCustomers = customers.Where(cust => cust.Region == "WA");
   
                Console.WriteLine("*******************************************");
                Console.WriteLine("With Lambda expression - Customers from Washington and their orders:");
                Console.WriteLine();
                foreach (var customer in waCustomers)
                {
                    Console.WriteLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                    }
                }

            #endregion
        }
    }
}
