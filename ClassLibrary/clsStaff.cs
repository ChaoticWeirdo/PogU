using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff no property 
        private Int32 mStaffID;
        private DateTime mDateOfBirth;
        private string mStaffFirstName;
        private string mStaffLastName;
        private string mGender;
        private string mNINo;
        private string mPhoneNo;
        private string mAddress;
        private string mPostCode;
        private Boolean mCitizen;

        public clsStaff()
        {
        }

        public bool Citizen
        {
            get
            {
                //return the private data 
                return mCitizen;
            }
            set
            {
                //set the private data
                mCitizen = value;
            }
        }
        public DateTime DateOfBirth

        {
            get

            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //the private data 
                mDateOfBirth = value;

            }

        }
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property 
                mStaffID = value;
            }
        }
        public string PostCode
        {
            get
            {
                //return the private data 
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }
        public string Address
        {
            get
            {
                //return the private data 
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }
        public string PhoneNo
        {
            get
            {
                //return the private data 
                return mPhoneNo;
            }
            set
            {
                //set the private data
                mPhoneNo = value;
            }
        }
        public string NINo
        {
            get
            {
                //return the private data 
                return mNINo;
            }
            set
            {
                //set the private data
                mNINo = value;
            }
        }
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
        public string StaffLastName
        {
            get
            {
                //return the private data 
                return mStaffLastName;
            }
            set
            {
                //set the private data
                mStaffLastName = value;
            }
        }
        public string StaffFirstName
        {
            get
            {
                //return the private data 
                return mStaffFirstName;
            }
            set
            {
                //set the private data
                mStaffFirstName = value;
            }
        }

        public bool Find(int staffID)
        {
            //set the private data members to the test data value 
            mStaffID = 21;
            mDateOfBirth = Convert.ToDateTime("19/5/2014");
            mStaffFirstName = "test name";
            mStaffLastName = "test name";
            mGender = "test Gender";
            mNINo = "test NiNo";
            mPhoneNo = "Test PhoneNo";
            mAddress = "Test Address";
            mPostCode = "Test Post Code";
            mCitizen = true;
            //always return true 
            return true;
        }
    }
}