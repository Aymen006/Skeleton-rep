using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAgents();
        }

    }
    void DisplayAgents()
    {
        //create an instance of the Agent Collection
        clsAgentCollection Agents = new clsAgentCollection();
        //set the data source to the list of agents in the collection
        lstAgentList.DataSource = Agents.AgentList;
        //set the name of the primary key
        lstAgentList.DataValueField = "AgentId";
        //set the data field to display
        lstAgentList.DataTextField = "AgentName";
        //bind the data to the list
        lstAgentList.DataBind();
    }
}