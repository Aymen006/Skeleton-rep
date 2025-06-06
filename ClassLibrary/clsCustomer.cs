using System;
using System.IO;


namespace ClassLibrary
{

    public class clsCustomer
    {


        private Int32 mCustomerId;
        private string mCustomerName;
        private string mCustomerEmail;
        private string mSubsicriptionId;
        private string mPaymentStatus;
        private string mCreatedAt;


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
        public string CreatedAt
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

        public bool Find(int customerId)
        {
            mCustomerId = 21;
            return true;
        }

        public void Find(object customerId)
        {
            throw new NotImplementedException();
        }

        public string Valid(Int32 CustomerId, string CustomerName, string CustomerEmail,
      string SubsicriptionId, string PaymentStatus, string CreatedAt)
        {
            string Error = "";



            // Validate CustomerId
            if (CustomerId <= 0)
            {
                Error += "The CustomerId may not be blank or zero. ";
            }
            else if (CustomerId > 999999)  // max 6 digits allowed
            {
                Error += "The CustomerId can't be more than 6 digits. ";
            }






            // Validate CustomerName

            if (string.IsNullOrWhiteSpace(CustomerName))
            {
                Error += "The CustomerName may not be blank. ";
            }
            else if (CustomerName.Length > 20)
            {
                Error += "The CustomerName must be 20 characters or less. ";
            }





            // Validate CustomerEmail
            if (string.IsNullOrWhiteSpace(CustomerEmail))
            {
                Error += "The CustomerEmail may not be blank. ";
            }
            else
            {
                // Check if contains '@' and split
                int atIndex = CustomerEmail.IndexOf('@');
                if (atIndex < 1) // '@' not found or no chars before '@'
                {
                    Error += "The CustomerEmail must contain an '@' with at least one character before it. ";
                }
                else
                {
                    string localPart = CustomerEmail.Substring(0, atIndex);
                    if (localPart.Length > 30)
                    {
                        Error += "The local part of CustomerEmail must be 30 characters or less. ";
                    }




                }
            }



            //Validate SubsicriptionId



            if (string.IsNullOrWhiteSpace(SubsicriptionId))
            {
                Error += "The SubscriptionId may not be blank. ";
            }
            else if (SubsicriptionId.Length > 10)
            {
                Error += "The SubscriptionId must be 10 characters or less. ";
            }



            //validate PaymentStatus

            if (string.IsNullOrWhiteSpace(PaymentStatus))
            {
                Error += "The PaymentStatus may not be blank. ";
            }
            else if (PaymentStatus.Length > 10)
            {
                Error += "The PaymentStatus must be 10 characters or less. ";
            }


            //validte CreatedAt

            if (string.IsNullOrWhiteSpace(CreatedAt))
            {
                Error += "CreatedAt may not be blank. ";
            }

         

            return Error; 
        }
    }
}
