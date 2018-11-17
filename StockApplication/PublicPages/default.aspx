<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="StockApplication.PublicPages._default" %>
<%@ Register Src="~/PublicPages/captcha.ascx" TagName="captcha" TagPrefix="user" %>

<!DOCTYPE html "">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Sign Up</title>
    <style type="text/css">
        #pic {
            background-image:url('background_img.jpg');
            background-repeat:no-repeat;
            background-attachment:fixed;
            background-size:cover;
            background-position:center;
            
            
        }
    </style>
    <style type="text/css">
        #cen {
            font-size:24px;
        }
    </style>
    <style type="text/css">
        #div_title {
            font-size:30px;
        }
    </style>


</head>
<body id="pic">
    <form id="mainDiv" runat="server">
        <div>
            <div id="links" align="right">
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:LinkButton ID="btn_login"  runat="server" Text="Member Log In" style="background-color:darkorange" OnClick="btn_login_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stf_login"  runat="server" Text="Staff Log In"  style="background-color:darkorange" OnClick="btn_stf_login_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srvc_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange" OnClick="btn_srvc_dir_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Member Features"  style="background-color:darkorange" OnClick="btn_ftrs_Click" BorderColor="Yellow" BorderStyle="Solid" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 10px; width: 50px;"></span>
            </div>

            <div id="div_title" align="center">
            <asp:Label ID="lbl_title" runat="server" style="background-color:darkorange; 
                border-bottom-left-radius:5px; border-bottom-right-radius:5px;border-top-left-radius:5px; border-top-right-radius:5px;"  
                Text="WELCOME TO THE STOCK MARKET QUOTE PAGE!!!" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            </div>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <div id="cen" align="center">
            <asp:Label ID="lbl_sgn_up" runat="server" style="background-color:darkorange" Text="Sign Up For Memebership Here:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <br/> 
            <asp:Label ID="Label1" runat="server" style="background-color:darkorange" Text="All fields with * next to them required. Blank is not allowed for username or password." BorderColor="Yellow" BorderStyle="Solid"></asp:Label>    
            <span style="display:block; height: 26px; width: 50px;"></span>
            <asp:Label ID="Label2" runat="server" style="background-color:darkorange" Text="Username:" BorderColor="Yellow" BorderStyle="Solid" Width="192px"></asp:Label>
            <asp:TextBox ID="txt_username" runat="server" Width="220px"  ></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="background-color:darkorange" Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_username_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="Label4" runat="server" style="background-color:darkorange" Text="Password:" BorderColor="Yellow" BorderStyle="Solid" Width="192px"></asp:Label>
            <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="Label5" runat="server" style="background-color:darkorange" Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_pass_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="Label6" runat="server" style="background-color:darkorange" Text="Confirm Password:" BorderColor="Yellow" BorderStyle="Solid" Width="192px"></asp:Label>
            <asp:TextBox ID="txt_pass_cnfrm" runat="server" TextMode="Password" Width="220px"  ></asp:TextBox>
            <asp:Label ID="Label7" runat="server" style="background-color:darkorange" Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lbl_pass_cnfrm_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <user:captcha ID="capTable" runat="server" />
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:Label ID="Label8" runat="server" style="background-color:darkorange" Text="Enter verify string here:" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <asp:TextBox ID="txt_img_string" runat="server" Width="133px"  ></asp:TextBox>
            <asp:Label ID="Label9" runat="server" style="background-color:darkorange" Text="*" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
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
