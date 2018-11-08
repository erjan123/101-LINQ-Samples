using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqSamplesCommon.Model
{
    public class Customers
    {
        static private List<Customer> customerList;

        public class Customer
        {
            public Customer() { }

            public Customer(string customerID, string companyName)
            {
                CustomerID = customerID;
                CompanyName = companyName;
                Orders = new Order[10];
            }

            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public Order[] Orders { get; set; }
        }

        static public List<Customer> GetCustomerList()
        {
            if (customerList == null)
                    createLists();

            return customerList;
        }

        static public void createLists()
        {
            // Customer/Order data read into memory from XML file using XLinq:
            customerList = (
                from e in XDocument.Load("Customers.xml").
                          Root.Elements("customer")
                select new Customer
                {
                    CustomerID = (string)e.Element("id"),
                    CompanyName = (string)e.Element("name"),
                    Address = (string)e.Element("address"),
                    City = (string)e.Element("city"),
                    Region = (string)e.Element("region"),
                    PostalCode = (string)e.Element("postalcode"),
                    Country = (string)e.Element("country"),
                    Phone = (string)e.Element("phone"),
                    Fax = (string)e.Element("fax"),
                    Orders = (
                        from o in e.Elements("orders").Elements("order")
                        select new Order
                        {
                            OrderID = (int)o.Element("id"),
                            OrderDate = (DateTime)o.Element("orderdate"),
                            Total = (decimal)o.Element("total")
                        })
                        .ToArray()
                })
                .ToList();
        }
    }
}
