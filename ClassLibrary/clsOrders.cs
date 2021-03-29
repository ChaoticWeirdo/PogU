using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the OrderId Property
        private Int32 mOrderId;
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }
        //private data member for the CustomerId Property
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        //private data member for the ProductId Property
        private string mProductId;
        //ProductId public property
        public string ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }
        //private data member for the OrderDate Property
        private DateTime mOrderDate;
        //OrderDate public property
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        //private data member for the Description Property
        private string mDescription;
        //Description public property
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        //private data member for the Status Property
        private string mStatus;
        //Status public property
        public string Status
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }
        //private data member for the DateShipped Property
        private DateTime mDateShipped;
        //DateShipped public property
        public DateTime DateShipped
        {
            get
            {
                return mDateShipped;
            }
            set
            {
                mDateShipped = value;
            }
        }
        //private data member for the Price Property
        private double mPrice;
        //Price public property
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        //private data member for the Paid Property
        private Boolean mPaid;
        //Paid public property
        public bool Paid
        {
            get
            {
                return mPaid;
            }
            set
            {
                mPaid = value;
            }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderId to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mProductId = Convert.ToString(DB.DataTable.Rows[0]["ProductId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mDateShipped = Convert.ToDateTime(DB.DataTable.Rows[0]["DateShipped"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["Paid"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }         
        }

        public string Valid(string customerId, string productId, string orderDate, string description, string price, string status, string dateShipped)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store datee values
            DateTime DateTemp;

            //if the Customer Id is blank
            if (customerId.Length == 0)
            {
                //record the error
                Error = Error + "The Customer ID may not be blank : ";
            }

            //if the customer Id is greater than 6 characters
            if (customerId.Length > 6)
            {
                //record the error
                Error = Error + "The Customer ID must be less than 7 character : ";
            }

            //if Product Id is blank
            if (productId.Length == 0)
            {
                //record the error
                Error = Error + "The Product ID may not be blank : ";
            }

            //if the Product Id is greater than 6 characters
            if (productId.Length > 6)
            {
                //record the error
                Error = Error + "The Product ID must be less that 7 characters : ";
            }

            /*
            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }*/

            //if Description is blank
            if (description.Length == 0)
            {
                //record the error
                Error = Error + "The Description may not be blank : ";
            }

            //if the Description is greater than 25 characters
            if (description.Length > 25)
            {
                //record the error
                Error = Error + "The Description must be less that 26 characters : ";
            }

            //if the Price is blank
            if (price.Length == 0)
            {
                //record error
                Error = Error + "The Price may not be blank : ";
            }

            //if the Price is greater than 7 characters
            if (price.Length > 7)
            {
                //record the error
                Error = Error + "The Price must be less than 8 characters : ";
            }

            //if the Status is blank
            if (status.Length == 0)
            {
                //record the error
                Error = Error + "The Status may not be blank : ";
            }

            //if the Status is greater than 15 characters
            if (status.Length > 15)
            {
                //record the error
                Error = Error + "The Status must be less than 16 characters : ";
            }

            /*
            try
            {
                //copy the DateShipped value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateShipped);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            */

            //return any error messages
            return Error; 
        }
        
    }
}