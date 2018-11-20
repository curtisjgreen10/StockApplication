using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Security.Cryptography;
using System.Threading;

namespace StockApplication.StaffPages
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_success.Visible = false;
            btn_logout.Visible = false;
            lbl_logged_in.Visible = false;
            btn_account.Visible = false;
            btn_stocks.Visible = false;
            if (Session["username"] != null)
            {
                btn_account.Visible = true;
                btn_stocks.Visible = true;
                btn_srv_dir.Visible = true;
                btn_ftrs.Visible = true;
                btn_logout.Visible = true;
                lbl_logged_in.Visible = true;
                lbl_logged_in.Text = "Logged in as staff: " + (string)Session["username"];
            }
        }


        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/features.aspx");
        }

        protected void btn_srv_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/serviceDirectory.aspx");
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["staff"] = null;
            Session["username"] = null;
            Response.Redirect("~/login.aspx");
        }

        protected void btn_stocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/memberPage.aspx");
        }

        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/accountInformation.aspx");
        }

        protected void btn_add_Click(object sender, EventArgs e)
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

            EncryptDecypt.writeXml(data, true);
            
            lbl_success.Visible = true;
            
        }
    }
}