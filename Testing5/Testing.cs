using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5

public class Testing

    {TestClass}

{
        [TestMethod]
        public void CustomerId_Property_Check()
        {
            clsCustomerId ACusID = new clsCustomerId();
            Int32 TestData = 1;
            ACusID.CustomerId = TestData;
            Assert.AreEqual(ACusID.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerName_Property_Check()
        {

            clsCustomerName Customer = new clsCustomerName();
           String TestData = "Josh";
            Customer.CustomerName = TestData;
            Assert.AreEqual(Customer.CustomerName, TestData);
        }

        [TestMethod]

        public void CustomerEmail_Property_Check();
        {
            clsCustomerEmail Email = new clsCustomerEmail();
        string TestData = "rehman@dmu.com";
        Email.CustomerEmail = TestData;
            Assert.AreEqual(CustomerEmail.Email, TestData);


        }

     [TestMethod]
        public void SubsicriptionId_Property_Check()
        {
            clsSubsicriptionId SubId = new clsSubsicriptionId();
            Int32 TestData = 627;
            SubId.SubsicriptionId = TestData;
            Assert.AreEqual(SubId.SubsicriptionId, TestData);
        }

        [TestMethod]
        public void PaymentStatus_Property_Check()
        {

            clsPaymentStatus Pay = new clsPaymentStatus();
            String TestData = "Paid";
            Pay.PaymentStatus = TestData;
            Assert.AreEqual(Pay.PaymentStatus, TestData);
        }

        [TestMethod]
        public void Date_Property_Check()
        {

            clsCreatedAt DateCreated = new clsCreatedAt();
            DateTime TestData = DateTime.Now.Date;
            DateCreated.CreatedAt = TestData;
            Assert.AreEqual(DateCreated.CreatedAt, TestData);
        }








    }
}
