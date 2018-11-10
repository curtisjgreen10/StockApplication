<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StockApplication.PublicPages.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 357px">
            <div align="center">
            <span style="display:block; height: 100px; width: 50px;"></span>
            Member Login Page:
            <span style="display:block; height: 26px; width: 50px;"></span>
            Email Address:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:TextBox ID="txt_email" runat="server" Width="220px"  ></asp:TextBox>
            <span style="display:block; height: 15px; width: 50px;"></span>
            Password:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:TextBox ID="txt_pass" runat="server" Width="220px"  ></asp:TextBox>
            <span style="display:block; height: 23px; width: 50px;"></span>
            <asp:Button ID="btn_mber_login"  runat="server" Text="Member Login"  Height="44px" Width="139px" OnClick="btn_mber_login_Click" ></asp:Button>
            <span style="display:block; height: 5px; width: 50px;"></span>
            </div>
        </div>
    </form>
</body>
</html>
