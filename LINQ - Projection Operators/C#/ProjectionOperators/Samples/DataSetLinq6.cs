using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Xml.Linq;

namespace ProjectionOperators
{
    partial class Program
    {

        private partial class LinqSample
        {
          //  private DataSet testDS;

            [Category("Projection Operators")]
            [Description("This sample uses select to produce a sequence of ints one higher than " +
             "those in an existing array of ints.")]
            public void DataSetLinq6()
            {

                var numbers = testDS.Tables["Numbers"].AsEnumerable();

                var numsPlusOne =
                    from n in numbers
                    select n.Field<int>(0) + 1;

                Console.WriteLine("Numbers + 1:");
                foreach (var i in numsPlusOne)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    internal partial class TestHelper
    {
    }

    public partial class Customer
    {
    }

    public partial class Order
    {
    }
}
