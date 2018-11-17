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

        }

        protected void log_out_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PublicPages/login.aspx");
        }

        protected void stock_page_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MemberPages/memberPage.aspx");
        }
    }
}