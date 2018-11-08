using System;

namespace LinqSamplesCommon.Model
{
    public class Order
    {
        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }

        public Order() { }

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
