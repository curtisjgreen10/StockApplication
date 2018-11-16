using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace StockApplication.PublicPages
{
    public partial class captcha : System.Web.UI.UserControl
    {
        ImageService.ServiceClient proxy = new ImageService.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string myStr;
            string userLen;
            Response.Clear();

            if (Session["generatedString"] == null)
            {
                if (Session["userLength"] == null)
                {
                    userLen = "3";
                }
                else
                {
                    userLen = Session["userLength"].ToString();
                }
                myStr = proxy.GetVerifierString(userLen);
                Session["generatedString"] = myStr;
            }
            else
            {
                myStr = Session["generatedString"].ToString();
            }
            
            Stream stream = proxy.GetImage(myStr);
            System.Drawing.Image capImage = System.Drawing.Image.FromStream(stream);
            //Response.ContentType = "image/jpeg";
            string path1 = @"~/PublicPages/img.jpg";
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"PublicPages", "img.jpg");
            capImage.Save(path2, ImageFormat.Jpeg);
            image_vfy.ImageUrl = path1;
        }

        protected void btn_show_Click(object sender, EventArgs e)
        {
            
            string userLength = txt_img_len.Text;
            Session["userLength"] = userLength;
            string myStr = proxy.GetVerifierString(userLength);
            Session["generatedString"] = myStr;
            btn_show.Text = "Show different image";
        }

        protected void btn_verify_Click(object sender, EventArgs e)
        {
            
            if (Session["generatedString"].Equals(txt_img_string.Text))
            {
                lbl_msg.Text = "Text matches image!";
            }
            else
            {
                lbl_msg.Text = "Incorrect, please try again";
            }
            
        }
    }
}