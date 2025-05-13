using System;
using System.Collections.Generic;
using System.Linq;
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
        //create a new instance of clsAddress
        clsAgent AnAgent = new clsAgent();
        //capture the agent name
        AnAgent.AgentName = txtAgentName.Text;
        AnAgent.Description = txtDescription.Text;
        AnAgent.Category = txtCategory.Text;
        AnAgent.IntegrationType = txtIntegrarion.Text;
        AnAgent.Status = chkActive.Checked;
        AnAgent.UpdatedAt = Convert.ToDateTime(DateTime.Now);

        int price;
        if (int.TryParse(txtPrice.Text, out price))
        {
            AnAgent.Price = price;
        }
        else
        {
            // Handle invalid input (e.g., show an error message)  
            lblError.Text = "Please enter a valid numeric value for Price.";
            return;
        }
        AnAgent.Price = Convert.ToInt32(txtPrice.Text);
        //store the agent in the seesion object
        Session["AnAgent"] = AnAgent;
        //Navigate to the view page
        Response.Redirect("AgnViewer.aspx");
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