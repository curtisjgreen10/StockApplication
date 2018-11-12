<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StockApplication.PublicPages.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style type="text/css">
        #form1 {
            height: 807px;
            background-color:aquamarine;
            color:black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 357px">
            <div align="center" style="height: 398px">
            <span style="display:block; height: 100px; width: 50px;"></span>
            Member Login Page:
            <span style="display:block; height: 26px; width: 50px;"></span>
            Username:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:TextBox ID="txt_username" runat="server" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_username_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 15px; width: 50px;"></span>
            Password:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_pass_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 23px; width: 50px;"></span>
            <asp:Button ID="btn_mber_login"  runat="server" Text="Member Login"  Height="44px" Width="139px" OnClick="btn_mber_login_Click" ></asp:Button>
            <span style="display:block; height: 21px; width: 50px;"></span>
            <asp:Label ID="lbl_usrname" runat="server" Text=""></asp:Label>
            <span style="display:block; height: 36px; width: 50px;"></span>
            <asp:Button ID="btn_not_you"  runat="server" Text="Not You?"  Height="44px" Width="139px" OnClick="btn_not_you_Click" ></asp:Button>
            </div>
        </div>
    </form>
</body>
</html>
