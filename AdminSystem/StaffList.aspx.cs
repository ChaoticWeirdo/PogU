﻿using System;
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
       
        clsStaffCollection Address = new clsStaffCollection();
        lstStaffList.DataSource = Address.StaffList;
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
}