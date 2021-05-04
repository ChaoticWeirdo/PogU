using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope 
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != 1)
            {
                //display the current data for the new record
                DisplayStaff();
            }

        }
    }

    void DisplayStaff()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(StaffID);
        txtStaffID.Text = StaffList.ThisStaff.StaffID.ToString();
        txtStaffFirstName.Text = StaffList.ThisStaff.StaffFirstName.ToString();
        txtStaffLastName.Text = StaffList.ThisStaff.StaffLastName.ToString();
        txtGender.Text = StaffList.ThisStaff.Gender.ToString();
        txtDateOfBirth.Text = StaffList.ThisStaff.DateOfBirth.ToString();
        txtNINo.Text = StaffList.ThisStaff.NINo.ToString();
        txtPhoneNo.Text = StaffList.ThisStaff.PhoneNo.ToString();
        txtAddress.Text = StaffList.ThisStaff.Address.ToString();
        txtPostCode.Text = StaffList.ThisStaff.PostCode.ToString();
        chkCitizen.Checked = StaffList.ThisStaff.Citizen;

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {

        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the first name
        string StaffFirstName = txtStaffFirstName.Text;
        string StaffLastName = txtStaffLastName.Text;
        string Gender = txtGender.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string NINo = txtNINo.Text;
        string PhoneNo = txtPhoneNo.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string Error = "";
        Error = AnStaff.Valid(StaffFirstName, StaffLastName, Gender, DateOfBirth, NINo, PhoneNo, Address, PostCode);
        if (Error == "")
        {
            //capture the first name
            AnStaff.StaffFirstName = StaffFirstName;
            AnStaff.StaffLastName = StaffLastName;
            AnStaff.Gender = Gender;
            AnStaff.DateOfBirth = Convert.ToDateTime( DateOfBirth);
            AnStaff.NINo = NINo;
            AnStaff.PhoneNo = PhoneNo;
            AnStaff.Address = Address;
            AnStaff.PostCode = PostCode;
            AnStaff.Citizen = chkCitizen.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID = -1 then add the data
            if (StaffID == -1)
            {
                // set the ThisStaff property 
                StaffList.ThisStaff = AnStaff;
                //add the new record 
                StaffList.Add();
            }
            //otherwise it must be an update 
            else
            {
                //find the record to update 
                StaffList.ThisStaff.Find(StaffID);
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //update the record 
                StaffList.Update();
            }
            
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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