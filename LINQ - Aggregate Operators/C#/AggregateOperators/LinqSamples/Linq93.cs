using System;
using System.Linq;

namespace AggregateOperators
{
    public partial class LinqSamplesAggregateOperators
    {
        //Aggregate Operators
        //This sample uses Aggregate to create a running account balance that
        //subtracts each withdrawal from the initial balance of 100, as long as
        //the balance never drops below 0.
        public void Linq93()
        {
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            #region Make Sure to try yourself before looking at the code

                double endBalance =
                    attemptedWithdrawals.Aggregate(startBalance,
                        (balance, nextWithdrawal) =>
                            ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            #endregion

            Console.WriteLine("Orginal 101 Linq examples.");
            Console.WriteLine("Ending balance: {0}", endBalance);
        }
    }

}
