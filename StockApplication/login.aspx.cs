using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Security.Cryptography;



namespace StockApplication
{
    public partial class login : System.Web.UI.Page
    {
        string username;

        /// <summary>
        /// Event handler for login page load. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear any lingering error messages
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            btn_not_you.Visible = false;
            btn_logout.Visible = false;
            lbl_logged_in.Visible = false;

            //check if user is already logged in
            if (Session["username"] != null)
            {
                btn_sign_up.Visible = false;
                btn_logout.Visible = true;
                lbl_logged_in.Visible = true;
                lbl_logged_in.Text = "Logged in as: " + (string)Session["username"];
            }


            //perform cookie logic
            if (Request.Cookies["authcookie"] == null)
            {
                lbl_usrname.Text = "Welcome, new user";
                username = null;
            }
            else
            {
                lbl_remember.Visible = false;
                chk_remember.Visible = false;
                btn_not_you.Visible = true;
                lbl_usrname.Text = "Welcome, " + Request.Cookies["authcookie"]["username"];
                username = txt_username.Text;
                txt_username.Text = Request.Cookies["authcookie"]["username"];
            }
        }

        /// <summary>
        /// Event handler for a login click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_mber_login_Click(object sender, EventArgs e)
        {
            // check if the username has been set by the cookie logic. 
            if (username == null)
            {
               username = txt_username.Text;
            }
            string password = txt_pass.Text;
            // clear errors
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            // check if username is empty
            if (username == null || username == "")
            {
                lbl_username_error.Text = "username is empty!";
                return;
            }
            // check if password is empty
            if (password == null || password == "")
            {
                lbl_pass_error.Text = "Password is empty!";
                return;
            }
            //check if credentials are correct
            string[] passWrdChk = EncryptDecypt.readXml(username, chk_staff.Checked);
            if (passWrdChk == null || passWrdChk[0].Equals("FILE NOT FOUND"))
            {
                lbl_username_error.Text = "Username not found or incorrect, please try again";
                txt_username.Text = "";
                return;
            }
            else
            {
                string[] encryptedPass = passWrdChk[0].Split(',');
                byte[] encryptedBytes = new byte[encryptedPass.Length];
                for (int i = 0; i < encryptedPass.Length; i++)
                {
                    encryptedBytes[i] = Convert.ToByte(encryptedPass[i]);
                }

                string[] strKey = passWrdChk[1].Split(',');
                byte[] keyBytes = new byte[strKey.Length];
                for (int i = 0; i < strKey.Length; i++)
                {
                    keyBytes[i] = Convert.ToByte(strKey[i]);
                }

                string[] strIV = passWrdChk[2].Split(',');
                byte[] ivBytes = new byte[strIV.Length];
                for (int i = 0; i < strIV.Length; i++)
                {
                    ivBytes[i] = Convert.ToByte(strIV[i]);
                }

                string decryptedPass = "";
                Aes aesAlg;
                using (aesAlg = Aes.Create())
                {
                    decryptedPass = EncryptDecypt.DecryptStringFromBytes_Aes(encryptedBytes, keyBytes, ivBytes);
                }

                if (password.Equals(decryptedPass))
                {
                    if (chk_remember.Checked)
                    {
                        //create user cookie
                        Response.Cookies["authcookie"]["username"] = username;
                        Response.Cookies["authcookie"].Expires = DateTime.Now.AddMonths(6);
                    }
                    //create user session
                    Session["username"] = username;

                    //staff session?
                    if (chk_staff.Checked)
                    {
                        Session["staff"] = true;
                    }
                    else
                    {
                        Session["staff"] = false;
                    }
                    //Access member page if everything worked
                    Response.Redirect("~/stockPage.aspx");
                }
                else
                {
                    lbl_pass_error.Text = "Incorrect password, please try again.";
                    txt_pass.Text = "";
                }
            }
        }

        /// <summary>
        /// Event handler to manualy clear the cookies if you are not the user logging in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_not_you_Click(object sender, EventArgs e)
        {
            //clear and reset everything
            lbl_remember.Visible = true;
            chk_remember.Visible = true;
            txt_username.Text = "";
            txt_pass.Text = "";
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            lbl_usrname.Text = "Welcome, new user";
            btn_not_you.Visible = false;
            Response.Cookies["authcookie"].Expires = DateTime.Now.AddDays(-1);
        }

        /// <summary>
        /// Event handler for create account button. Re-direct to create account (default) page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_sign_up_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
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
        /// Event handler for logout button. Clear session variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["staff"] = null;
            Session["username"] = null;
            btn_logout.Visible = false;
            btn_sign_up.Visible = true;
            lbl_logged_in.Visible = false;
        }
    }
}