<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaSumar2.aspx.cs" Inherits="Agosto29b.PaginaSumar2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Pagina sumar 2</h1><br />

        <br />
        Numero1:<asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
        <br />
        Numero2:<asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
            <br />
            <br />
        <br />
            <asp:Label ID="LabelResultado" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        </div>
    </form>
</body>
</html>
