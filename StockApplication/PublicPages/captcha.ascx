<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="captcha.ascx.cs" Inherits="StockApplication.PublicPages.captcha" %>


<table id="capTable" cellpadding="4" RunAt="server">
    <tr> 
            <td></td>
            <td><asp:Image ID="image_vfy" RunAt="server" /></td>
            <td><asp:Button ID="btn_show" Text="Show different image" RunAt="server" OnClick="btn_show_Click" Width="148px" /></td>
	</tr>
    <tr>
            <td><asp:Label ID="lbl_img_len" style="background-color:darkorange" Text="Image string length is: " RunAt="server" /></td>
            <td><asp:TextBox ID="txt_img_len"  RunAt="server" Width="55px" />  </td>
            <td><asp:Label ID="Label1" style="background-color:darkorange" Text="Only enter a number in here if you would like a new" RunAt="server" /></td>
        
    </tr>
    <tr>
            <td></td>
            <td></td>
            <td><asp:Label ID="Label2" style="background-color:darkorange" Text="verify string, then click Show different image" RunAt="server" />"</td>
        
    </tr>
 </table>
