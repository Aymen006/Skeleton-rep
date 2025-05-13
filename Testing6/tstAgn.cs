using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// using System.Security.Cryptography; // This using is not currently used by this code. Can be kept or removed.

namespace TestingApp
{
    // This class defines test data but isn't directly used by ValidMethodeOK in clsAgentTests in this corrected version.
    // It could be used by other tests or if ValidMethodeOK were part of this class.
    [TestClass]
    public class tstAgent
    {
        //good test data
        //create some test data to pass the methode
        string AgentName = "Connecting";
        string Descr = "Helping";
        string Category = "Support";
        string IntegrationType = "Local";
        string UpdatedAt = DateTime.Now.ToShortDateString();
    }

    [TestClass]
    public class clsAgentTests
    {
        // --- Copied test data fields here to be accessible by ValidMethodeOK ---
        // good test data
        // create some test data to pass the methode
        string AgentName = "Connecting";
        string Descr = "Helping";
        string Category = "Support";
        string IntegrationType = "Local";
        string UpdatedAt = DateTime.Now.ToShortDateString();
        // --- End of copied test data fields ---

        // Test for Find method
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
            if (AnAgent.Descr != "Helping") // Assuming Descr is the property in clsAgent
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
            DateTime TestDate = Convert.ToDateTime("13/05/2025"); // Ensure your Find method returns this for AgentId 8
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
            // For floating point comparisons, it's better to check within a tolerance
            if (Math.Abs(AnAgent.Price - 200.000) > 0.0001)
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
            // Now AgentName, Descr, etc. are accessible as they are fields of this clsAgentTests class
            Error = AnAgent.Valid(AgentName, Descr, Category, IntegrationType, UpdatedAt);
            //test to see that the resault is correct
            Assert.AreEqual(Error, "");
        }
    }
}