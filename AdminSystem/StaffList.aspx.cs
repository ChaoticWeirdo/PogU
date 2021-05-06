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
            DisplayStaff();
        }
    }
    void DisplayStaff()
    {
       
        ClassLibrary.clsStaffCollection Staff = new ClassLibrary.clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "PostCode";
        lstStaffList.DataBind();


    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["StaffID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void lblDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record had been selected from the list
        if (lstStaffList.SelectedIndex != 1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirecr to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection Orders = new clsStaffCollection();
        Orders.ReportByPostCode(txtFilter.Text);
        lstStaffList.DataSource = Orders.StaffList;
        //set the name of the primart key
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "PostCode";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByPostCode("");
        //clear any existing filler to tidy up the interface 
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primart key
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "PostCode";
        //bind the data to the list
        lstStaffList.DataBind();

    }
}