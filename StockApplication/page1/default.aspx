<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="StockApplication.PublicPages._default" %>
<%@ Register Src="~/page1/captcha.ascx" TagName="captcha" TagPrefix="user" %>
<link rel="stylesheet" runat="server" media="screen" href="default.css" />

<!DOCTYPE html "">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Sign Up</title>

</head>
<body>
    <form id="mainDiv" runat="server">
        <div>
                        
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" runat="server" Visible ="false" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>

            <div id="links" align="right">
            <asp:LinkButton ID="btn_login"  runat="server" Text="Log In" style="background-color:darkorange" OnClick="btn_login_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srvc_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange" OnClick="btn_srvc_dir_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Member Features"  style="background-color:darkorange" OnClick="btn_ftrs_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Log out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            </div>

            <div id="div_title" align="center">
            <asp:Label ID="lbl_title" runat="server" Text="WELCOME TO THE STOCK MARKET QUOTE PAGE!!!" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            </div>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <div id="div_center" align="center">
            <asp:Label ID="lbl_sgn_up" runat="server"  Text="Sign Up For Memebership Here:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <br/> 
            <asp:Label ID="lbl_rqrd_txt" runat="server"  Text="All fields with * next to them required. Blank is not allowed for username or password." BorderColor="Yellow" BorderStyle="Solid"></asp:Label>    
            <span style="display:block; height: 26px; width: 50px;"></span>
            <asp:Label ID="lbl_usrname" runat="server"  Text="Username:" BorderColor="Yellow" BorderStyle="Solid" Width="192px"></asp:Label>
            <asp:TextBox ID="txt_username" runat="server" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_user_ask" runat="server"  Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_username_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="lbl_pass" runat="server"  Text="Password:" BorderColor="Yellow" BorderStyle="Solid" Width="192px"></asp:Label>
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_pass_ask" runat="server"  Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_pass_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="lbl_cnfrm_pass" runat="server"  Text="Confirm Password:" BorderColor="Yellow" BorderStyle="Solid" Width="192px"></asp:Label>
            <asp:TextBox ID="txt_pass_cnfrm" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="lbl_cnfrm_ask" runat="server"  Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_pass_cnfrm_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <user:captcha ID="capTable" runat="server" />
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:Label ID="lbl_verify_string" runat="server"  Text="Enter verify string here:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:TextBox ID="txt_img_string" runat="server" Width="133px"  ></asp:TextBox>
            <asp:Label ID="lbl_verify_string_ask" runat="server"  Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_captcha_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 20px; width: 100px;"></span>
            <asp:Button ID="btn_signup" Font-Size="24px"  runat="server" Text="Sign Up"  Height="44px" Width="139px" OnClick="btn_signup_Click" ></asp:Button>
            </div>
            <span style="display:block; height: 20px; width: 20px;"></span>
            <div align="right">
            <span style="display:block; height: 31px; width: 50px;"></span>
            </div>
        </div>
    </form>
</body>
</html>
