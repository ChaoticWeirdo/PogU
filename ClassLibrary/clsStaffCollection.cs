using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        //puclic property for the staff list 
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data 
                return mStaffList;
            }
            set
            {
                //set the private data 
                mStaffList = value;
            }
        }

        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list 
                return mStaffList.Count;
            }
            set
            {
                //
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

        public int Add()
        {
            // adds new record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramenters for the procedure 
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@NINo", mThisStaff.NINo);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@Citizen", mThisStaff.Citizen);
            //execute the quiery returning the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // adds new record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramenters for the procedure
            DB.AddParameter("@StaffiD", mThisStaff.StaffID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@NINo", mThisStaff.NINo);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@Citizen", mThisStaff.Citizen);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }



        public clsStaff ThisStaff
        {
            get
            {
                //return the private data 
                return mThisStaff;
            }
            set
            {
                //set the private data 
                mThisStaff = value;
            }
        }




        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial PostCode
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByPostCode");
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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record 
                AnStaff.Citizen = Convert.ToBoolean(DB.DataTable.Rows[Index]["Citizen"]);
                AnStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstname"]);
                AnStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastname"]);
                AnStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnStaff.NINo = Convert.ToString(DB.DataTable.Rows[Index]["NINo"]);
                AnStaff.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                //add the records to the private data memeber 
                mStaffList.Add(AnStaff);
                //point at the next record 
                Index++;
            }
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
}