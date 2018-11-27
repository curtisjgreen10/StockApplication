using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockApplication
{
    public partial class accountInformation : System.Web.UI.Page
    {
        /// <summary>
        /// Event handler for account information page load. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            //first check if anybody is loged in.
            if (Session["username"] != null)
            {
                txt_email.Text = (string)Session["username"];
                //then check how they are logged in - staff or normal member.
                if ((bool)Session["staff"] == true)
                {
                    btn_stf_login.Visible = true;
                    lbl_logged_in.Text = "Logged in as staff: " + (string)Session["username"];
                }
                else
                {
                    lbl_logged_in.Text = "Logged in as: " + (string)Session["username"];
                }
            }
            else
            {
                //if session is null this page is trying to be loaded with no login so re-direct
                Response.Redirect("~/login.aspx");
            }
        }

        /// <summary>
        /// Event handler for logout button. Clear session variables. Re-direct to login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            Session["username"] = null;
            Session["staff"] = null;
            Response.Redirect("~/login.aspx");
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
        /// Event handler for staff page. Re-direct to staff page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/staffPage.aspx");
        }
    }
}