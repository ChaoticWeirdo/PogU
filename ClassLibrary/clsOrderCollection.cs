using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrders> mOrderList = new List<clsOrders>();
        public List<clsOrders> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrders ThisOrder { get; set; }

        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.ProductId = Convert.ToString(DB.DataTable.Rows[Index]["ProductId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnOrder.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.Paid = Convert.ToBoolean(DB.DataTable.Rows[Index]["Paid"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.DateShipped = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateShipped"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}