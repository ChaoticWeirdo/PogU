<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="StaffID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblStaffFirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtStaffFirstName" runat="server"></asp:TextBox>
        <asp:Label ID="lblStaffLastName" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtStaffLastName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblNINo" runat="server" Text="National Insurance No" width="107px"></asp:Label>
            <asp:TextBox ID="txtNINo" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number" width="107px"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="107px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPostCode" runat="server" Text="Post Code" width="107px"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCitizen" runat="server" Text="Citizen" width="107px"></asp:Label>
            <asp:CheckBox ID="chkCitizen" runat="server" Text="yes" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
