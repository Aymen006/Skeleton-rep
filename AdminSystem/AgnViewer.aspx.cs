using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance clsAgent
        clsAgent AnAgent = new clsAgent();
        //Get the data from the session object
        AnAgent = (clsAgent)Session["AnAgent"];
        //Display the agent name for this entry
        Response.Write(AnAgent.AgentName);

    }
}