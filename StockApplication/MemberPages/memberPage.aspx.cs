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
                lbl_open.Text = "$" + stats[0];
                lbl_high.Text = "$" + stats[1];
                lbl_low.Text = "$" + stats[2];
                lbl_close.Text = "$" + stats[3];
            }
            catch (Exception ex)
            {
                //display any exception messages in txt_open text box
                lbl_open.Text = "no data or invalid stock or other error";
                lbl_high.Text = "";
                lbl_low.Text = "";
                lbl_close.Text = "";
            }
        }
    }
}