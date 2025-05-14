using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Capture input as strings first
        string agentName = txtAgentName.Text;
        string description = txtDescription.Text;
        string category = txtCategory.Text;
        string integrationType = txtIntegrarion.Text;
        string price = txtPrice.Text;
        string updatedAt = txtUpdatedAt.Text;
        bool status = chkActive.Checked;

        //create a new instance of clsAgent for validation
        clsAgent AnAgent = new clsAgent();

        //variable to store the error message
        string Error = "";

        //Validate the data
        Error = AnAgent.Valid(agentName, description, category, integrationType, updatedAt);

        if (Error == "")
        {
            //capture the agent properties
            AnAgent.AgentName = agentName;
            AnAgent.Description = description;
            AnAgent.Category = category;
            AnAgent.IntegrationType = integrationType;
            AnAgent.Status = status;

            // Handle the date
            AnAgent.UpdatedAt = Convert.ToDateTime(DateTime.Now);

            // Handle the price
            int parsedPrice;
            if (int.TryParse(price, out parsedPrice))
            {
                AnAgent.Price = parsedPrice;
            }
            else
            {
                // Add price validation error
                Error = "Please enter a valid numeric value for Price.";
                lblError.Text = Error;
                return;
            }

            //store the agent in the session object
            Session["AnAgent"] = AnAgent;

            //Navigate to the view page
            Response.Redirect("AgnViewer.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class 
        clsAgent AnAgent = new clsAgent();
        //create a variable to store the primary key
        Int32 AgentId;
        //create a variable to store the resault of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AgentId = Convert.ToInt32(txtAgentId.Text);
        //find the record
        Found = AnAgent.Find(AgentId);
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtAgentName.Text = AnAgent.AgentName;
            txtDescription.Text = AnAgent.Descr;
            txtCategory.Text = AnAgent.Category;
            txtIntegrarion.Text = AnAgent.IntegrationType;
            chkActive.Checked = AnAgent.Status;
            txtUpdatedAt.Text = AnAgent.UpdatedAt.ToString();
            txtPrice.Text = AnAgent.Price.ToString();
        }
            


    }
}