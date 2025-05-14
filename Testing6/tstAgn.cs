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
    }
}