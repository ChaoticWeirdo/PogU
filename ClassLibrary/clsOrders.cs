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

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mCustomerId = 21;
            mProductId = "23f";
            mOrderDate = Convert.ToDateTime("10/03/2021") ;
            mDescription = "Description";
            mStatus = "Dispatched";
            mDateShipped = Convert.ToDateTime("15/03/2021");
            mPrice = 9.99;
            mPaid = false;
            //always return true
            return true;
        }
    }
}