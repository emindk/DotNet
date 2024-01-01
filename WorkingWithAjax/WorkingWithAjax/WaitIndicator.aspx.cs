using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithAjax
{
    public partial class WaitIndicator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdRefreshTime_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}