using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class TestingCustomer
    {
        [TestMethod]
        public void CustomerId_Property_Check()
        {
            clsCustomer ACusID = new clsCustomer();
            Int32 TestData = 1;
            ACusID.CustomerId = TestData;
            Assert.AreEqual(ACusID.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerName_Property_Check()
        {

            clsCustomer Customer = new clsCustomer();
            String TestData = "Josh";
            Customer.CustomerName = TestData;
            Assert.AreEqual(Customer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmail_Property_Check()
        {
            clsCustomer Email = new clsCustomer();
            string TestData = "rehman@dmu.com";
            Email.CustomerEmail = TestData;
            Assert.AreEqual(Email.CustomerEmail, TestData); 
        }

        [TestMethod]
        public void SubsicriptionId_Property_Check()
        {
            clsCustomer SubId = new clsCustomer();
            String TestData = "427";
            SubId.SubsicriptionId = TestData;
            Assert.AreEqual(SubId.SubsicriptionId, TestData);
        }

        [TestMethod]
        public void PaymentStatus_Property_Check()
        {

            clsCustomer Pay = new clsCustomer();
            String TestData = "Paid";
            Pay.PaymentStatus = TestData;
            Assert.AreEqual(Pay.PaymentStatus, TestData);
        }

        [TestMethod]
        public void Date_Property_Check()
        {

            clsCustomer DateCreated = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            DateCreated.CreatedAt = TestData;
            Assert.AreEqual(DateCreated.CreatedAt, TestData);
        }

    }
}
