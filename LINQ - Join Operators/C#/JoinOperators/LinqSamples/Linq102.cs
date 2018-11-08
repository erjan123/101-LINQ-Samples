using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using LinqSamplesCommon.Model;

namespace JoinOperators
{
    public partial class LinqSamplesJoinOperators
    {
        private List<Products.Product> productList = Products.GetProductList();
        private List<Customers.Customer> customerList = Customers.GetCustomerList();
        private List<Suppliers.Supplier> supplierList = Suppliers.GetSupplierList();

        [Category("Join Operators")]
        [Description("This sample shows how to perform a simple inner equijoin of two sequences to " +
        "produce a flat result set that consists of each element in suppliers that has a matching element " +
        "in customers.")]
        public void Linq102()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            var custSupJoin =
                from sup in suppliers
                join cust in customers on sup.Country equals cust.Country
                select new { Country = sup.Country, SupplierName = sup.SupplierName, CustomerName = cust.CompanyName };

            foreach (var item in custSupJoin)
            {
                Console.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", item.Country, item.SupplierName, item.CustomerName);
            }
        }
    }
}
