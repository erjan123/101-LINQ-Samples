using System;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        [Category("Grouping Operators")]
        [Description("This sample uses group by to partition a list of each customer's orders, " +
             "first by year, and then by month.")]
        public void DataSetLinq43()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var customerOrderGroups =
                    from c in customers
                    select
                        new
                        {
                            CompanyName = c.Field<string>("CompanyName"),
                            YearGroups =
                                from o in c.GetChildRows("CustomersOrders")
                                group o by o.Field<DateTime>("OrderDate").Year into yg
                                select
                                    new
                                    {
                                        Year = yg.Key,
                                        MonthGroups =
                                            from o in yg
                                            group o by o.Field<DateTime>("OrderDate").Month into mg
                                            select new { Month = mg.Key, Orders = mg }
                                    }
                        };

                foreach (var cog in customerOrderGroups)
                {
                    Console.WriteLine("CompanyName= {0}", cog.CompanyName);
                    foreach (var yg in cog.YearGroups)
                    {
                        Console.WriteLine("\t Year= {0}", yg.Year);
                        foreach (var mg in yg.MonthGroups)
                        {
                            Console.WriteLine("\t\t Month= {0}", mg.Month);
                            foreach (var order in mg.Orders)
                            {
                                Console.WriteLine("\t\t\t OrderID= {0} ", order.Field<int>("OrderID"));
                                Console.WriteLine("\t\t\t OrderDate= {0} ", order.Field<DateTime>("OrderDate"));
                            }
                        }
                    }
                }

            #endregion
        }
    }
}
