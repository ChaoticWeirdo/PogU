using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void LimitedStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.LimitedStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.LimitedStock, TestData);
        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductID, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Armani Jacket";
            //assign the data to the property
            AnStock.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductName, TestData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the property
            AnStock.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Gender, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Decimal TestData = 95.50M;
            //assign the data to the property
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.OrderDate, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Quantity, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean Variable to store the result of the search
            Boolean Found = false;
            //Bollean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //Check the Product ID
            if (AnStock.ProductID != 25)
            {
                OK = false;
            }
            //test to see that the result are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean Variable to store the result of the search
            Boolean Found = false;
            //Bollean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //Check the Product date
            if (AnStock.OrderDate != Convert.ToDateTime("27/03/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean Variable to store the result of the search
            Boolean Found = false;
            //Bollean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //Check the Product name
            if (AnStock.ProductName != "Boden Det Jacket")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean Variable to store the result of the search
            Boolean Found = false;
            //Bollean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //Check the Product name
            if (AnStock.Gender != "Female")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean Variable to store the result of the search
            Boolean Found = false;
            //Bollean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //Check the Product name
            if (AnStock.Price != 98.00m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean Variable to store the result of the search
            Boolean Found = false;
            //Bollean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //Check the Product name
            if (AnStock.Quantity != 23)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLimitedStockFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 25;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the property
            if (AnStock.LimitedStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}

