using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object CustomerId { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    void DisplayCustomer()
    {
        clsTestingCustomerCollection CustomerBook = new clsTestingCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerId);

        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName.ToString();
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail.ToString();
        txtSubscriptionId.Text = CustomerBook.ThisCustomer.SubsicriptionId.ToString();
        txtPaymentStatus.Text = CustomerBook.ThisCustomer.PaymentStatus.ToString();
        txtDate.SelectedDate = Convert.ToDateTime(CustomerBook.ThisCustomer.CreatedAt);



    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string Error = "";

        clsCustomer customer = new clsCustomer();

        
        customer.CustomerName = txtCustomerName.Text;

        int customerId;
        if (int.TryParse(txtCustomerId.Text, out customerId))
        {
            customer.CustomerId = customerId;
        }
        else
        {
            
            customer.CustomerId = 0;
        }

        if (Error == "")
        {
            customer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerEmail = txtCustomerEmail.Text;
            customer.SubsicriptionId = txtSubscriptionId.Text;
            customer.PaymentStatus = txtPaymentStatus.Text;


            if (Session["CreatedAt"] != null)
            {
                customer.CreatedAt = Session["CreatedAt"].ToString(); // assuming you add a string property CreatedAtString
            }
            else
            {
                // Fallback if Session is empty (convert now)
                customer.CreatedAt = txtDate.SelectedDate.ToString("yyyy-MM-dd");
            }


            Session["customer"] = customer;


            Response.Redirect("CusList.aspx");


        }
        else {
            Console.WriteLine(Error);
        }
    }


    protected void txtCustomerName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPaymentStatus_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDate_SelectionChanged(object sender, EventArgs e)
    {
        // Convert the selected date to string format
        string selectedDateString = txtDate.SelectedDate.ToString("yyyy-MM-dd"); // Adjust format if needed

        // Optionally, store in session if you want to use it elsewhere
        Session["CreatedAt"] = selectedDateString;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
}
