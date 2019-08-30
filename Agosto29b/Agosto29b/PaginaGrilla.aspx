<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaGrilla.aspx.cs" Inherits="Agosto29b.PaginaGrilla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Nombre" DataValueField="Nombre">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server">
                dsfkkfdskfdskfdskfdskfkdskfdskdsfkfsd<br /> fdksdfkfsdkdskf<asp:Button ID="Button1" runat="server" Text="Button" />
                <asp:CheckBox ID="CheckBox1" runat="server" />
                <br />
            </asp:Panel>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
