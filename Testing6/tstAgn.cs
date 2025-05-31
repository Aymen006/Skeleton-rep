using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace TestingApp
{
    [TestClass]
    public class clsAgentTests
    {
        // Good test data - moved from tstAgent to clsAgentTests
        private string AgentName = "Connecting";
        private string Descr = "Helping";
        private string Category = "Support";
        private string IntegrationType = "Local";
        private string UpdatedAt = DateTime.Now.ToShortDateString();

        // Test for instance creation
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            //TEST TO SEE that is exists
            Assert.IsNotNull(AnAgent);
        }

        // Test for Find method
        [TestMethod]
        public void FindMethodOk()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Assert the result
            Assert.IsTrue(Found);
        }

        // Test for AgentId property
        [TestMethod]
        public void TestAgentIdFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the AgentId property
            if (AnAgent.AgentId != 8)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for AgentName property
        [TestMethod]
        public void TestAgentNameFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the AgentName property
            if (AnAgent.AgentName != "Connecting")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for Description property
        [TestMethod]
        public void TestDescriptionFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the Description property
            if (AnAgent.Descr != "Helping")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for Category property
        [TestMethod]
        public void TestCategoryFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the Category property
            if (AnAgent.Category != "Support")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for IntegrationType property
        [TestMethod]
        public void TestIntegrationTypeFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the IntegrationType property
            if (AnAgent.IntegrationType != "Local")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for Status property
        [TestMethod]
        public void TestStatusFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the Status property
            if (AnAgent.Status != true)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for UpdatedAt property
        [TestMethod]
        public void TestUpdatedAtFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the UpdatedAt property
            DateTime TestDate = Convert.ToDateTime("13/05/2025");
            if (AnAgent.UpdatedAt != TestDate)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for Price property
        [TestMethod]
        public void TestPriceFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the Price property
            if (AnAgent.Price != 200.000)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for EmployeeId property
        [TestMethod]
        public void TestEmployeeIdFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data
            Int32 AgentId = 8;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the EmployeeId property
            if (AnAgent.EmployeeId != 7)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // Test for record not found
        [TestMethod]
        public void TestRecordNotFound()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // Boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Test data - using a record that doesn't exist
            Int32 AgentId = 9999;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Test to see that the result is correct
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ValidMethodeOK()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";

            //invoke the methode
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            //test to see that the resault is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameMinLessOne()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            //create some test data to pass to the methode 
            string AgentName = "";
            //invoke the methode
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            //test to see that the resault is correct
            Assert.AreNotEqual(Error, "");
        }


        // AGENT NAME TESTS

        [TestMethod]
        public void AgentNameMin()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string AgentName = "a";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType,UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string AgentName = "aa";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType,UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string AgentName = "";
            AgentName = AgentName.PadRight(49, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameMax()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string AgentName = "";
            AgentName = AgentName.PadRight(50, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameMid()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string AgentName = "";
            AgentName = AgentName.PadRight(25, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string AgentName = "";
            AgentName = AgentName.PadRight(51, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AgentNameExtremeMax()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string AgentName = "";
            AgentName = AgentName.PadRight(500, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        // DATE TESTS

        [TestMethod]
        public void UpdatedAtExtremeMin()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            // Convert the date variable to a string variable
            string UpdatedAt = TestDate.ToString();
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UpdatedAtMinLessOne()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            // Convert the date variable to a string variable
            string UpdatedAt = TestDate.ToString();
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UpdatedAtMin()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Convert the date variable to a string variable
            string UpdatedAt = TestDate.ToString();
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UpdatedAtMinPlusOne()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            // Convert the date variable to a string variable
            string UpdatedAt = TestDate.ToString();
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UpdatedAtExtremeMax()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            // Convert the date variable to a string variable
            string UpdatedAt = TestDate.ToString();
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UpdatedAtInvalidData()
        {
            // Create an instance of the class
            clsAgent AnAgent = new clsAgent();
            // string variable to store any error message
            string Error = "";
            // Set the UpdatedAt to a non-date value
            string UpdatedAt = "this is not a date!";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // INTEGRATION TYPE TESTS

        [TestMethod]
        public void IntegrationTypeMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string IntegrationType = "";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IntegrationTypeMin()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string IntegrationType = "a";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IntegrationTypeMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string IntegrationType = "";
            IntegrationType = IntegrationType.PadRight(49, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IntegrationTypeMax()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string IntegrationType = "";
            IntegrationType = IntegrationType.PadRight(50, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType,UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IntegrationTypeMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string IntegrationType = "";
            IntegrationType = IntegrationType.PadRight(51, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IntegrationTypeExtremeMax()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string IntegrationType = "";
            IntegrationType = IntegrationType.PadRight(500, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        // DESCRIPTION TESTS

        [TestMethod]
        public void DescrMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Descr = "";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescrMin()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Descr = "a";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescrMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Descr = "aa";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescrMid()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Descr = "";
            Descr = Descr.PadRight(4000, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescrMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Descr = "";
            Descr = Descr.PadRight(7999, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescrMax()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass - using a large value for MAX
            string Descr = "";
            Descr = Descr.PadRight(8000, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescrMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail if we implement a maximum length validation
            string Descr = "";
            Descr = Descr.PadRight(8001, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Since we're not enforcing a specific maximum for varchar(MAX), this should pass
            // If you want to enforce a maximum length, change to Assert.AreNotEqual()
            Assert.AreEqual(Error, "");
        }

        // CATEGORY TESTS

        [TestMethod]
        public void CategoryMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Category = "";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMin()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Category = "a";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Category = "aa";
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Category = "";
            Category = Category.PadRight(25, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Category = "";
            Category = Category.PadRight(49, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Category = "";
            Category = Category.PadRight(50, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAgent AnAgent = new clsAgent();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Category = "";
            Category = Category.PadRight(51, 'a');
            // Invoke the method
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
