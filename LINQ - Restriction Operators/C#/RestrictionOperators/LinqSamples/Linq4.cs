using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        // Display order ID and order date for all customers in Washington
        [Description("This sample uses the where clause to find all customers in Washington " +
         "and then it uses a foreach loop to iterate over the orders collection that belongs to each customer.")]
        public void Linq4()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();

            #region Make Sure to try yourself before looking at the code 

                var waCustomers =
                    from cust in customers
                    where cust.Region == "WA"
                    select cust;

                Console.WriteLine("Customers from Washington and their orders:");
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

            IEnumerable<Customers.Customer> companiesQuery =
                                                from company in customers
                                                where company.Region == "WA"
                                                select company;

            IEnumerable<Customers.Customer> companiesLambda =
                                   customers.Where(company => company.Region == "WA");
                      

                                

            Console.WriteLine("Hello World!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            foreach(var customer in companiesLambda)
            {
                Console.WriteLine("Customer Name : {0} Customer ID : {1} ", customer.CompanyName, customer.CustomerID);
                foreach(var order in customer.Orders)
                {
                    Console.WriteLine("Order ID : {0} Order Date : {1} ", order.OrderID, order.OrderDate);
                }
            }

            var result = companiesLambda.Where(s => s.Region == "WA").SelectMany(x => x.Orders);

                foreach(var v in result)
                {
                    Console.WriteLine(v.OrderID);
                Console.WriteLine(v.OrderDate);
                }
                

        }
    }
}
