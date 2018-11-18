<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="memberPage.aspx.cs" Inherits="StockApplication.MemberPages._default" %>
<link rel="stylesheet" runat="server" media="screen" href="memberPage.css" />

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Mainpage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" runat="server" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>

            <div id="links" align="right">
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Member Log Out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_account"  runat="server" Text="Account Info"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_account_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srvc_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srvc_dir_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Member Features"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_ftrs_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 10px; width: 50px;"></span>
            </div>


            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="lbl_title" Text="Stock Quote Service:" runat="server" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="lbl_enter_stock" Text="Enter the Symbol of Stock you would like the quote for." runat="server" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:49px;"></span>
            <asp:Label ID="lbl_symbol" Text="Symbol:" runat="server" Width="70px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:inline-block; width:24px;"></span>
            <asp:TextBox ID="txt_symbol" runat="server" Width="200px" Height="16px"></asp:TextBox>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="lbl_open" Text="Open:" runat="server" Width="70px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:inline-block; width:30px;"></span>
            <asp:Label ID="lbl_open_price" runat="server" ReadOnly="True" Width="100px" Height="16px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="lbl_high" Text="High:" runat="server" Width="70px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:inline-block; width:30px;"></span>
            <asp:Label ID="lbl_high_price" runat="server" ReadOnly="True" Width="100px" Height="16px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="lbl_low" Text="Low:" runat="server" Width="70px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:inline-block; width:30px;"></span>
            <asp:Label ID="lbl_low_price" runat="server" ReadOnly="True" Width="100px" Height="16px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="lbl_close" Text="Close:" runat="server" Width="70px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:inline-block; width:30px;"></span>
            <asp:Label ID="lbl_close_price" runat="server" ReadOnly="True" Width="100px" Height="16px" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:155px;"></span>
            <asp:Button ID="btn_go"  runat="server" Text="Get Quote" OnClick="btn_go_Click" ></asp:Button>
            <span style="display:block; height: 30px; width: 50px;"></span>
        </div>
    </form>
</body>
</html>
