using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key of the record to be deleted
    Int32 AgentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the record to be processed
        AgentId = Convert.ToInt32(Session["AgentId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create the new instance of the Agent Collection class
        clsAgentCollection Agents = new clsAgentCollection();
        //find the record to delete
        Agents.ThisAgent.Find(AgentId);
        //delete the record
        Agents.Delete();
        //redirect back to the main page
        Response.Redirect("AgnList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("AgnList.aspx");
    }
}
