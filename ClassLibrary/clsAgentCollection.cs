using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAgentCollection
    {
        //private data member for the list
        List<clsAgent> mAgentList = new List<clsAgent>();
        //private data member for ThisAgent
        clsAgent mThisAgent = new clsAgent();

        //constructor for the class
        public clsAgentCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAgents_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mAgentList = new List<clsAgent>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank agent
                clsAgent AnAgent = new clsAgent();
                //read in the fields from the current record
                AnAgent.AgentId = Convert.ToInt32(DB.DataTable.Rows[Index]["AgentId"]);
                AnAgent.AgentName = Convert.ToString(DB.DataTable.Rows[Index]["AgentName"]);
                AnAgent.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AnAgent.IntegrationType = Convert.ToString(DB.DataTable.Rows[Index]["IntegrationType"]);
                AnAgent.Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Status"]);
                AnAgent.UpdatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["UpdatedAt"]);
                //add the record to the private data member
                mAgentList.Add(AnAgent);
                //point at the next record
                Index++;
            }

        }



        //public property for AgentList
        public List<clsAgent> AgentList
        {
            get
            {
                //return the private data
                return mAgentList;
            }
            set
            {
                //set the private data
                mAgentList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAgentList.Count;
            }
            set
            {
                //we'll implement this later
            }
        }

        //public property for ThisAgent
        public clsAgent ThisAgent
        {
            get
            {
                //return the private data
                return mThisAgent;
            }
            set
            {
                //set the private data
                mThisAgent = value;
            }
        }

        public int Add()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add parameters for the stored procedure
            DB.AddParameter("@AgentName", mThisAgent.AgentName);
            DB.AddParameter("@Descr", mThisAgent.Descr);
            DB.AddParameter("@Category", mThisAgent.Category);
            DB.AddParameter("@IntegrationType", mThisAgent.IntegrationType);
            DB.AddParameter("@Status", mThisAgent.Status);
            DB.AddParameter("@UpdatedAt", mThisAgent.UpdatedAt);
            DB.AddParameter("@Price", mThisAgent.Price);
            DB.AddParameter("@EmployeeId", mThisAgent.EmployeeId);

            // Execute the stored procedure and return the primary key
            return DB.Execute("dbo.sproc_tblAgents_Insert");
        }

        public void Update()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add parameters including the primary key
            DB.AddParameter("@AgentId", mThisAgent.AgentId);
            DB.AddParameter("@AgentName", mThisAgent.AgentName);
            DB.AddParameter("@Descr", mThisAgent.Descr);
            DB.AddParameter("@Category", mThisAgent.Category);
            DB.AddParameter("@IntegrationType", mThisAgent.IntegrationType);
            DB.AddParameter("@Status", mThisAgent.Status);
            DB.AddParameter("@UpdatedAt", mThisAgent.UpdatedAt);
            DB.AddParameter("@Price", mThisAgent.Price);
            DB.AddParameter("@EmployeeId", mThisAgent.EmployeeId);

            // Execute the stored procedure
            DB.Execute("dbo.sproc_tblAgents_Update");
        }

        public void Delete()
        {
            //CONNECT TO THE DATABASE
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@AgentId", mThisAgent.AgentId);
            // Execute the stored procedure
            DB.Execute("dbo.sproc_tblAgents_Delete");
        }

        public void ReportByCategory(string Category)
        {
            //filters the record based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Category", Category);
            DB.Execute("sproc_tblAgents_FilterByCategory");
            PopulateArray(DB);

        }
    }
}
