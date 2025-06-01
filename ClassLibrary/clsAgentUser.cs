using System;

namespace ClassLibrary
{
    public class clsAgentUser
    {
        // Private data members
        private int mUserId;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserId
        {
            get
            {
                //return the private data
                return mUserId;
            }
            set
            {
                //set the private data
                mUserId = value;
            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);

            DB.Execute("sproc_tblUsers_FindUserNamePW");

            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
