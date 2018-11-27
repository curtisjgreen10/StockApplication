using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockApplication
{
    public partial class features : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_logout.Visible = false;
            lbl_logged_in.Visible = false;
            btn_account.Visible = false;
            btn_stocks.Visible = false;
            btn_stf_login.Visible = false;
            if (Session["username"] != null)
            {
                btn_account.Visible = true;
                btn_stocks.Visible = true;
                btn_mber_login.Visible = false;
                btn_sign_up.Visible = false;
                btn_logout.Visible = true;
                lbl_logged_in.Visible = true;
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
        }

        protected void btn_sign_up_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        protected void btn_mber_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/staffPage.aspx");
        }

        protected void btn_srv_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/serviceDirectory.aspx");
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["staff"] = null;
            btn_logout.Visible = false;
            btn_sign_up.Visible = true;
            lbl_logged_in.Visible = false;
            btn_account.Visible = false;
            btn_stocks.Visible = false;
            btn_mber_login.Visible = true;
            Response.Redirect("~/login.aspx");
        }

        protected void btn_stocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/stockPage.aspx");
        }

        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/accountInformation.aspx");
        }
    }
}