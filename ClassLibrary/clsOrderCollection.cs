using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrders> mOrderList = new List<clsOrders>();
        //private data member for thisOrder
        clsOrders mThisOrder = new clsOrders();

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
        public clsOrders ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }
        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        
        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@ProductId", mThisOrder.ProductId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Description", mThisOrder.Description);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Paid", mThisOrder.Paid);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@DateShipped", mThisOrder.DateShipped);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }
        
        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@ProductId", mThisOrder.ProductId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Description", mThisOrder.Description);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Paid", mThisOrder.Paid);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@DateShipped", mThisOrder.DateShipped);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void ReportByProductId(string ProductId)
        {
            //filters the records based on a full or partial ProductId
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ProductId parameter to the database
            DB.AddParameter("@ProductId", ProductId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByProductId");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrders>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrder = new clsOrders();
                //set the fields from the current record
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