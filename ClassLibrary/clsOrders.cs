using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime ShippedDate { get; set; }
        public double Price { get; set; }
    }
}