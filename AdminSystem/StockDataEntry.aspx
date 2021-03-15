<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="IblProductID" runat="server" Text="Product ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductID" runat="server" width="68px"></asp:TextBox>
        <br />
        <asp:Label ID="IblProductName" runat="server" Text="Product Name" width="95px"></asp:Label>
&nbsp; <asp:TextBox ID="txtProductName" runat="server" Width="103px"></asp:TextBox>
        <br />
        <asp:Label ID="IblGender" runat="server" Text="Gender" width="89px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtGender" runat="server" width="68px"></asp:TextBox>
        <br />
        <asp:Label ID="IblPrice" runat="server" Text="Price" width="68px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server" OnTextChanged="txtPrice_TextChanged" width="68px"></asp:TextBox>
        <br />
        <asp:Label ID="IblOrderDate" runat="server" Text="OrderDate" width="68px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderDate" runat="server" width="68px"></asp:TextBox>
        <br />
        <asp:Label ID="IblQuantity" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtQuantity" runat="server" Width="72px"></asp:TextBox>
        <br />
        <asp:Label ID="IblLimitedStocks" runat="server" Text="Limited Stock"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtLimitedStock" runat="server" Width="75px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="IblLimitedStock" runat="server" Text="Limited Stock"></asp:Label>
&nbsp;<asp:CheckBox ID="ChkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="IblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
