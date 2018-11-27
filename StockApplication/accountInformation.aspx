<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accountInformation.aspx.cs" Inherits="StockApplication.accountInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Information</title>
    <style type="text/css">
        body {
            background-image: url('background_img.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
            background-position: center;
        }
    </style>
    <style type="text/css">
        #lbl_logged_in {
            background-color: darkorange;
            border-bottom-left-radius: 5px;
            border-bottom-right-radius: 5px;
            border-top-left-radius: 5px;
            border-top-right-radius: 5px;
            font-size: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" runat="server" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            

            <div id="links" align="right">
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Log Out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stocks"  runat="server" Text="Back To Stocks"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stocks_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srvc_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srvc_dir_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Features"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_ftrs_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stf_login"  runat="server" Text="Staff Page"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stf_login_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            </div>

            <div align="center">
            <asp:Label ID="lbl_title"  runat="server" Text="Account Information Page:"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid"  ></asp:Label>
            <span style="display:block; height: 26px; width: 50px;"></span>
            <asp:Label ID="lbl_email"  runat="server" Text="Username:"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid"  ></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="txt_email" Text="username" runat="server" Width="220px" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 15px; width: 50px;"></span>
            <asp:Label ID="lbl_pass"  runat="server" Text="Password:"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid"  ></asp:Label>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="txt_pass" Text="********" runat="server" Width="220px" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 23px; width: 50px;"></span>
            </div>

        </div>
    </form>
</body>
</html>
