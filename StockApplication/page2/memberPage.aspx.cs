using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockApplication.MemberPages
{
    public partial class _default : System.Web.UI.Page
    {
        //create proxy for web service
        StockService.StockServiceClient proxy = new StockService.StockServiceClient();

        /// <summary>
        /// Event handler for account stock (member) page load. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            //first check if anybody is loged in.
            if (Session["username"] != null)
            {
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
                Response.Redirect("/login.aspx");
            }
        }

        /// <summary>
        /// Event handler for get stock quote. Uses proxy to access we service.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_go_Click(object sender, EventArgs e)
        {
            try
            {
                //method call through proxy
                proxy.StockBuild("does not matter");
                string data = proxy.StockQuote(txt_symbol.Text);
                string[] stats = data.Split(',');
                lbl_open_price.Text = "$" + stats[0];
                lbl_high_price.Text = "$" + stats[1];
                lbl_low_price.Text = "$" + stats[2];
                lbl_close_price.Text = "$" + stats[3];
            }
            catch (Exception ex)
            {
                //display any exception messages in txt_open text box
                lbl_open_price.Text = "no data or invalid stock or other error";
                lbl_high_price.Text = "";
                lbl_low_price.Text = "";
                lbl_close_price.Text = "";
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
            Response.Redirect("/login.aspx");
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
        /// Event handler for service directory button. Re-direct to service directory page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_srvc_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/serviceDirectory.aspx");
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
        /// Event handler for staff page. Re-direct to staff page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("/page3/staffPage.aspx");
        }
    }
}