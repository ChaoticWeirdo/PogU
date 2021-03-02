using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool LimitedStock { get; set; }
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public int ProductType { get; set; }
        public int Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}