﻿using System;
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
            //check if username is taken
            string[] usrNmChk = EncryptDecypt.readXml(txt_username.Text, false);
            if (usrNmChk != null && !usrNmChk[0].Equals("FILE NOT FOUND"))
            {
                //username was found in file
                lbl_username_error.Text = "Username taken, please choose again";
                txt_username.Text = "";
                return;
            }

            if (!Session["generatedString"].Equals(txt_img_string.Text))
            {
                return;
            }

            //no errors so sign member up
            signup();
        }

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

            using (aesAlg)
            {
                encrypted = EncryptDecypt.EncryptStringToBytes_Aes(txt_pass.Text, aesAlg.Key, aesAlg.IV);
            }

            //encrypted text - password
            for (i = 0; i < encrypted.Length - 1; i++)
            {
                strEncrypted += encrypted[i].ToString() + ",";
            }
            strEncrypted += encrypted[i].ToString();
            data[1] = strEncrypted;

            EncryptDecypt.writeXml(data, false);
            //Access member page if everything worked
            Response.Redirect("~/MemberPages/memberPage.aspx");
        }

        protected void btn_srvc_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/serviceDirectory.aspx");
        }

        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/features.aspx");
        }
    }
}