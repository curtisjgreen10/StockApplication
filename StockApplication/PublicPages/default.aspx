<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="StockApplication.PublicPages._default" %>

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
        <div>
            <div align="right">
            <span style="display:block; height: 1px; width: 50px;"></span>
            <span style="display:inline-block; width:783px;"></span>
            <asp:Button ID="btn_login"  runat="server" Text="Member Log In"  Height="45px" Width="172px" OnClick="btn_login_Click" ></asp:Button>
            <span style="display:block; height: 10px; width: 50px;"></span>
            <span style="display:inline-block; width:783px;"></span>
            <asp:Button ID="btn_stf_login"  runat="server" Text="Staff Log In"  Height="45px" Width="172px" OnClick="btn_stf_login_Click" ></asp:Button>
            </div>
            <div align="center">
            Sign Up For Memebership Here:
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
            <span style="display:block; height: 5px; width: 50px;"></span>
            Confirm Password:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:TextBox ID="txt_pass_cnfrm" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_pass_cnfrm_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Button ID="btn_signup"  runat="server" Text="Sign Up"  Height="44px" Width="139px" OnClick="btn_signup_Click" ></asp:Button>
            <span style="display:block; height: 5px; width: 50px;"></span>
            </div>
            <span style="display:block; height: 50px; width: 50px;"></span>
            Membership Features: **TODO: LIST MEMBERSHIP FEATURES HERE**
            <span style="display:block; height: 50px; width: 50px;"></span>
            Test Cases: **TODO: LIST TEST CASES/RESULTS HERE**
            <div align="right">
            <span style="display:block; height: 31px; width: 50px;"></span>
            <span style="display:inline-block; width:783px;"></span>
            <asp:Button ID="btn_svrc_dir"  runat="server" Text="View Service Directory"  Height="45px" Width="172px" OnClick="btn_svrc_dir_Click" ></asp:Button>
            <span style="display:block; height: 31px; width: 50px;"></span>
            </div>
        </div>
    </form>
</body>
</html>
