using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstAgentUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAgentUser AnUser = new clsAgentUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }


        [TestMethod]
        public void UserIdPropertyOK()
        {
            //CREATE an instance of the class we want to create
            clsAgentUser AnUser = new clsAgentUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAgentUser AnUser = new clsAgentUser();
            //create some test data to assign to the property
            string TestData = "Eymene";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsAgentUser AnUser = new clsAgentUser();
            //create some test data to assign to the property
            string TestData = "hey123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAgentUser AnUser = new clsAgentUser();
            //create some test data to assign to the property
            string TestData = "Admin";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodeOK()
        {
            clsAgentUser AnUser = new clsAgentUser();
            Boolean Found = false;
            string UserName = "Eymene";
            string Password = "hey123";
            Found = AnUser.FindUser(UserName, Password);
  
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNameFoundPWFound()
        {
            // Create an instance of the class we want to test
            clsAgentUser AnUser = new clsAgentUser();

            // Boolean variable to store the result of the search
            Boolean Found = false;
            Boolean OK = true;

            // Test username and password — must match a real record in your tblUsers
            string UserName = "Eymene";
            string Password = "hey123";

            
            Found = AnUser.FindUser(UserName, Password);

            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
