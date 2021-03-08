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
        //create a new instance of clsstock
        clsStock Anstock = new clsStock();
        //get the data from the session object
        Anstock = (clsStock)Session["Anstock"];
        //display the Product Name for the entry
        Response.Write(Anstock.ProductName);
    }
}