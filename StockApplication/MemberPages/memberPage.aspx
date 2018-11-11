﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="memberPage.aspx.cs" Inherits="StockApplication.MemberPages._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            Stock Quote Service:
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            Enter the Symbol of Stock you would like the quote for.
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:49px;"></span>
            Symbol:
            <span style="display:inline-block; width:24px;"></span>
            <asp:TextBox ID="txt_symbol" runat="server" Width="221px" Height="16px"></asp:TextBox>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            Open:
            <span style="display:inline-block; width:34px;"></span>
            <asp:TextBox ID="txt_open" runat="server" ReadOnly="True" Width="221px" Height="16px" ></asp:TextBox>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            High:
            <span style="display:inline-block; width:40px;"></span>
            <asp:TextBox ID="txt_high" runat="server" ReadOnly="True" Width="221px" Height="16px" ></asp:TextBox>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            Low:
            <span style="display:inline-block; width:36px;"></span>
            <asp:TextBox ID="txt_low" runat="server" ReadOnly="True" Width="221px" Height="16px" ></asp:TextBox>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            Close:
            <span style="display:inline-block; width:28px;"></span>
            <asp:TextBox ID="txt_close" runat="server" ReadOnly="True" Width="221px" Height="16px" ></asp:TextBox>
            <span style="display:block; height: 30px; width: 50px;"></span>
            <span style="display:inline-block; width:155px;"></span>
            <asp:Button ID="btn_go"  runat="server" Text="Get Quote" OnClick="btn_go_Click" ></asp:Button>
            <span style="display:block; height: 30px; width: 50px;"></span>
        </div>
    </form>
</body>
</html>
