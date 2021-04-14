using System;
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record had been selected from the list
        if (lstOrderList.SelectedIndex != 1)
        {
            //get the primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirecr to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByProductId(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primart key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "ProductId";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByProductId("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "ProductId";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}