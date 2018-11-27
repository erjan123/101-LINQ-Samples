using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using LinqSamplesCommon.LinqSamplesHelpers;


namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        public DataSet testDS;

        public LinqSamplesProjectionOperators()
        {
           testDS = TestHelper.CreateTestDataset();
        }

        [Category("Projection Operators")]
        [Description("This sample uses select to produce a sequence of ints one higher than " +
             "those in an existing array of ints.")]
        public void DataSetLinq6()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();

            #region Make Sure to try yourself before looking at the code 

                var numsPlusOne =
                    from n in numbers
                    select n.Field<int>(0) + 1;

                Console.WriteLine("Numbers + 1:");
                foreach (var i in numsPlusOne)
                {
                    Console.WriteLine(i);
                }

            #endregion

        }
        
        public void DataSetLinq6A()
        {
            var numbers = testDS.Tables["Numbers"].AsEnumerable();
            // Lets make this example first simpler

            int[] myLovelyNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> myLovelyNumbers2 = Enumerable.Range(1, 100);
            Random myRandom = new Random();
            byte[] bytes = new byte[100];
            myRandom.NextBytes(bytes);

            var updatedLovelyNumbers =
                        from num in bytes
                        select num + 1;

            updatedLovelyNumbers.ToList().ForEach(number => Console.WriteLine(number));

            foreach(var v in numbers)
                Console.WriteLine(v.Field<int>(0));
   
            var newNumbers =
                    from num in numbers
                    select (num.Field<int>("number") + 1);

            var newNumbers2 =
                     numbers
                     .Select(num => num.Field<int>("number") + 1);


            Console.WriteLine("Hello World !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            foreach(var number in newNumbers2)
                Console.WriteLine(number);
        }
    }
}
