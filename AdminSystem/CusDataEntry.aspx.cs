using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
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

        customer.CustomerEmail = txtCustomerEmail.Text;
        customer.SubsicriptionId = txtSubscriptionId.Text; 
        customer.PaymentStatus = txtPaymentStatus.Text;

       
        customer.CreatedAt = txtDate.SelectedDate;

       
        Session["customer"] = customer;

        
        Response.Redirect("CusViewer.aspx");
    }
}
