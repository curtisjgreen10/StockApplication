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

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            btn_not_you.Visible = false;
            HttpCookie myCookies = Request.Cookies[txt_username.Text];
            if ((myCookies == null) || (myCookies["Name"] == ""))
            {
                lbl_usrname.Text = "Welcome, new user";
            }
            else
            {
                btn_not_you.Visible = true;
                lbl_usrname.Text = "Welcome, " + myCookies["Name"];
                txt_username.Text = myCookies["Name"];
            }
            */
        }

        protected void btn_mber_login_Click(object sender, EventArgs e)
        {

            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            if (txt_username.Text == null || txt_username.Text == "")
            {
                lbl_username_error.Text = "username is empty!";
                return;
            }

            if (txt_pass.Text == null || txt_pass.Text == "")
            {
                lbl_pass_error.Text = "Password is empty!";
                return;
            }

            //check if credentials are correct
            string[] passWrdChk = EncryptDecypt.readXml(txt_username.Text, false);
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

                if (txt_pass.Text.Equals(decryptedPass))
                {
                    //add username to after login
                    /*
                    HttpCookie myCookies = new HttpCookie(txt_username.Text);
                    myCookies["UserName"] = txt_username.Text;
                    myCookies.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Add(myCookies);
                    */
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
            txt_username.Text = "";
            txt_pass.Text = "";
            lbl_usrname.Text = "Welcome, new user";
            btn_not_you.Visible = false;
        }
    }
}