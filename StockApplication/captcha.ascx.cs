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
            string path1 = @"~/img.jpg";
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img.jpg");
            capImage.Save(path2, ImageFormat.Jpeg);
            image_vfy.ImageUrl = path1;
            
        }

        protected void btn_show_Click(object sender, EventArgs e)
        {
            string userLength = "";
            int len = 0;

            if (Int32.TryParse(txt_img_len.Text, out len))
            {
                if(len <= 0)
                {
                    //user entered value 0 or less so default to 4
                    userLength = "4";
                }
                else
                {
                    //user entered good value
                    userLength = txt_img_len.Text;
                }
            }
            else
            {
                //user entered non-integer value so default to 4
                userLength = "4";
            }
            Session["userLength"] = userLength;
            string myStr = proxy.GetVerifierString(userLength);
            Session["generatedString"] = myStr;
        }
    }
}