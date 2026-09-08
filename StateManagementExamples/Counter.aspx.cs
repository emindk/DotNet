using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Counter
{
	public partial class Counter : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                ViewState["counter"] = 0;
            }
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            int counter = (int)ViewState["counter"];
            counter++;
            ViewState["counter"] = counter;
            lblCounter.Text = "Counter: " + counter.ToString();
        }
    }
}