using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        [Category("Aggregate Operators")]
        [Description("This sample uses Aggregate to create a running account balance that " +
             "subtracts each withdrawal from the initial balance of 100, as long as " +
             "the balance never drops below 0.")]
        public void Linq93()
        {
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine("Ending balance: {0}", endBalance);
        }
    }

}
