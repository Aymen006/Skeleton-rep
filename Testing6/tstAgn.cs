using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstAgent
    {
        //good test data
        private string nDescription = " THis is the Marketing AI Agent ";

        [TestMethod]
        public void InstanceOK()
        {
            clsAgent AAGENT = new clsAgent();
            Assert.IsNotNull(AAGENT);

        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsAgent AAGENT = new clsAgent();
            string TestData = nDescription;
            AAGENT.Description = TestData;
            Assert.AreEqual(AAGENT.Description, TestData);

        }

        [TestMethod]
        public void ValidOK()
        {
            clsAgent AAGENT = new clsAgent();
            string Error = " ";
            string TestData = nDescription;
            Error = AAGENT.Valid(nDescription);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void MinLessOne()
        {
            clsAgent AAGENT = new clsAgent();
            string Error = " ";
            string TestData = "";
            Error = AAGENT.Valid(TestData);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsAgent AAGENT = new clsAgent();
            string Error = " ";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = AAGENT.Valid(TestData);
            Assert.AreNotEqual(Error, "");

        }
    }
}
