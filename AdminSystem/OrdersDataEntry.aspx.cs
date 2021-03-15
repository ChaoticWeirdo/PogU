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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the product id
        AnOrder.ProductId = txtProductId.Text;
        //capture the description
        AnOrder.Description = txtDescription.Text;
        //capture the status
        AnOrder.Status = txtStatus.Text;
        //Store the data in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void txtProductId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Order class
        clsOrders AnOrder = new clsOrders();
        //variable to store the primary key
        Int32 OrderId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primart key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtProductId.Text = AnOrder.ProductId;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtDescription.Text = AnOrder.Description;
            txtPrice.Text = AnOrder.Price.ToString();
            txtStatus.Text = AnOrder.Status;
            txtDateShipped.Text = AnOrder.DateShipped.ToString();
        }
        else
        {
            txtOrderId.Text = "No order with that ID";
        }
    }
}