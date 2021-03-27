using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists 
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void CitizenPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Citizen = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Citizen, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the propert
            AnStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Brixton drive";
            //assign the data to the property
            AnStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Address, TestData);

        }

        [TestMethod]
        public void PhoneNoPropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "0743465436754";
            //assign the data to the property
            AnStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PhoneNo, TestData);

        }

        [TestMethod]
        public void NINoPropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "AA123456C";
            //assign the data to the property
            AnStaff.NINo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.NINo, TestData);

        }

        [TestMethod]
        public void GenderPropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            AnStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Gender, TestData);

        }

        [TestMethod]
        public void StaffLastNamePropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Williams";
            //assign the data to the property
            AnStaff.StaffLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffLastName, TestData);

        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Josh";
            //assign the data to the property
            AnStaff.StaffFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffFirstName, TestData);

        }

        [TestMethod]
        public void FindMethodOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //test to see if the result is true 
            Assert.IsTrue(Found);

        }

        public void TestStaffNoFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the StaffID
            if (AnStaff.StaffID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        public void TestDateOfBirth()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.DateOfBirth != Convert.ToDateTime("19/05/2014"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void StaffFirstName()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.StaffFirstName != "Test name")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void StaffLastName()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.StaffLastName != "Test name")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void Gender()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.Gender != "Test Gender")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void PhoneNo()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.PhoneNo != "0758435638653")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void NINo()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.NINo != "Test Natiomal insurance number`")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        public void Address()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.Address != "Chessnut grove")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void PostCode()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void Citizen()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the Property
            if (AnStaff.Citizen != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}
