using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
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
    }
}
