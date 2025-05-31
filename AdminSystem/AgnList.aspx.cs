using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 AgentId;
    protected void Page_Load(object sender, EventArgs e)
     
    {
        //get the number of the record to be processed
        AgentId = Convert.ToInt32(Session["AgentId"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAgents();
        }
        //create a new instance of clsAgentUser
        clsAgentUser AnUser = new clsAgentUser();
        //get data from the session object
        AnUser = (clsAgentUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);

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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["AgentId"] = -1;
        //redirect to the data entry page
        Response.Redirect("AgnDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        //variable to store the primary key of the record to be edited
        Int32 AgentId;
        //if a record has been selected from the list
        if (lstAgentList.SelectedIndex != -1)
        {
            // Get selected AgentId and redirect to data entry
            AgentId = Convert.ToInt32(lstAgentList.SelectedValue);
            Session["AgentId"] = AgentId;
            Response.Redirect("AgnDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key of the record to be deleted
        Int32 AgentId;
        //if a record has been selected from the list
        if (lstAgentList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            AgentId = Convert.ToInt32(lstAgentList.SelectedValue);
            //store the data in the session object
            Session["AgentId"] = AgentId;
            //redirect to the delete page
            Response.Redirect("AgnConfirmDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Agent Collection
        clsAgentCollection AnAgent = new clsAgentCollection();
        //retreive the value of the category
        AnAgent.ReportByCategory(txtFilter.Text);
        //set the data source to the list of agents in the collection
        lstAgentList.DataSource = AnAgent.AgentList;
        //set the name of the primary key
        lstAgentList.DataValueField = "AgentId";
        //set the data field to display
        lstAgentList.DataTextField = "Category";
        //bind the data to the list
        lstAgentList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Agent Collection
        clsAgentCollection AnAgent = new clsAgentCollection();
        //set an empty string
        AnAgent.ReportByCategory("");
        //clear the text box
        txtFilter.Text = "";
        //set the data source to the list of agents in the collection
        lstAgentList.DataSource = AnAgent.AgentList;
        //set the name of the primary key
        lstAgentList.DataValueField = "AgentId";
        //set the data field to display
        lstAgentList.DataTextField = "Category";
        //bind the data to the list
        lstAgentList.DataBind();
    }

    protected void btnRetourMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
