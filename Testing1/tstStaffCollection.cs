using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this cas the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Citizen = true;
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Lucy";
            TestItem.StaffLastName = "James";
            TestItem.Gender = "Female";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.NINo = "AA 12 34 56 C";
            TestItem.PhoneNo = "07038320312";
            TestItem.Address = "Grove road";
            TestItem.PostCode = "MK438SS";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object 
            TestStaff.Citizen = true;
            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Lucy";
            TestStaff.StaffLastName = "James";
            TestStaff.Gender = "Female";
            TestStaff.DateOfBirth = DateTime.Now.Date;
            TestStaff.NINo = "AA 12 34 56 C";
            TestStaff.PhoneNo = "07038320312";
            TestStaff.Address = "Grove road";
            TestStaff.PostCode = "MK438SS";
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this cas the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Citizen = true;
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Lucy";
            TestItem.StaffLastName = "James";
            TestItem.Gender = "Female";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.NINo = "AA 12 34 56 C";
            TestItem.PhoneNo = "07038320312";
            TestItem.Address = "Grove road";
            TestItem.PostCode = "MK438SS";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Citizen = true;
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Lucy";
            TestItem.StaffLastName = "James";
            TestItem.Gender = "Female";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.NINo = "AA 12 34 56 C";
            TestItem.PhoneNo = "07038320312";
            TestItem.Address = "Grove road";
            TestItem.PostCode = "MK438SS";
            //set ThisAddress to the test data 
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //tyest to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's propertites
            TestItem.Citizen = true;
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Lucy";
            TestItem.StaffLastName = "James";
            TestItem.Gender = "Female";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.NINo = "AA 12 34 56 C";
            TestItem.PhoneNo = "07038320312";
            TestItem.Address = "Grove road";
            TestItem.PostCode = "MK438SS";
            //set ThisOrder to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data.
            TestItem.Citizen = false;
            TestItem.StaffID = 3;
            TestItem.StaffFirstName = "Rajesh";
            TestItem.StaffLastName = "Kaheed";
            TestItem.Gender = "Male";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.NINo = "BX 64 44 42 D";
            TestItem.PhoneNo = "07514 537700";
            TestItem.Address = "lewisham way";
            TestItem.PostCode = "EN6 3AQ";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's propertites
            TestItem.Citizen = true;
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Lucy";
            TestItem.StaffLastName = "James";
            TestItem.Gender = "Female";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.NINo = "AA 12 34 56 C";
            TestItem.PhoneNo = "07038320312";
            TestItem.Address = "Grove road";
            TestItem.PostCode = "MK438SS";
            //set ThisOrder to the test data
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredPostCode = new clsStaffCollection();
            //apply a Post Code that doesn't exist
            FilteredPostCode.ReportByPostCode("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredPostCode.Count);
        }
        [TestMethod]
        public void ReportByProductIdTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a PostCode that doesn't exist
            FilteredStaff.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 5
                if (FilteredStaff.StaffList[0].StaffID != 5)
                {
                    OK = false;
                }
                //check that the first record is ID 6
                if (FilteredStaff.StaffList[1].StaffID != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
