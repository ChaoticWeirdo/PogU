using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool LimitedStock { get; set; }
        public int ProductID { get; set; }
        public DateTime DateAdded { get; set; }
        public string ProductName { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}