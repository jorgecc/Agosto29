<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaSumar.aspx.cs" Inherits="Agosto29.PaginaSumar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            numero1:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            numero2:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
