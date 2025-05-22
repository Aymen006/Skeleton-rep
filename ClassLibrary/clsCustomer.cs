using System;


namespace ClassLibrary
{

    public class clsCustomer
    {
        private Int32 mCustomerId;
        private string mCustomerName;
        private string mCustomerEmail;
        private string mSubsicriptionId;
        private string mPaymentStatus;
        private DateTime mCreatedAt;


        public Int32 CustomerId
        {
            get
            {
                
                return mCustomerId;
            }
            set
            {
                
                mCustomerId = value;
            }
        }

        public string CustomerName
        {
            get
            {
                
                return mCustomerName;
            }
            set
            {
                
                mCustomerName = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                
                return mCustomerEmail;
            }
            set
            {
                
                mCustomerEmail = value;
            }
        }

        public String SubsicriptionId
        {
            get
            {
                // This line of code sends data out of the property
                return mSubsicriptionId;
            }
            set
            {
                // This line of code allows data into the property
                mSubsicriptionId = value;
            }
        }

        public string PaymentStatus
        {
            get
            {
                // This line of code sends data out of the property
                return mPaymentStatus;
            }
            set
            {
                // This line of code allows data into the property
                mPaymentStatus = value;
            }
        }
        public DateTime CreatedAt
        {
            get
            {
                // This line of code sends data out of the property
                return mCreatedAt;
            }
            set
            {
                // This line of code allows data into the property
                mCreatedAt = value;
            }
        }
    }
}
