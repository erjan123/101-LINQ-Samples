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
        [Category("Join Operators")]
        [Description("A group join produces a hierarchical sequence. The following query is an inner join " +
            " that produces a sequence of objects, each of which has a key and an inner sequence of all matching elements.")]
        public void Linq103()
        {
            List<Customers.Customer> customers = Customers.GetCustomerList();
            List<Suppliers.Supplier> suppliers = Suppliers.GetSupplierList();

            var custSupQuery =
                from sup in suppliers
                join cust in customers on sup.Country equals cust.Country into cs
                select new { Key = sup.Country, Items = cs };


            foreach (var item in custSupQuery)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var element in item.Items)
                {
                    Console.WriteLine("   " + element.CompanyName);
                }
            }
        }
    }
}
