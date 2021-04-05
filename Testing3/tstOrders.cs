using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {

        //good test data
        //create some test data to pass to the method
        string CustomerId = "2";
        string ProductId = "24d";
        string OrderDate = DateTime.Now.Date.ToString();
        string Description = "Description 2";
        string Price = "18.98";
        string Status = "Quality Control";
        string DateShipped = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);


        }

        [TestMethod]
        public void CustomerIdPropertOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two c=values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);

        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "1a";
            //assign the data to the property
            AnOrder.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductId, TestData);

        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);

        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "test";
            //assign the data to the property
            AnOrder.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Description, TestData);

        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            double TestData = 9.9;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two vaules are the same
            Assert.AreEqual(AnOrder.Price, TestData);

        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "Test";
            //asign the data to the property
            AnOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Status, TestData);

        }

        [TestMethod]
        public void DateShippedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateShipped = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateShipped, TestData);

        }

        [TestMethod]
        public void PaidPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Paid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Paid, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to be recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the OrderId
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to be recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the CustomerId
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to be recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.ProductId != "23f")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to be recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("10/03/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.Description != "Description")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.Price != 9.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaidFound()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.Paid != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.Status != "Dispatched")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateShippedFound()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean cariable to store the result of the search
            Boolean Found = false;
            //boolean variable recorded if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.DateShipped != Convert.ToDateTime("14/03/2021"))
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
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            string CustomerId = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "aaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "aaaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "aaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "aaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerId = "";
            CustomerId = CustomerId.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMinLessOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMin()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMinPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMaxLessOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "aaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMax()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "aaaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMid()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "aaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMaxPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "aaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdExtremeMax()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductId = "";
            ProductId = ProductId.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convery the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string varaible to store any error message
            String Error = "";
            //create a variable to store the te3st date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //cahgne the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the OrderDare to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        */

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(24, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(12, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(26, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //create an instance of the cloass we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "10.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "100.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1000.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "10000.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            Price = Price.PadRight(500, '.');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Status = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMin()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Status = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Status = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Status = "";
            Status = Status.PadRight(14, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMax()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Status = "";
            Status = Status.PadRight(15, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Status = "";
            Status = Status.PadRight(7, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //creaete some test data to pass to the method
            string Status = "";
            Status = Status.PadRight(16, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusExtrmeMax()
        {
            //create an instance of the class that we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Status = "";
            Status = Status.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
        [TestMethod]
        public void DateShippedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convery the date variable to a string variable
            string DateShipped = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateShippedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateShipped = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateShippedMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateShipped = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateShippedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string varaible to store any error message
            String Error = "";
            //create a variable to store the te3st date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateShipped = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateShippedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //cahgne the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateShipped = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateShippedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the OrderDare to a non date value
            string DateShipped = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        */

    }
}
