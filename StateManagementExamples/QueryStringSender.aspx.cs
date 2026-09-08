using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Counter
{
	public partial class QueryStringSender : System.Web.UI.Page
	{
        public class Item
        {
            public string Name { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
		{
            
        }

        protected void cmdGo_Click(object sender, EventArgs e) 
		{
            if (lstItems.SelectedIndex == -1)
            {
                lblError.Text = "You must select an item.";
            }
            else
            {
                // Forward the user to the info page, with the query string data.
                string url = "QueryStringRecipient.aspx?";
                
                url += "Item=" + lstItems.SelectedValue.ToString() + "&";
                url += "Mode=" + chkDetails.Checked.ToString();
                Response.Redirect(url);
            }
        }
    }
}