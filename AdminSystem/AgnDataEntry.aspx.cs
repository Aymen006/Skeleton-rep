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
}