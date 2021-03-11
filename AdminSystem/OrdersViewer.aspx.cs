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
        //create a new instance of the class
        clsOrders AnOrder = new clsOrders();
        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the product id on the page
        Response.Write(AnOrder.ProductId);
        //display the description on the page
        Response.Write(AnOrder.Description);
        //display the status on the page
        Response.Write(AnOrder.Status);
    }
}