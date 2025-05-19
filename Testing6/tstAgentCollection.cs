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
    }
}