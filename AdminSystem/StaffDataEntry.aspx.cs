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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the first name
        AnStaff.StaffFirstName = txtStaffFirstName.Text;
        AnStaff.StaffLastName = txtStaffLastName.Text;
        AnStaff.Gender = txtGender.Text;
        AnStaff.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
        AnStaff.StaffID = int.Parse(txtStaffID.Text);
        AnStaff.NINo = txtNINo.Text;
        AnStaff.PhoneNo = txtPhoneNo.Text;
        AnStaff.Address = txtAddress.Text;
        AnStaff.PostCode = txtPostCode.Text;
        // store the staff in the session object
        Session["AnStaff"] = AnStaff;
        // navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }


}