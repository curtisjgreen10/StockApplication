using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Security.Cryptography;
using System.IO;

namespace StockApplication.PublicPages
{
    public partial class _default : System.Web.UI.Page
    {
        


        protected void btn_login_Click(object sender, EventArgs e)
        {
            //Show login page 
            Response.Redirect("~/PublicPages/login.aspx");
        }

        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            //re-derict staff somewhere?
            //Response.Redirect("");
        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            lbl_pass_cnfrm_error.Text = "";
            if (txt_username.Text == null || txt_username.Text == "")
            {
                lbl_username_error.Text = "Email is empty!";
                return;
            }

            if (!txt_pass.Text.Equals(txt_pass_cnfrm.Text))
            {
                lbl_pass_error.Text = "Passwords do not match!";
                lbl_pass_cnfrm_error.Text = "Passwords do not match!";
                return;
            }

            byte[] encrypted;
            string strEncrypted = "";
            using (Aes myAes = Aes.Create())
            {
                encrypted = EncryptDecypt.EncryptStringToBytes_Aes(txt_pass.Text, myAes.Key, myAes.IV);
            }
            for (int i = 0; i < encrypted.Length; i++)
            {
                strEncrypted += encrypted[i].ToString() + ",";
            }

            /*******************************************/
            //TODO Add strEncrypted and username to Member.xml here for component 'e' of part 2.
            //Since we are adding information from this event handler we know this a normal member not staff.
            //This can work like a key value pair. Key->username:Value->password, since the username is not encrypted.
            /*******************************************/

            //Access member page if everything worked
            Response.Redirect("~/MemberPages/memberPage.aspx");
        }

        protected void btn_svrc_dir_Click(object sender, EventArgs e)
        {
            //Show service directory
            Response.Redirect("~/PublicPages/serviceDirectory.aspx");
        }
    }
}