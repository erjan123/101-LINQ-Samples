using LinqSamplesCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        private List<Products.Product> productList = Products.GetProductList();
        private List<Customers.Customer> customerList = Customers.GetCustomerList();
        private List<Suppliers.Supplier> supplierList = Suppliers.GetSupplierList();

        //Join Operators
        //This sample shows how to perform a simple inner equijoin of two sequences to 
        //produce a flat result set that consists of each element in suppliers that has a matching element
        //in customers.
        public void Linq102()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var custSupJoin =
                    from sup in suppliers
                    join cust in customers on sup.Country equals cust.Country
                    select new { Country = sup.Country, SupplierName = sup.SupplierName, CustomerName = cust.CompanyName };

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            foreach (var item in custSupJoin.Take(10))
            {
                Console.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", item.Country, item.SupplierName, item.CustomerName);
            }
        }

        public void Linq102A()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            #region Make Sure to try yourself before looking at the code

                var custSupJoin = suppliers
                    .Join(customers, sup => sup.Country, cust => cust.Country,
                    (sup,cust) =>new { sup.Country, sup.SupplierName, CustomerName = cust.CompanyName });

            #endregion

            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat('*',100)));
            Console.WriteLine("Linq with Lambda");
            foreach (var item in custSupJoin.Take(10))
            {
                Console.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", item.Country, item.SupplierName, item.CustomerName);
            }
        }
    }
}
