﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of Customer Ids in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "CustomerId";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}