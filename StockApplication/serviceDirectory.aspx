<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceDirectory.aspx.cs" Inherits="StockApplication.PublicPages.serviceDirectory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Service Directory</title>
    <style type="text/css">
        #main {
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
<body id="main">
    <form id="form1" runat="server">
        <div>

            <span style="display:block; height: 10px; width: 10px;"></span>
            <span style="display:inline-block; width:10px;"></span>
            <asp:Label ID="lbl_logged_in" runat="server" Visible ="false" BorderColor="Yellow" BorderStyle="Solid" ></asp:Label>

            <div id="links" align="right">
            <span style="display:block; height: 30px; width: 50px;"></span>
            <asp:LinkButton ID="btn_sign_up"  runat="server" Text="Create Account" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_sign_up_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_mber_login"  runat="server" Text="Member Log In"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_mber_login_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stf_login"  runat="server" Text="Staff Page"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stf_login_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_ftrs"  runat="server" Text="Member Features"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_ftrs_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 5px; width: 50px;"></span>
            <asp:LinkButton ID="btn_logout"  runat="server" Text="Member Log out" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_logout_Click" ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_stocks"  runat="server" Text="Stocks"  style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_stocks_Click"  ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            <asp:LinkButton ID="btn_account"  runat="server" Text="Account Info" style="background-color:darkorange"  BorderColor="Yellow" BorderStyle="Solid" OnClick="btn_account_Click"   ></asp:LinkButton>
            <span style="display:inline-block; width:50px;"></span>
            <span style="display:block; height: 2px; width: 50px;"></span>
            </div>

            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label37" Font-Size="24px" runat="server" style="background-color:darkorange" Text="Service Directory:"></asp:Label>
            <span style="display:block; height: 25px; width: 10px;"></span>


            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label1" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Component Type: Web service"></asp:Label> 
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label2" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Service Provider: Curtis Green"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label3" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Operation Name: Stock Quote Service"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label4" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Description: Retrieves stats for a given stock symbol "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label17" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Parameters: Stock symbol a string "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label18" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Tryit Link:"></asp:Label>
            <a href="http://webstrar42.fulton.asu.edu/page1/default.aspx">This website</a>
            <asp:Label ID="Label38" Font-Size="18px" runat="server" style="background-color:darkorange" Text="create an account or log in to try anything"></asp:Label>
            <span style="display:block; height: 25px; width: 10px;"></span>



            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label5" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Component Type: Global.asax"></asp:Label> 
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label6" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Service Provider: Curtis Green"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label7" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Operation Name: TODO"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label8" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Description: TODO "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label19" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Parameters: TODO "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label20" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Tryit Link: TODO "></asp:Label>  
            <span style="display:block; height: 25px; width: 10px;"></span>


            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label9" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Component Type: DLL"></asp:Label> 
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label10" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Service Provider: Curtis Green"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label11" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Operation Name: EncryptDecrypt Class"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label12" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Description: encrypts the passwords using C# AES library, then writes to XML"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label21" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Parameters: username and password "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label22" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Tryit Link: login page or create account page "></asp:Label>  
            <span style="display:block; height: 25px; width: 10px;"></span>


            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label13" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Component Type: Cookies"></asp:Label> 
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label14" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Service Provider: Curtis Green"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label15" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Operation Name: Cookies"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label16" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Description: store username "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label23" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Parameters: username "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label24" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Tryit Link: login page "></asp:Label>  
            <span style="display:block; height: 25px; width: 10px;"></span>


            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label25" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Component Type: User Contorl"></asp:Label> 
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label26" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Service Provider: Curtis Green"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label27" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Operation Name: captcha.ascx"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label28" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Description: generates image to verify person creates account is truly human. "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label29" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Parameters: verify string "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label30" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Tryit Link: create account page "></asp:Label>  
            <span style="display:block; height: 25px; width: 10px;"></span>



            <span style="display:block; height: 25px; width: 10px;"></span>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label31" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Component Type: XML file manipulation"></asp:Label> 
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label32" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Service Provider: Curtis Green"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label33" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Operation Name: Two methods located in the EncryptDecrypt class: writeXml / readXML"></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label34" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Description: Used along side the encryption methods when creating accounts or logging in. "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label35" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Parameters: username / password / staff "></asp:Label>  
            </br>
            <span style="display:inline-block; width:50px;"></span>
            <asp:Label ID="Label36" Font-Size="18px" runat="server" style="background-color:darkorange" Text="Tryit Link: login page / create account page "></asp:Label>  
            <span style="display:block; height: 25px; width: 10px;"></span>



        </div>
    </form>
</body>
</html>
