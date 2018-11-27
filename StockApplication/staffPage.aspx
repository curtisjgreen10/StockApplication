<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staffPage.aspx.cs" Inherits="StockApplication.staffPage" %>
<link rel="stylesheet" runat="server" media="screen" href="staffPage.css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" runat="server" Visible ="true" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>

            <div id="links" align="right">
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Features"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_ftrs_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srv_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srv_dir_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Log out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stocks"  runat="server" Text="Stocks"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stocks_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_account"  runat="server" Text="Account Info" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_account_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            </div>



            <div align="center">
            <asp:Label ID="lbl_add_staff" runat="server"  Text="Staff Add Page" BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <span style="display:block; height: 26px; width: 50px;"></span>
            <asp:Label ID="lbl_username" runat="server"  Text="Username" BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <asp:TextBox ID="txt_username" runat="server" Width="220px"  ></asp:TextBox>
            <span style="display:block; height: 15px; width: 50px;"></span>
            <asp:Label ID="lbl_pass" runat="server"  Text="Password"  BorderColor="Yellow" BorderStyle="Solid"></asp:Label> 
            <asp:TextBox ID="txt_pass" runat="server" Width="220px"  TextMode="Password" ></asp:TextBox>
            <span style="display:block; height: 23px; width: 50px;"></span>
            <asp:Button ID="btn_add"  runat="server" Text="Add Staff Member"  Height="44px" Width="139px" OnClick="btn_add_Click"  ></asp:Button>
            <span style="display:block; height: 51px; width: 50px;"></span>
            </div>

            <div>
            <span style="display:inline-block; width:75px;"></span>
            <asp:Button ID="btn_staff_query"  runat="server" Text="Query Staff Member List"  Height="44px" Width="185px" OnClick="btn_staff_query_Click"  ></asp:Button>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <span style="display:inline-block; width:75px;"></span>
            <asp:ListBox id="lst_staf_users" style="Z-INDEX: 101; LEFT: 301px; OVERFLOW:scroll;  TOP: 286px; " runat="server" TextMode="MultiLine" Height="321px" Width="182px" ></asp:ListBox>
            </div>


    </form>
</body>
</html>
