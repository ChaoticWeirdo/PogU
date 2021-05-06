using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get te data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the first name for this entry
        Response.Write(AnStaff.StaffFirstName);
        Response.Write(AnStaff.StaffLastName);
        Response.Write(AnStaff.Gender);
        Response.Write(AnStaff.DateOfBirth);
        Response.Write(AnStaff.NINo);
        Response.Write(AnStaff.PhoneNo);
        Response.Write(AnStaff.Address);
        Response.Write(AnStaff.PostCode);

    }
}