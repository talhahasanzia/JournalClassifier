<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">


             <asp:ListItem Selected="True" Value="Springer"> Springer </asp:ListItem>
                  <asp:ListItem Value="IEEE"> IEEE</asp:ListItem>
                  <asp:ListItem Value="ACM"> ACM </asp:ListItem>

        </asp:DropDownList>
    
        <asp:Button ID="RunButton" runat="server" Text="Button" OnClick="RunButton_Click" />
    
    </div>
        <div>

            <asp:Label ID="OutputLabel" runat="server" Text="Label"></asp:Label>

            </div>
    </form>
</body>
</html>
