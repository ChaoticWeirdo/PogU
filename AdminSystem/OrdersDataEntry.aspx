<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" Text="Order Id" height="19px" width="108px"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtOrderId" runat="server" Height="22px" style="margin-left: 12px" Width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerId" runat="server" height="19px" Text="Customer Id" width="128px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductId" runat="server" height="19px" Text="Product Id" width="128px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderDate" runat="server" height="19px" Text="Order Date" width="128px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDescription" runat="server" Text="Description" width="127px"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" height="19px" Text="Price" width="128px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblStatus" runat="server" height="19px" Text="Status" width="128px"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateShipped" runat="server" height="19px" Text="Date Shipped" width="128px"></asp:Label>
        <asp:TextBox ID="txtDateShipped" runat="server" height="22px" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="ChkPaid" runat="server" Text="Paid" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
