using System;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        clsCustomer customer = (clsCustomer)Session["customer"];

        if (customer != null)
        {
            Response.Write("Name: " + customer.CustomerName + "<br />");
            Response.Write("ID: " + customer.CustomerId + "<br />");
            Response.Write("Email: " + customer.CustomerEmail + "<br />");
            Response.Write("Subscription ID: " + customer.SubsicriptionId + "<br />");
            Response.Write("Payment Status: " + customer.PaymentStatus + "<br />");
            Response.Write("Created At: " + customer.CreatedAt.ToString() + "<br />");
        }
        else
        {
            Response.Write("Customer session not found.");
        }
    }
}
