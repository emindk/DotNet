using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Counter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCounter_Click(object sender, EventArgs e)
        {
            Response.Redirect("Counter.aspx");
        }
        protected void btnMemberVariable_Click(object sender, EventArgs e)
        {
            Response.Redirect("PreserverMembers.aspx");
        }

        protected void btnQeuryString_Click(object sender, EventArgs e) 
        {
            Response.Redirect("QueryStringSender.aspx");
        }

        protected void btnCookie_Click(object sender, EventArgs e)
        {
            Response.Redirect("CookieExample.aspx");
        }
    }
}