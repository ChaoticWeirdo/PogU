﻿using ClassLibrary;
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
    }
}
