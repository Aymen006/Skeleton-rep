using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingApp
{
    [TestClass]
    public class clsAgentTests
    {
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
            Int32 AgentId = 1;
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the AgentId property
            if (AnAgent.AgentId != 1)
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the AgentName property
            if (AnAgent.AgentName != "Marketing Agent")
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the Description property
            if (AnAgent.Description != "agent that is responsible for the marketing")
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the Category property
            if (AnAgent.Category != "Business")
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the IntegrationType property
            if (AnAgent.IntegrationType != "API")
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
            Int32 AgentId = 1;
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the UpdatedAt property
            DateTime TestDate = Convert.ToDateTime("08/05/2023");
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
            Int32 AgentId = 1;
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
            Int32 AgentId = 1;
            // Invoke the method
            Found = AnAgent.Find(AgentId);
            // Check the EmployeeId property
            if (AnAgent.EmployeeId != 16)
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
    }
}

