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
            DB.Execute("sproc_tblAgents_FilterByAgentId");

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
        // Improved validation function for clsAgent.cs
        public string Valid(string AgentName,
                    string Descr,
                    string Category,
                    string IntegrationType,
                    string UpdatedAt)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the AgentName is Blank
            if (AgentName.Length == 0)
            {
                //record the error
                Error = Error + "The Agent Name may not be blank : ";
            }

            //if the AgentName is too long
            if (AgentName.Length > 50)
            {
                //record the error
                Error = Error + "The Agent Name must be 50 characters or less : ";
            }

            //if the Description is blank
            if (Descr.Length == 0)
            {
                //record the error
                Error = Error + "The Description may not be blank : ";
            }

            // Note: We do not check for maximum length of Descr since it's defined as varchar(MAX) in the database
            // If you want to enforce a maximum length, add a check here

            //if the Category is blank
            if (Category.Length == 0)
            {
                //record the error
                Error = Error + "The Category may not be blank : ";
            }

            //if the Category is too long
            if (Category.Length > 50)
            {
                //record the error
                Error = Error + "The Category must be 50 characters or less : ";
            }

            //if the IntegrationType is blank
            if (IntegrationType.Length == 0)
            {
                //record the error
                Error = Error + "The Integration Type may not be blank : ";
            }

            //if the IntegrationType is too long
            if (IntegrationType.Length > 50)
            {
                //record the error
                Error = Error + "The Integration Type must be 50 characters or less : ";
            }

            // Date validation code
            try
            {
                //copy the UpdatedAt value to the DateTemp variable
                DateTemp = Convert.ToDateTime(UpdatedAt);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            // return any error message
            return Error;
        }

        public void Find(object agentId)
        {
            throw new NotImplementedException();
        }
    }
}
