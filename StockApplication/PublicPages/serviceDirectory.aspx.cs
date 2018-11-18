using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockApplication.PublicPages
{
    public partial class serviceDirectory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sign_up_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/default.aspx");
        }

        protected void btn_mber_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/login.aspx");
        }

        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            //TODO
        }

        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/features.aspx");
        }
    }
}