using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Counter
{
	public partial class CookieExample : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            HttpCookie cookie = Request.Cookies["username"];

            if (cookie == null)
            {
                lblMessage.Text = "I don't know your name.";
            }
            else
            {
                lblMessage.Text = "Welcome " + cookie.Value + "!";
            }
        }
        protected void btnCreateCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("username");
            cookie.Value = tbUsername.Text;
            cookie.Expires = DateTime.Now.AddDays(14);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default.aspx");
        }
        protected void btnDeleteCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("username");
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default.aspx");
        }
    }
}