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
        //store the agent in the seesion object
        Session["AnAgent"] = AnAgent;
        //Navigate to the view page
        Response.Redirect("AgnViewer.aspx");
    }
}