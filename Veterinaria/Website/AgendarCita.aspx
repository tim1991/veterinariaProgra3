<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgendarCita.aspx.cs" Inherits="Website.AgendarCita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
