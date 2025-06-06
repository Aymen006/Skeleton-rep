using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsTestingCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();  
        clsCustomer mThisCustomer = new clsCustomer();

        public clsTestingCustomerCollection()
        {
            int Index = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer customer = new clsCustomer();

                customer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                customer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                customer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                customer.SubsicriptionId = Convert.ToString(DB.DataTable.Rows[Index]["SubsicriptionId"]);
                customer.PaymentStatus = Convert.ToString(DB.DataTable.Rows[Index]["PaymentStatus"]);
                customer.CreatedAt = Convert.ToString(DB.DataTable.Rows[Index]["CreatedAt"]);

                mCustomerList.Add(customer);

                Index++;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }

        public int Count
        {
            get { return mCustomerList.Count; }
            set { }
        }

        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@SubsicriptionId", mThisCustomer.SubsicriptionId);
            DB.AddParameter("@PaymentStatus", mThisCustomer.PaymentStatus);
            DB.AddParameter("@CreatedAt", mThisCustomer.CreatedAt);

            return DB.Execute("sproc_tblCustomer_Insert");

         
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@SubsicriptionId", mThisCustomer.SubsicriptionId);
            DB.AddParameter("@PaymentStatus", mThisCustomer.PaymentStatus);
            DB.AddParameter("@CreatedAt", mThisCustomer.CreatedAt);

            DB.Execute("sproc_tblCustomer_Update");


            
        }
    }
}
