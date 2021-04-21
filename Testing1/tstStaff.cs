using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data 
        //create some test data to pass to the method 
        string StaffFirstName = "Lucy";
        string StaffLastName = "Williams";
        string Gender = "Female";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string NINo = "EE586151";
        string PhoneNo = "07472219382";
        string Address = "lime wood av";
        string PostCode = "CT216PQ";

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

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }[dbo].[tblStaff]

        [TestMethod]

        public void FindMethodOK()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StaffID = 2;
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
            Int32 StaffID = 2;
            //invoke the method 
            Found = AnStaff.Find(StaffID);
            //check the StaffID
            if (AnStaff.StaffID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        public void TestDateOfBirthFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void StaffFirstNameFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void StaffLastNameFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void GenderFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void PhoneNoFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void NINoFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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
        public void AddressFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void PostCodeFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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

        public void CitizenFound()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
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
