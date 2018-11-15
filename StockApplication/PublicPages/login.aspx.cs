using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Security.Cryptography;



namespace StockApplication.PublicPages
{
    public partial class login : System.Web.UI.Page
    {
        //static string username;

        protected void Page_Load(object sender, EventArgs e)
        {
            //clear any lingering error messages
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            btn_not_you.Visible = false;
            //perform cookie logic
            if ((Request.Cookies["authcookie"] == null) || (Request.Cookies["authcookie"].Equals("")))
            {
                lbl_usrname.Text = "Welcome, new user";
            }
            else
            {
                btn_not_you.Visible = true;
                lbl_usrname.Text = "Welcome, " + Request.Cookies["authcookie"]["username"];
                txt_username.Text = Request.Cookies["authcookie"]["username"];
            }
        }

        protected void btn_mber_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_pass.Text;
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            if (username == null || username == "")
            {
                lbl_username_error.Text = "username is empty!";
                return;
            }

            if (password == null || password == "")
            {
                lbl_pass_error.Text = "Password is empty!";
                return;
            }

            //check if credentials are correct
            string[] passWrdChk = EncryptDecypt.readXml(username, false);
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
                    if (chk_stay_logged_in.Checked)
                    {
                        //create user cookie
                        Response.Cookies["authcookie"]["username"] = username;
                        Response.Cookies["authcookie"].Expires = DateTime.Now.AddMonths(6);
                    }
                    //create user session
                    Session["username"] = username;
                    //Access member page if everything worked
                    Response.Redirect("~/MemberPages/memberPage.aspx");
                }
                else
                {
                    lbl_pass_error.Text = "Incorrect password, please try again.";
                    txt_pass.Text = "";
                }
            }
        }

        protected void btn_not_you_Click(object sender, EventArgs e)
        {
            //clear everything
            txt_username.Text = "";
            txt_pass.Text = "";
            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            lbl_usrname.Text = "Welcome, new user";
            btn_not_you.Visible = false;
        }
    }
}