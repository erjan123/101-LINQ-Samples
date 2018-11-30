using System;
using System.Data;
using System.Linq;

namespace GroupingOperators
{
    public partial class LinqSamplesGroupingOperators
    {
        // Grouping Operators
        // This sample uses group by to partition a list of each customer's orders,
        // first by year, and then by month.
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

                foreach (var cog in customerOrderGroups.Take(3))
                {
                    Console.WriteLine("CompanyName= {0}", cog.CompanyName);
                    foreach (var yg in cog.YearGroups.Take(3))
                    {
                        Console.WriteLine("\t Year= {0}", yg.Year);
                        foreach (var mg in yg.MonthGroups.Take(3))
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

        public void DataSetLinq43A()
        {
            var customers = testDS.Tables["Customers"].AsEnumerable();

            #region Linq with Lambda - Make Sure to try yourself before looking at the code 

                var customerOrderGroups =
                customers
                    .Select( c =>
                        new
                        {
                            CompanyName = c.Field<string>("CompanyName"),
                            YearGroups =
                                c.GetChildRows("CustomersOrders")
                                .GroupBy(o => o.Field<DateTime>("OrderDate").Year) 
                                .Select( yg =>
                                    new
                                    {
                                        Year = yg.Key,
                                        MonthGroups =
                                             yg
                                            .GroupBy(o => o.Field<DateTime>("OrderDate").Month)
                                            .Select(mg => new { Month = mg.Key, Orders = mg }).Take(3)
                                    }).Take(3)
                        }).Take(3);

            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine("Linq with Lambda.");
            Console.WriteLine();
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
