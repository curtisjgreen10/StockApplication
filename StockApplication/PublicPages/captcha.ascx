<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="captcha.ascx.cs" Inherits="StockApplication.PublicPages.captcha" %>

    <style type="text/css">
        #capTable {
            background-color:blueviolet;
            color:white;
        }
    </style>

<table id="capTable" cellpadding="4" RunAt="server">
    <tr> 
            <td>Image:</td>
            <td><asp:Image ID="image_vfy" RunAt="server" /></td>
            <td><asp:Button ID="btn_show" Text="Show Image" RunAt="server" OnClick="btn_show_Click" /></td>
	</tr>
    <tr>
            <td><asp:Label ID="lbl_img_len" Text="Image string length is: " RunAt="server" /></td>
            <td><asp:TextBox ID="txt_img_len"  RunAt="server" />  </td>
    </tr>
    <tr>	
            <td>Enter image string:</td> 
            <td><asp:TextBox ID="txt_img_string"  RunAt="server" /> </td>
  	</tr>
  	<tr> 
           <td></td> <td><asp:Button ID="btn_verify" Text="Verify" RunAt="server" Width="128px" OnClick="btn_verify_Click" /></td>
           <td><asp:Label ID="lbl_msg"  RunAt="server" /></td>
  	</tr>
 </table>
