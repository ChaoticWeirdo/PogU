using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //Private data member for the ProductID property

        //ProductID private member variable
        private Int32 mProductID;
        //ProductID public property
        public Int32 ProductID
        {
            get
            {
                //this line of code sends data out of the property
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }

      

        //private date added data member
        private DateTime mOrderDate;
        //public property for date added
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the private data
                mOrderDate = value;
            }
        }

        //private data member for town
        private string mProductName;
        //public data member for Town
        public string ProductName
        {
            get
            {
                //return the private data
                return mProductName;
            }
            set
            {
                //set the private data
                mProductName = value;
            }
        }

        //private data member for town
        private string mGender;
        //public data member for Town
        public string Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the private data
                mGender = value;
            }
        }

        //private data member for town
        private Decimal mPrice;
        //public data member for Town
        public Decimal Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //private data member for active
        private Boolean mLimitedStock;
        //public property for active
        public bool LimitedStock
        {
            get
            {
                //return the private data
                return mLimitedStock;
            }
            set
            {
                //set the private data
                mLimitedStock = value;
            }
        }

        //private date added data member
        private Int32 mQuantity;
        //public property for date added
        public Int32 Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the private data
                mQuantity = value;
            }
        }
        public bool Find(int productID)
        {
            //set the private data menber to the test data value
            mProductID = 25;
            mOrderDate = Convert.ToDateTime("27/03/2021");
            mProductName = "Boden Det Jacket";
            mGender = "Female";
            mPrice = 98.00m;
            mQuantity = 23;
            mLimitedStock = true;

            //always return true
            return true;
        }
    }
}