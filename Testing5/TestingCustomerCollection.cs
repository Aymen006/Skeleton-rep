using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testing5
{
    [TestClass]
    public class TestingCustomerCollection
    {

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsTestingCustomerCollection AllCustomers = new clsTestingCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 123;
            TestItem.CustomerName = "Messi";
            TestItem.CustomerEmail = "messi@dmu.com";
            TestItem.SubsicriptionId = "A380";
            TestItem.PaymentStatus = "Paid";
            TestItem.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd");

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerId = PrimaryKey;

            TestItem.CustomerId = 321;
            TestItem.CustomerName = "Ronaldo";
            TestItem.CustomerEmail = "ronaldo@dmu.com";
            TestItem.SubsicriptionId = "A330";
            TestItem.PaymentStatus = "NotPaid";
            TestItem.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd");

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);



        }










        [TestMethod]

        public void AddMethodOK()
        {

            clsTestingCustomerCollection AllCustomers = new clsTestingCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Ben";
            TestItem.CustomerEmail = "ben@dmu.com";
            TestItem.SubsicriptionId = "A420";
            TestItem.PaymentStatus = "Due";
            TestItem.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd");

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        [TestMethod]
        public void InstanceOK()
        {
            clsTestingCustomerCollection AllCustomer = new clsTestingCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]

        public void CustomerListOK()
        {
            clsTestingCustomerCollection AllCustomer = new clsTestingCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

           
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Adam";
            TestItem.CustomerEmail = "adam@dmu.com";
            TestItem.SubsicriptionId = "AS426";
            TestItem.PaymentStatus = "Paid";
            TestItem.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd");

            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);

        }
        

        [TestMethod]

        public void ThisCustomerPropertyOK()
        {
            clsTestingCustomerCollection AllCustomer = new clsTestingCustomerCollection();
          
            clsCustomer TestCustomer = new clsCustomer();


            TestCustomer.CustomerId = 1;    
            TestCustomer.CustomerName = "Adam";
            TestCustomer.CustomerEmail = "adam@dmu.com";
            TestCustomer.SubsicriptionId = "AS426";
            TestCustomer.PaymentStatus = "Paid";
            TestCustomer.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd");

           
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);

        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsTestingCustomerCollection AllCustomer = new clsTestingCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Adam";
            TestItem.CustomerEmail = "adam@dmu.com";
            TestItem.SubsicriptionId = "AS426";
            TestItem.PaymentStatus = "Paid";
            TestItem.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd");

            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);

        }

        


    }
}
