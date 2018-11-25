using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptDecrypt;
using System.Security.Cryptography;
using System.Threading;

namespace StockApplication.page3
{
    public partial class _default : System.Web.UI.Page
    {
        /// <summary>
        /// Event handler for account staff page load. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_success.Visible = false;
            // check to make sure that the user is logged in and a staff member before loading this page.
            if (Session["username"] != null && (bool)Session["staff"] == true)
            {
                lbl_logged_in.Text = "Logged in as staff: " + (string)Session["username"];
            }
            else
            {
                //there is no staff member logged in and this page is trying to be loaded so re-direct
                Response.Redirect("/login.aspx");
            }
        }

        /// <summary>
        /// Event handler for features button. Re-direct to features page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("/features.aspx");
        }

        /// <summary>
        /// Event handler for service directory button. Re-direct to service directory page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_srv_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/serviceDirectory.aspx");
        }

        /// <summary>
        /// Event handler for logout button. Clear session variables. Re-direct to login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["staff"] = null;
            Session["username"] = null;
            Response.Redirect("/login.aspx");
        }

        /// <summary>
        /// Event handler for stocks button. Re-direct to stocks page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_stocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("/page2/memberPage.aspx");
        }

        /// <summary>
        /// Event handler for account button. Re-direct to account page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("/page2/accountInformation.aspx");
        }

        /// <summary>
        /// Event handler to add staff members to the staff.xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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