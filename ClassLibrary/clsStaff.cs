﻿using System;

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

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameter for the StaffID to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mNINo = Convert.ToString(DB.DataTable.Rows[0]["NINo"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mCitizen = Convert.ToBoolean(DB.DataTable.Rows[0]["Citizen"]);
                //return that everything worked OK
                return true;

            }
            //if mo record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        // fuction for the public validation method
        public string Valid(string StaffFirstName,
                            string StaffLastName,
                            string Gender,
                            string DateOfBirth,
                            string NiNo,
                            string PhoneNo,
                            string Address,
                            string PostCode)
        ///this function accepts 8 parameters for validation 
        ///the function returns a string containing any error message
        ///if no errors forund then a blank string is returned
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values 
            DateTime DateTemp;
            // if the StaffFirstName is blank
            if (StaffFirstName.Length == 0)
            {
                //record the error 
                Error = Error + " first name may not be blank:";
            }
            try
            {
                //copy the date of birth value to the dateTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date :";
            }     
            //return any error messages 
            return Error;
        }
    }
}