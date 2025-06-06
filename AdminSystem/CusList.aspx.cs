using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);

        if (!IsPostBack)
        {
            DisplayCustomer();
        }

    }

    void DisplayCustomer()
    {
        clsTestingCustomerCollection Customers = new clsTestingCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "CustomerName";
        lstCustomerList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CusDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");

        }
        else
        {
            Console.WriteLine("Please Select a record from the list to edit");
        }
    }
}
