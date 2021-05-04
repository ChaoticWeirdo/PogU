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
            AllStaff.ThisStaff.Fibd(PrimaryKey);
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

    }
}
