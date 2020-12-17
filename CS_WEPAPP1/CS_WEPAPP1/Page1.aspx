<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="CS_WEPAPP1.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image1" runat="server" Height="433px" ImageUrl="~/Marry.png" Width="862px" />
        <br />
        <br />
        <asp:Label ID="showTxt" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="date_" runat="server" Width="168px"></asp:TextBox>
        <asp:Button ID="Click_" runat="server" OnClick="Click__Click" Text="Click" />
        <br />
        <br />
    </form>
</body>
</html>
