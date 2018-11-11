using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace StockApplication.PublicPages
{
    public partial class login : System.Web.UI.Page
    {
        protected void btn_mber_login_Click(object sender, EventArgs e)
        {

            lbl_username_error.Text = "";
            lbl_pass_error.Text = "";
            if (txt_username.Text == null || txt_username.Text == "")
            {
                lbl_username_error.Text = "Email is empty!";
                return;
            }

            if (lbl_pass_error.Text == null || lbl_pass_error.Text == "")
            {
                lbl_pass_error.Text = "Password is empty!";
                return;
            }


            /*******************************************/
            //TODO search for username (txt_username.Text)  
            //and ecrypted in Member.xml here for component 'e' of part 2.
            //logic could first check if the username exits in the file, 
            //then if the passwords (txt_pass.Text) match using the decrypt function.
            /*******************************************/


            //Access member page if everything worked
            Response.Redirect("~/MemberPages/memberPage.aspx");
        }
    }
}