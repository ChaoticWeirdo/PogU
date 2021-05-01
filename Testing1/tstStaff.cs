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

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName,StaffLastName,Gender,DateOfBirth,NINo,PhoneNo,Address,PostCode);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        public void StaffFirstNameMin()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void StaffFirstNameMinPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        
        [TestMethod]

        public void StaffFirstNameMaxLessOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffFirstName = StaffFirstName.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        

        public void StaffFirstNameMax()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffFirstName = StaffFirstName.PadRight(50, 'a');//this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void StaffFirstNameMaxPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffFirstName = StaffFirstName.PadRight(51, 'a');//this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void StaffFirstNameMid()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffFirstName = StaffFirstName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(100);
            // change the date to whatever the date is less 100 years 
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(1);
            // change the date to whatever the date is less 100 years 
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-16);
            // change the date to whatever the date is less 100 years 
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-17);
            // change the date to whatever the date is less 100 years 
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-116);
            // change the date to whatever the date is less 100 years 
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //set the DateOfBirth to a non date value 
            string DateOfBirth = "this is not a date!";
            //invoke method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffLastNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        public void StaffFLastNameMin()

        { 

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void StaffLastNameMinPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

                
        [TestMethod]

        public void StaffLastNameMaxLessOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffLastName = StaffLastName.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        

        public void StaffLastNameMax()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffLastName = StaffLastName.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
      

        public void StaffLastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StaffLastName = StaffLastName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMinLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        public void PostCodeMin()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        public void PostCodeMinPlusOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PostCodeMaxLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        public void PostCodeMax()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PostCodeMaxPlusOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PostCodeMid()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Gender = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        public void GenderMin()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "aaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void GenderMinPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void GenderMaxLessOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Gender = Gender.PadRight(5, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void GenderNameMax()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Gender = Gender.PadRight(6, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void GenderNameMaxPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Gender = Gender.PadRight(7, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void GenderMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        public void AddressMin()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void AddressMinPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        public void AddressMaxLessOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Address = Address.PadRight(5, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        public void AddressMax()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Address = Address.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void AddressMaxPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Address = Address.PadRight(51, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void AddressMid()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Address = Address.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NINoMinLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string NINo = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        public void NINoMin()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NINo = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void NINoMinPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void NINoMaxLessOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            NINo = NINo.PadRight(8, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void NINoMax()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            NINo = NINo.PadRight(9, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void NINoMaxPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            NINo = NINo.PadRight(10, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void NINoMid()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            NINo = NINo.PadRight(4, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNoMinLessOne()

        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNo = "";
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        public void PhoneNoMin()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PhoneNoMinPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PhoneNoMaxLessOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            PhoneNo = PhoneNo.PadRight(10, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void PhoneNoMax()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            PhoneNo = PhoneNo.PadRight(11, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        public void PhoneNoMaxPlusOne()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            PhoneNo = PhoneNo.PadRight(11, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        public void PhoneNoMid()

        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            PhoneNo = PhoneNo.PadRight(6, 'a'); //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }

}
