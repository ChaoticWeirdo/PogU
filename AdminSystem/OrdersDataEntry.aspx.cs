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
}