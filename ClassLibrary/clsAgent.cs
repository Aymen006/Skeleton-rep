using System;

namespace ClassLibrary
{
    public class clsAgent
    {
        // Private data members for each property
        private Int32 mAgentId;
        private string mAgentName;
        private string mDescr;
        private string mCategory;
        private string mIntegrationType;
        private Boolean mStatus;
        private DateTime mUpdatedAt;
        private double mPrice;
        private Int32 mEmployeeId;

        // Public property for Description that was in your original working code
        public string Description { get; set; }

        // Additional properties for the other test cases
        public Int32 AgentId
        {
            get
            {
                // This line of code sends data out of the property
                return mAgentId;
            }
            set
            {
                // This line of code allows data into the property
                mAgentId = value;
            }
        }

        public string AgentName
        {
            get
            {
                // This line of code sends data out of the property
                return mAgentName;
            }
            set
            {
                // This line of code allows data into the property
                mAgentName = value;
            }
        }

        public string Descr
        {
            get
            {
                // This line of code sends data out of the property
                return mDescr;
            }
            set
            {
                // This line of code allows data into the property
                mDescr = value;
            }
        }

        public string Category
        {
            get
            {
                // This line of code sends data out of the property
                return mCategory;
            }
            set
            {
                // This line of code allows data into the property
                mCategory = value;
            }
        }

        public string IntegrationType
        {
            get
            {
                // This line of code sends data out of the property
                return mIntegrationType;
            }
            set
            {
                // This line of code allows data into the property
                mIntegrationType = value;
            }
        }

        public Boolean Status
        {
            get
            {
                // This line of code sends data out of the property
                return mStatus;
            }
            set
            {
                // This line of code allows data into the property
                mStatus = value;
            }
        }

        public DateTime UpdatedAt
        {
            get
            {
                // This line of code sends data out of the property
                return mUpdatedAt;
            }
            set
            {
                // This line of code allows data into the property
                mUpdatedAt = value;
            }
        }

        public double Price
        {
            get
            {
                // This line of code sends data out of the property
                return mPrice;
            }
            set
            {
                // This line of code allows data into the property
                mPrice = value;
            }
        }

        public Int32 EmployeeId
        {
            get
            {
                // This line of code sends data out of the property
                return mEmployeeId;
            }
            set
            {
                // This line of code allows data into the property
                mEmployeeId = value;
            }
        }

        // Your original validation method that was working
        public string Valid(string nDescription)
        {
            if (nDescription.Length < 1)
            {
                return "Description cannot be blank";
            }
            if (nDescription.Length > 50)
            {
                return " Description cannot be more than 50 char";
            }
            else
            {
                return "";
            }
        }

        // Enhanced Find method for all the tests
        public Boolean Find(int AgentId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AgentId", AgentId);
            DB.Execute("sproc_tblAgent_FilterByAgentId");

            // For testing purposes, we'll populate with test data
            if (DB.Count == 1)
            {
                // Hard-coded values for AgentId = 1 based on your database screenshot
                mAgentId = Convert.ToInt32(DB.DataTable.Rows[0]["AgentId"]);
                mAgentName = Convert.ToString(DB.DataTable.Rows[0]["AgentName"]);
                mDescr = Convert.ToString(DB.DataTable.Rows[0]["Descr"]); // Also set the auto-property
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mIntegrationType = Convert.ToString(DB.DataTable.Rows[0]["IntegrationType"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                mUpdatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["UpdatedAt"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mEmployeeId = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeId"]);
                return true;
            }
            else
            {
                // No record found
                return false;
            }
        }
    }
}