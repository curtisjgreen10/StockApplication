<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StockApplication.login" %>
<link rel="stylesheet" runat="server" media="screen" href="login.css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Login</title>
        <style type="text/css">
        body {
            background-image:url('background_img.jpg');
            background-repeat:no-repeat;
            background-attachment:fixed;
            background-size:cover;
            background-position:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 357px">

            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" runat="server" Visible ="false" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <div id="links" align="right">
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:LinkButton ID="btn_sign_up"  runat="server" Text="Create Account" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_sign_up_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srvc_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srvc_dir_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Member Features"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_ftrs_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Log out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 10px; width: 50px;"></span>
            </div>

            <div id="div_center" align="center" style="height: 398px">
            <asp:Label ID="lbl_mber_login_pg" runat="server"  Text="Member Login Page:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <span style="display:block; height: 26px; width: 50px;"></span>
            <asp:Label ID="lbl_username" runat="server"  Text="Username:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:TextBox ID="txt_username" runat="server" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_username_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 15px; width: 50px;"></span>
            <asp:Label ID="lbl_pass" runat="server"  Text="Password:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_pass_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 23px; width: 50px;"></span>
            <asp:CheckBox ID="chk_staff"  runat="server" BorderColor="Yellow" BorderStyle="Solid" ></asp:CheckBox>
            <asp:Label ID="lbl_staff" runat="server" Text="Staff?" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <span style="display:block; height: 23px; width: 50px;"></span>
            <asp:Button ID="btn_mber_login"  runat="server" Text="Login"  Height="44px" Width="139px" OnClick="btn_mber_login_Click" ></asp:Button>
            <span style="display:block; height: 23px; width: 50px;"></span>
            <asp:CheckBox ID="chk_remember"  runat="server" BorderColor="Yellow" BorderStyle="Solid" ></asp:CheckBox>
            <asp:Label ID="lbl_remember" runat="server" Text="Remember My Username" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <span style="display:block; height: 21px; width: 50px;"></span>
            <asp:Label ID="lbl_usrname" runat="server" Text="" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <span style="display:block; height: 36px; width: 50px;"></span>
            <asp:Button ID="btn_not_you"  runat="server" Text="Not You?"  Height="44px" Width="139px" OnClick="btn_not_you_Click" ></asp:Button>
            </div>
        </div>
    </form>
</body>
</html>
