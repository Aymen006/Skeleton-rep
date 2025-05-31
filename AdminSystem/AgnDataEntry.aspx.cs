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
    int AgentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) // Crucial: Only load data on the initial page load, not on subsequent postbacks (e.g., button clicks)
        {
            if (Session["AgentId"] != null)
            {
                int agentIdToLoad;
                if (Int32.TryParse(Session["AgentId"].ToString(), out agentIdToLoad))
                {
                    LoadAgentDetails(agentIdToLoad);
                }
                else
                {
                    lblError.Text = "Invalid Agent ID format in session.";
                    // Optionally disable form or redirect
                }
                // Optional: You might want to clear the session variable if it's only for one-time use,
                // especially if this page can also be used for creating new agents.
                // Session.Remove("AgentId");
                // However, if you keep it, it doesn't hurt for an "edit" scenario.
                // Storing it in hdfAgentId (as done in LoadAgentDetails) is good practice.
            }
            else
            {
                // No AgentId found in Session. This could mean the user navigated
                // directly to AgnDataEntry.aspx or it's for creating a new agent.
                // Handle accordingly (e.g., set page for new entry, show error, or redirect).
                lblError.Text = "No agent selected for editing. Please go back to the list and select an agent.";
                // DisableControls(); // A helper method to disable form fields
            }
        }
    }
    private void LoadAgentDetails(int agentId)
    {
        clsAgent AnAgent = new clsAgent();
        Boolean Found = AnAgent.Find(agentId); // Use your existing Find method

        if (Found == true)
        {
            // Populate the form fields with the agent's details
            txtAgentName.Text = AnAgent.AgentName;
            txtDescription.Text = AnAgent.Descr;
            txtCategory.Text = AnAgent.Category;
            txtIntegration.Text = AnAgent.IntegrationType;
            chkActive.Checked = AnAgent.Status;
            txtUpdatedAt.Text = AnAgent.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss"); // Format DateTime for display
            txtPrice.Text = AnAgent.Price.ToString("0"); // Format decimal for display (e.g., currency)

            // Store the AgentId in a HiddenField. This is useful if you have
            // "Update" or "Delete" buttons on this page, so they know which agent
            // they are operating on without relying on Session for subsequent postbacks.
            

            lblError.Text = ""; // Clear any previous error messages
        }
        else
        {
            lblError.Text = "Agent details could not be found for the selected ID. The agent may have been deleted.";
            // DisableControls(); // Helper method to disable form fields if agent not found
        }
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
        string integrationType = txtIntegration.Text;
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
            AnAgent.AgentId = AgentId;
            AnAgent.AgentName = agentName;
            AnAgent.Descr = description;
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
            //create a new instance of clsAgentCollection
            clsAgentCollection AgentList = new clsAgentCollection();
            //set the ThisAgent property
            AgentList.ThisAgent = AnAgent;
            //add the new record
            AgentList.Add();
            //redirect back to the list page
            Response.Redirect("AgnList.aspx");
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
            txtIntegration.Text = AnAgent.IntegrationType;
            chkActive.Checked = AnAgent.Status;
            txtUpdatedAt.Text = AnAgent.UpdatedAt.ToString();
            txtPrice.Text = AnAgent.Price.ToString();
        }
            
    }

    void DisplayAgent()
    {
        clsAgentCollection AgentList = new clsAgentCollection();
        AgentList.ThisAgent.Find(AgentId);

        txtAgentName.Text = AgentList.ThisAgent.AgentName;
        txtDescription.Text = AgentList.ThisAgent.Descr;
        txtCategory.Text = AgentList.ThisAgent.Category;
        txtIntegration.Text = AgentList.ThisAgent.IntegrationType;
        chkActive.Checked = AgentList.ThisAgent.Status;
        txtPrice.Text = AgentList.ThisAgent.Price.ToString();
    }

    protected void btnRetourMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgnList.aspx");
    }
}
