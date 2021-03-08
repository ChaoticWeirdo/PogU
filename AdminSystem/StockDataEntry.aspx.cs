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
        //create a new instance of clsStock
        clsStock Anstock = new clsStock();
        //capture the product Name
        Anstock.ProductName = txtProductName.Text;
        //store the product Name in the session object
        Session["Anstock"] = Anstock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }
}