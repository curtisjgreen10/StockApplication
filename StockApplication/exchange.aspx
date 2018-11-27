<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exchange.aspx.cs" Inherits="StockApplication.exchange" %>
<link rel="stylesheet" runat="server" media="screen" href="exchange.css" />
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exchange</title>
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
            <asp:LinkButton ID="btn_account"  runat="server" Text="Account Info"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_account_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stocks"  runat="server" Text="Stocks"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stocks_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srvc_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srvc_dir_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Features"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_ftrs_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stf_login"  runat="server" Text="Staff Page"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stf_login_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            </div>
            <div align="center" style="height: 748px">
            <asp:Label ID="lbl_title" runat="server"  Text="Currency Exchange Rate Page" BorderColor="Yellow" BorderStyle="Solid"></asp:Label>
            <span style="display:block; height: 75px; width: 50px;"></span>
            <asp:Label ID="lbl_from" runat="server"  Text="From" BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <span style="display:inline-block; width:260px;"></span>
            <asp:Label ID="lbl_to" runat="server"  Text="To" BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <span style="display:block; height: 10px; width: 50px;"></span>
            <asp:Label ID="lbl_dollar_from" runat="server"  Text="$" BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <asp:TextBox ID="txt_from_amt" runat="server"   BorderColor="Yellow" BorderStyle="Solid"></asp:TextBox>
            <asp:Label ID="lbl_from_error" runat="server" ForeColor="Red" Text=""></asp:Label>
            <span style="display:block; height: 10px; width: 50px;"></span>
            <asp:DropDownList id="cb_from_symbol"  Width="250px" runat="server" ></asp:DropDownList>
            <span style="display:inline-block; width:100px;"></span>
            <asp:DropDownList id="cb_to_symbol"   Width="250px" runat="server" ></asp:DropDownList>
            <span style="display:block; height: 41px; width: 50px;"></span>
            <asp:Button ID="btn_calculate" Font-Size="24px"  runat="server" Text="Calculate"  Height="44px" Width="139px" OnClick="btn_calculate_Click" ></asp:Button>
            <span style="display:block; height: 38px; width: 50px;"></span>
            <asp:Label ID="lbl_result" runat="server"  Text="Result" BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <asp:TextBox ID="txt_result" runat="server"   BorderColor="Yellow" BorderStyle="Solid"></asp:TextBox> 
            </div>
        </div>
    </form>
</body>
</html>
