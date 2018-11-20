<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="features.aspx.cs" Inherits="StockApplication.PublicPages.features" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            background-image:url('background_img.jpg');
            background-repeat:no-repeat;
            background-attachment:fixed;
            background-size:cover;
            background-position:center;
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
            <asp:Label ID="lbl_logged_in" runat="server" Visible ="false" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>

            <div id="links" align="right">
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:LinkButton ID="btn_sign_up"  runat="server" Text="Create Account" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_sign_up_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_mber_login"  runat="server" Text="Member Log In"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_mber_login_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stf_login"  runat="server" Text="Staff Page"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stf_login_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srv_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srv_dir_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Member Log out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stocks"  runat="server" Text="Stocks"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stocks_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_account"  runat="server" Text="Account Info" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_account_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            </div>

            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label37" Font-Size="24px" runat="server" style="background-color:darkorange" Text="Member Features:"></asp:Label>
            <span style="display:block; height: 25px; width: 10px;"></span>

            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label1" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Request a stock quote"></asp:Label> 
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label2" Font-Size="18px" runat="server" style="background-color:darkorange" Text="More features to come"></asp:Label>  
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label3" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Feature here"></asp:Label>  
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label4" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Feature here "></asp:Label>  
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label17" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Feature here"></asp:Label>  
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label18" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Feature here "></asp:Label>  
            <span style="display:block; height: 25px; width: 10px;"></span>


        </div>
    </form>
</body>
</html>
