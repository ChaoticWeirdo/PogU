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



    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //creste an instance of the staff class 
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record 
        Found = AnStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtStaffFirstName.Text = AnStaff.StaffFirstName;
            txtStaffLastName.Text = AnStaff.StaffLastName;
            txtGender.Text = AnStaff.Gender;
            txtDateOfBirth.Text = AnStaff.DateOfBirth.ToString();
            txtNINo.Text = AnStaff.NINo;
            txtPhoneNo.Text = AnStaff.PhoneNo;
            txtAddress.Text = AnStaff.Address;
            txtPostCode.Text = AnStaff.PostCode;
        }
        else
        {
            txtStaffID.Text = "No Staff with that ID";
        }
    }
}