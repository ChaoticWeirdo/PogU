﻿using System;
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
            return DB.Execute("sproc_tblStaff_Inser");
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

                

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection 
            clsStaffCollection DB = new clsStaffCollection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
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


    }
}