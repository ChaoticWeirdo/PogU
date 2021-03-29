using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it eists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in thi case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.ProductId = "23f";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Description = "Description";
            TestItem.Price = 9.99;
            TestItem.Paid = true;
            TestItem.Status = "Shipped";
            TestItem.DateShipped = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrders TestOrder = new clsOrders();
            //set the properties of the object
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.ProductId = "23f";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.Description = "Description";
            TestOrder.Price = 9.99;
            TestOrder.Paid = true;
            TestOrder.Status = "Shipped";
            TestOrder.DateShipped = DateTime.Now.Date;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we wat to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.ProductId = "23f";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Description = "Description";
            TestItem.Price = 9.99;
            TestItem.Paid = true;
            TestItem.Status = "Shipped";
            TestItem.DateShipped = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the daa to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
