using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockApplication.MemberPages
{
    public partial class accountInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            if (Session["username"] != null)
            {
                txt_email.Text = (string)Session["username"];
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

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            Session["username"] = null;
            Session["staff"] = null;
            Response.Redirect("~/login.aspx");
        }

        protected void btn_stocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/memberPage.aspx");
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