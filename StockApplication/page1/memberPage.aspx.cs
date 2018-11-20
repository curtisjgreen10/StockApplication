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
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            if(Session["username"] != null)
            {
                if((bool)Session["staff"] == true)
                {
                    btn_stf_login.Visible = true;
                    lbl_logged_in.Text = "Logged in as staff: " + (string)Session["username"];
                }
                else
                {
                    lbl_logged_in.Text = "Logged in as: " + (string)Session["username"];
                }
            }
        }

        protected void btn_go_Click(object sender, EventArgs e)
        {
            //create proxy
            StockService.StockServiceClient proxy = new StockService.StockServiceClient();
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

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            Session["username"] = null;
            Session["staff"] = null;
            Response.Redirect("~/login.aspx");
        }

        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/accountInformation.aspx");
        }

        protected void btn_srvc_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/serviceDirectory.aspx");
        }

        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/features.aspx");
        }

        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/staffPage.aspx");
        }
    }
}