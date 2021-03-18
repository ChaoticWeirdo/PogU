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
    }
}
