using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace StockApplication
{
    public partial class exchange : System.Web.UI.Page
    {
        
        //create dictionary for string to symbols
        Dictionary<string, string> currencies = new Dictionary<string, string>();
        //create proxy for web service
        ExchangeService.ServiceClient proxy = new ExchangeService.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            //first check if anybody is loged in.
            
            if (Session["username"] != null)
            {
                //then check how they are logged in - staff or normal member.
                if ((bool)Session["staff"] == true)
                {
                    btn_stf_login.Visible = true;
                    lbl_logged_in.Text = "Logged in as staff: " + (string)Session["username"];
                }
                else
                {
                    lbl_logged_in.Text = "Logged in as: " + (string)Session["username"];
                }
                populateListBoxes();
            }
            else
            {
                //if session is null this page is trying to be loaded with no login so re-direct
                Response.Redirect("~/login.aspx");
            }
        }

        /// <summary>
        /// Calculate button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_calculate_Click(object sender, EventArgs e)
        {
            //clear error labels
            lbl_from_error.Text = "";
            //check for errors
            if (txt_from_amt.Text == null || txt_from_amt.Text.Equals(""))
            {
                lbl_from_error.Text = "Enter dollar amount to convert";
                return;
            }
            //no errors so run conversion
            currencies.TryGetValue(cb_from_symbol.SelectedValue, out string from_sym);
            currencies.TryGetValue(cb_to_symbol.SelectedValue, out string to_sym);
            double rate = proxy.queryRate(from_sym, to_sym);
            try
            {
                rate = rate * Convert.ToDouble(txt_from_amt.Text);
            }
            catch (Exception)
            {
                lbl_from_error.Text = "Irregular input try again";
                return;
            }
            txt_result.Text = rate.ToString();
        }

        /// <summary>
        /// Populate the dictionary, then use that to populate the list boxes.
        /// </summary>
        private void populateListBoxes()
        {
            //populate the dictionary
            readCSV("physical_currency_list.csv");
            readCSV("digital_currency_list.csv");
            //use dictionary to populate list boxes
            foreach (KeyValuePair<string, string> entry in currencies)
            {
                cb_from_symbol.Items.Add(entry.Key);
                cb_to_symbol.Items.Add(entry.Key);
            }
        }

        /// <summary>
        /// Read CSV files contaning currency information
        /// </summary>
        /// <param name="filename"></param>
        private void readCSV(string filename)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            StreamReader reader = new StreamReader(File.OpenRead(path));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 2)
                    {
                        currencies.Add(values[1], values[0]);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for logout button. Clear session variables. Re-direct to login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            btn_stf_login.Visible = false;
            Session["username"] = null;
            Session["staff"] = null;
            Response.Redirect("~/login.aspx");
        }

        /// <summary>
        /// Event handler for account button. Re-direct to account page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/accountInformation.aspx");
        }

        /// <summary>
        /// Event handler for stock button. Re-direct to stock page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_stocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/stockPage.aspx");
        }

        /// <summary>
        /// Event handler for service directory button. Re-direct to service directory page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_srvc_dir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/serviceDirectory.aspx");
        }

        /// <summary>
        /// Event handler for features button. Re-direct to features page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_ftrs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/features.aspx");
        }

        /// <summary>
        /// Event handler for staff page. Re-direct to staff page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_stf_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/staffPage.aspx");
        }
    }
}