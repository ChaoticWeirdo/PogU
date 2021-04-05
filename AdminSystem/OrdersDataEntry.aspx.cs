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
        //capture the Customer Id
        string CustomerId = txtCustomerId.Text;
        //capture the Product Id
        string ProductId = txtProductId.Text;
        //capture Order Date
        string OrderDate = txtOrderDate.Text;
        //capture the Description
        string Description = txtDescription.Text;
        //capture the Price
        string Price = txtPrice.Text;
        //capture the status
        string Status = txtStatus.Text;
        //capture Date Shipped
        string DateShipped = txtDateShipped.Text;
        //variabl to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(CustomerId, ProductId, OrderDate, Description, Price, Status, DateShipped);
        if (Error == "")
        {
            //capture the Customer Id
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            //capture the Product Id
            AnOrder.ProductId = ProductId;
            //capture the Order Date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the Description
            AnOrder.Description = Description;
            //capture the Price
            AnOrder.Price = Convert.ToDouble(Price);
            //capture Paid
            AnOrder.Paid = ChkPaid.Checked;
            //capture the Status
            AnOrder.Status = Status;
            //capture the Date Shipped
            AnOrder.DateShipped = Convert.ToDateTime(DateShipped);
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //add the new record
            OrderList.Add();
            //redirect back to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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