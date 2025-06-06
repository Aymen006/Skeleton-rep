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

       

        Int32 CustomerId = '5';
        string CustomerName = "Josh";
        string CustomerEmail = "josh@dmu.com";
            string SubsicriptionId = "A246";
        string PaymentStatus = "Done";
        string CreatedAt = new DateTime(1900, 1, 1).ToString("yyyy-MM-dd");




        //*******

        // CustomerId Tests

        //********



        [TestMethod]

        
        public void CustomerIdMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            Int32 CustomerId = 0;  // Intentionally invalid (less or equal to 2)

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreNotEqual(Error, "");  // Expect error, so Error should NOT be empty
        }


        [TestMethod]
        public void CustomerIdMin()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            Int32 CustomerId = 1;

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIdMinPlusOne()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            Int32 CustomerId = 12;

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIdMaxLessOne()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            Int32 CustomerId = 12345; //this should be ok

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
 
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerIdMax()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            Int32 CustomerId = 654321;

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIdMid()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            Int32 CustomerId = 321; //this should be ok

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ValidMethodOk()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }




        //*********

        // CustomerName Tests

        //**********






        [TestMethod]
        public void CustomerNameMin()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            string CustomerName = "A";

            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string CustomerName = "Aa"; // just above minimum
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaa";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaaaaaaaaaaa";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string CustomerName = "aaaaaaaaaaaaaaaaaaaa";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }






        //*************

        //CustomerEmail Tests

        //***************








        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            // Minimal valid email - 1 char before @
            string CustomerEmail = "a@example.com";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            // 2 chars before @
            string CustomerEmail = "aa@example.com";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            // 15 chars before @
            string localPart = new string('a', 15);
            string CustomerEmail = localPart + "@example.com";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            // 29 chars before @ (one less than max 30)
            string localPart = new string('a', 29);
            string CustomerEmail = localPart + "@example.com";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            // Exactly 30 chars before @ (max allowed)
            string localPart = new string('a', 30);
            string CustomerEmail = localPart + "@example.com";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }


        //****************

        //SubsicriptionId

        //*****************







        [TestMethod]
        public void SubsicriptionIdMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string SubsicriptionId = "";  // less than min length (assuming min is 1)
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubsicriptionIdMin()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string SubsicriptionId = "A";  // min length 1
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubsicriptionIdMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string SubsicriptionId = "AB";  // length 2
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubsicriptionIdMid()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string SubsicriptionId = "AAAAA";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubsicriptionIdMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string SubsicriptionId = "AAAAAAAAA";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubsicriptionIdMax()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string SubsicriptionId = "AAAAAAAAAA";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }






        //***************

        //PaymentStatus

        //***************





        [TestMethod]
        public void PaymentStatusMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string PaymentStatus = "";  // less than min length (assuming min is 1)
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentStatusMin()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string PaymentStatus = "A";  // min length 1
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentStatusMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string PaymentStatus = "AB";  // length 2
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentStatusMid()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string PaymentStatus = "AAAAAAAAAA";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentStatusMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string PaymentStatus = "AAAAAAAAAAAAAAAAAAA";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentStatusMax()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string PaymentStatus = "AAAAAAAAAAAAAAAAAAAA";
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }





        //*********

        //CreatedAt Tests

        //**********





        [TestMethod]
        public void CreatedAtMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // Assuming min valid date is 01/01/1900, so this is invalid (one day before)
            string CreatedAt = new DateTime(1899, 12, 31).ToString("yyyy-MM-dd");
            
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreNotEqual(Error, "");  // expect error
        }

        [TestMethod]
        public void CreatedAtMin()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // Min valid date boundary (e.g. 01/01/1900)
            string CreatedAt = new DateTime(1900, 1, 1).ToString("yyyy-MM-dd");
            
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");  // expect no error
        }

        [TestMethod]
        public void CreatedAtMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // Just after min date
            string CreatedAt = new DateTime(1900, 1, 2).ToString("yyyy-MM-dd");
            
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedAtMid()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // A mid-range valid date (e.g. 2000-01-01)
            string CreatedAt = new DateTime(2000, 1, 1).ToString("yyyy-MM-dd");
            
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedAtMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // Assuming max valid date is today, so one day before today is valid
            string CreatedAt = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");


            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedAtMax()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // Max valid date is today (assuming future dates are invalid)
            string CreatedAt = DateTime.Today.ToString("yyyy-MM-dd");
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedAtMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            // One day in the future - likely invalid
            string CreatedAt = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
            Error = customer.Valid(CustomerId, CustomerName, CustomerEmail, SubsicriptionId, PaymentStatus, CreatedAt);
            Assert.AreNotEqual(Error, "");  // expect error
        }









        [TestMethod]

        public void FindMethodOK()
        {
            clsCustomer customer = new clsCustomer();
                Boolean Found = false;
            Int32 CustomerId = 21;
            Found = customer.Find(CustomerId); 
            Assert.IsTrue(Found);
        }



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

           
            string TestDataString = TestData.ToString("yyyy-MM-dd");

            DateCreated.CreatedAt = TestDataString;
            Assert.AreEqual(DateCreated.CreatedAt, TestDataString);
        }


    }
}
