using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Security.Cryptography;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Linq;

namespace StockApplication
{
    public partial class _default : System.Web.UI.Page
    {
        /// <summary>
        /// Event handler for default page load. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_logout.Visible = false;
            lbl_logged_in.Visible = false;
            //check if a user is already logged in
            if (Session["username"] != null)
            {
                btn_login.Visible = false;
                btn_logout.Visible = true;
                lbl_logged_in.Visible = true;
                lbl_logged_in.Text = "Logged in as: " + (string)Session["username"];
            }
        }

        /// <summary>
        /// Event handler for login button. re-direct to login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_login_Click(object sender, EventArgs e)
        {
            //Show login page 
            Response.Redirect("~/login.aspx");
        }

        /// <summary>
        /// Event handler for signup button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_signup_Click(object sender, EventArgs e)
        {
            // clear all error labels
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            lbl_pass_cnfrm_error.Text = "";
            lbl_captcha_error.Text = "";
            // check if username field is blank
            if (txt_username.Text == null || txt_username.Text == "")
            {
                lbl_username_error.Text = "Email is empty!";
                return;
            }
            // check if password is blank
            if (txt_pass.Text == null || txt_pass.Text == "")
            {
                lbl_pass_error.Text = "Password is empty!";
                return;
            }
            // check if passwords match
            if (!txt_pass.Text.Equals(txt_pass_cnfrm.Text))
            {
                lbl_pass_error.Text = "Passwords do not match!";
                lbl_pass_cnfrm_error.Text = "Passwords do not match!";
                return;
            }
            // check if username is taken
            string[] usrNmChk = EncryptDecypt.readXml(txt_username.Text, false);
            if (usrNmChk != null && !usrNmChk[0].Equals("FILE NOT FOUND"))
            {
                // username was found in file
                lbl_username_error.Text = "Username taken, please choose again";
                txt_username.Text = "";
                return;
            }
            // check captcha string
            if (!Session["generatedString"].Equals(txt_img_string.Text))
            {
                lbl_captcha_error.Text = "Incorrect verify string, try again.";
                return;
            }

            //no errors so sign member up
            signup();
        }

        /// <summary>
        /// Helper method to sign members up. Writes information to XML.
        /// Called upon correct user input of account creation.
        /// </summary>
        private void signup()
        {
            int i;
            string[] data = new string[4];
            byte[] encrypted;
            string strEncrypted = "";
            string key = "";
            string iv = "";
            data[0] = txt_username.Text;
            Aes aesAlg = Aes.Create();

            // store key for de-cryption
            for (i = 0; i < aesAlg.Key.Length - 1; i++)
            {
                key += aesAlg.Key[i].ToString() + ",";
            }
            key += aesAlg.Key[i].ToString();
            data[2] = key;

            // store iv for de-cryption
            for (i = 0; i < aesAlg.IV.Length - 1; i++)
            {
                iv += aesAlg.IV[i].ToString() + ",";
            }
            iv += aesAlg.IV[i].ToString();
            data[3] = iv;

            // Encrypt
            using (aesAlg)
            {
                encrypted = EncryptDecypt.EncryptStringToBytes_Aes(txt_pass.Text, aesAlg.Key, aesAlg.IV);
            }

            // encrypted text - password
            for (i = 0; i < encrypted.Length - 1; i++)
            {
                strEncrypted += encrypted[i].ToString() + ",";
            }
            strEncrypted += encrypted[i].ToString();
            data[1] = strEncrypted;

            EncryptDecypt.writeXml(data, false);
            Session["username"] = data[0];
            Session["staff"] = false;
            Response.Redirect("~/stockPage.aspx");
        }

        /// <summary>
        /// Event handler for service directory button. Re-direct to service directory page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_srvc_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/serviceDirectory.aspx");
        }

        /// <summary>
        /// Event handler for features button. Re-direct to features page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/features.aspx");
        }

        /// <summary>
        /// Event handler for logout button. Clear session variable. Re-direct to login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            btn_logout.Visible = false;
            btn_login.Visible = true;
            lbl_logged_in.Visible = false;
        }

        /// <summary>
        /// Event handler for stocks button. Re-direct to stocks page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_stocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/stockPage.aspx");
        }

        /// <summary>
        /// Event handler for account button. Re-direct to account page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/accountInformation.aspx");
        }
    }
}