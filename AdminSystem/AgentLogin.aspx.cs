using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AgentLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the user class
        clsAgentUser AnUser = new clsAgentUser();

        //store the username entered by the user
        string UserName = txtUserName.Text;
        //store the password entered by the user
        string Password = txtPassword.Text;

        //variable to store the outcome of the find method
        Boolean Found = false;

        UserName = Convert.ToString(UserName);
        Password = Convert.ToString(Password);
        Found = AnUser.FindUser(UserName, Password);
        //add a session to capture the user name
        Session["AnUser"] = AnUser;

        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username";

        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        //if found
        else if (Found == true)
        {
            Response.Redirect("AgnList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

