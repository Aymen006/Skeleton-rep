using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstAgentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAgents);
        }

        [TestMethod]
        public void AgentListOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //create some test data to assign to the property
            List<clsAgent> TestList = new List<clsAgent>();
            //create an item of test data
            clsAgent TestItem = new clsAgent();
            //set its properties
            TestItem.AgentId = 1;
            TestItem.AgentName = "Agent Smith";
            TestItem.Category = "Sales";
            TestItem.IntegrationType = "Full";
            TestItem.Status = true;
            TestItem.UpdatedAt = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAgents.AgentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAgents.AgentList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //create some test data to assign to the property
            Int32 SomeCount = AllAgents.Count; // Use the actual count
            //test to see that the count is not zero
            Assert.IsTrue(SomeCount > 0);
        }

        [TestMethod]
        public void ThisAgentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //create some test data to assign to the property
            clsAgent TestAgent = new clsAgent();
            //set the properties of the test object
            TestAgent.AgentId = 1;
            TestAgent.AgentName = "Agent Smith";
            TestAgent.Category = "Sales";
            TestAgent.IntegrationType = "Full";
            TestAgent.Status = true;
            TestAgent.UpdatedAt = DateTime.Now;
            //assign the data to the property
            AllAgents.ThisAgent = TestAgent;
            //test to see that the two values are the same
            Assert.AreEqual(AllAgents.ThisAgent, TestAgent);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //create some test data to assign to the property
            List<clsAgent> TestList = new List<clsAgent>();
            //create an item of test data
            clsAgent TestItem = new clsAgent();
            //set its properties
            TestItem.AgentId = 1;
            TestItem.AgentName = "Agent Smith";
            TestItem.Category = "Sales";
            TestItem.IntegrationType = "Full";
            TestItem.Status = true;
            TestItem.UpdatedAt = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAgents.AgentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAgents.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the collection
            clsAgentCollection AllAgents = new clsAgentCollection();
            // Create the test item
            clsAgent TestItem = new clsAgent();

            // Set test data
            TestItem.AgentName = "Test Agent";
            TestItem.Descr = "Test Description";
            TestItem.Category = "Insurance";
            TestItem.IntegrationType = "API";
            TestItem.Status = true;
            TestItem.UpdatedAt = DateTime.Now.Date;
            TestItem.Price = 1500;
            TestItem.EmployeeId = 1;

            // Assign to ThisAgent
            AllAgents.ThisAgent = TestItem;

            // Add the record and capture primary key
            int PrimaryKey = AllAgents.Add();
            TestItem.AgentId = PrimaryKey;

            // Find the record
            AllAgents.ThisAgent.Find(PrimaryKey);

            // Assert each field
            Assert.AreEqual(AllAgents.ThisAgent.AgentId, TestItem.AgentId);
            Assert.AreEqual(AllAgents.ThisAgent.AgentName, TestItem.AgentName);
            Assert.AreEqual(AllAgents.ThisAgent.Descr, TestItem.Descr);
            Assert.AreEqual(AllAgents.ThisAgent.Category, TestItem.Category);
            Assert.AreEqual(AllAgents.ThisAgent.IntegrationType, TestItem.IntegrationType);
            Assert.AreEqual(AllAgents.ThisAgent.Status, TestItem.Status);
            Assert.AreEqual(AllAgents.ThisAgent.UpdatedAt, TestItem.UpdatedAt);
            Assert.AreEqual(AllAgents.ThisAgent.Price, TestItem.Price);
            Assert.AreEqual(AllAgents.ThisAgent.EmployeeId, TestItem.EmployeeId);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create the collection and test data
            clsAgentCollection AllAgents = new clsAgentCollection();
            clsAgent TestItem = new clsAgent();
            //variable to store the primary key
            Int32 PrimaryKey = 17;
            // Fill with initial test data
            TestItem.AgentName = "Initial Name";
            TestItem.Descr = "Initial Desc";
            TestItem.Category = "Initial";
            TestItem.IntegrationType = "None";
            TestItem.Status = true;
            TestItem.UpdatedAt = DateTime.Now.Date;
            TestItem.Price = 10;

            // Add record and get PK
            AllAgents.ThisAgent = TestItem;
            PrimaryKey = AllAgents.Add();
            TestItem.AgentId = PrimaryKey;

            // Modify test data
            TestItem.AgentName = "Updated Name";
            TestItem.Descr = "Updated Desc";
            TestItem.Category = "Updated";
            TestItem.IntegrationType = "API";
            TestItem.Status = false;
            TestItem.UpdatedAt = DateTime.Now.Date;
            TestItem.Price = 50;

            // Update
            AllAgents.ThisAgent = TestItem;
            AllAgents.Update();

            // Retrieve and verify
            AllAgents.ThisAgent.Find(PrimaryKey);
            Assert.AreEqual(AllAgents.ThisAgent, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //create the item of test data
            clsAgent TestItem = new clsAgent();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AgentId = 1; // This will be set by the database
            TestItem.AgentName = "Delete Me";
            TestItem.Descr = "To be deleted";
            TestItem.Category = "Test";
            TestItem.IntegrationType = "API";
            TestItem.Status = true;
            TestItem.UpdatedAt = DateTime.Now.Date;
            TestItem.Price = 5;
            TestItem.EmployeeId = 3;

            //set ThisAgent to the test data
            AllAgents.ThisAgent = TestItem;
            //add the record
            PrimaryKey = AllAgents.Add();
            //set the primary key of the test data
            TestItem.AgentId = PrimaryKey;
            //find the record
            AllAgents.ThisAgent.Find(PrimaryKey);
            //delete the record
            AllAgents.Delete();
            //now try to find the record
            Boolean Found = AllAgents.ThisAgent.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCategoryMethodOK()
        {
            //create an instance of the class we want to create
            clsAgentCollection AllAgents = new clsAgentCollection();
            //create the instance of the filter
            clsAgentCollection FilteredAgents = new clsAgentCollection();
            //create the filter to test
            FilteredAgents.ReportByCategory("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAgents.Count, FilteredAgents.Count);
        }

        [TestMethod]
        public void ReportByCategoryMethodNotFound()
        {
            //create an instance of the class we want to create
            clsAgentCollection FilteredAgents = new clsAgentCollection();
            //create the filter to test
            FilteredAgents.ReportByCategory("hola");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredAgents.Count);
        }

        [TestMethod]
        public void ReportByCategoryTestDataFound()
        {
            //create an instance of the class we want to create
            clsAgentCollection FilteredAgents = new clsAgentCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a category that doesn't exist
            FilteredAgents.ReportByCategory("report");
            //check that the correct number of records are found
            if(FilteredAgents.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredAgents.AgentList[0].AgentId != 37)
                {
                    OK = false;
                }
                //check that the second record is ID 2
                if (FilteredAgents.AgentList[1].AgentId != 38)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the outcome is correct
            Assert.IsTrue(OK);

        }

    }
}
