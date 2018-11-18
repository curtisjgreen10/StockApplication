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
            if(Session["username"] != null)
            {
                lbl_logged_in.Text = "Logged in as: " + Session["username"];
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


        protected void acct_info_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/login.aspx");
        }

        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MemberPages/accountInformation.aspx");
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