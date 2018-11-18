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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="links" align="right">
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:LinkButton ID="btn_sign_up"  runat="server" Text="Create Account" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_sign_up_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_mber_login"  runat="server" Text="Member Log In"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_mber_login_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stf_login"  runat="server" Text="Staff Log In"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stf_login_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_srv_dir"  runat="server" Text="Service Directory"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_srv_dir_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 10px; width: 50px;"></span>
            </div>

            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label37" Font-Size="24px" runat="server" style="background-color:darkorange" Text="Member Features:"></asp:Label>
            <span style="display:block; height: 25px; width: 10px;"></span>

            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label1" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Feature here"></asp:Label> 
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label2" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Feature here"></asp:Label>  
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
