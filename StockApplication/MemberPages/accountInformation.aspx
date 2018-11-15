<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accountInformation.aspx.cs" Inherits="StockApplication.MemberPages.accountInformation" %>

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
    <style type="text/css">
        #lbl_logged_in {
            height: 807px;
            background-color:blueviolet;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

           <div align="center">
            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" Text="" runat="server" ></asp:Label>
            <span style="display:block; height: 100px; width: 50px;"></span>
            Account Information Page:
            <span style="display:block; height: 26px; width: 50px;"></span>
            Email Address:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="txt_email" Text="USER EMAIL" runat="server" Width="220px"  ></asp:Label>
            <span style="display:block; height: 15px; width: 50px;"></span>
            Password:
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:Label ID="txt_pass" Text="********" runat="server" Width="220px"  ></asp:Label>
            <span style="display:block; height: 23px; width: 50px;"></span>
            </div>

        </div>
    </form>
</body>
</html>
