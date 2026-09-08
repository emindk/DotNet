using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Counter
{
	public partial class PreserverMembers : System.Web.UI.Page
	{
        string contents;
        
		protected void Page_Load(object sender, EventArgs e)
		{
            if (this.IsPostBack)
            {
                // Restore variables.
                contents = (string)ViewState["contents"];
            }

        }

        protected void Page_PreRender(Object sender, EventArgs e)
        {
            // Persist variables.
            ViewState["contents"] = contents;

        }

        protected void btnSaveContents_Click(object sender, EventArgs e)
		{
            // Transfer contents of text box to member variable.
            contents = txtValue.Text;
            txtValue.Text = "";
        }

        protected void btnLoadContents_Click(object sender, EventArgs e)
        {
            // Restore contents of member variable to text box.
            txtValue.Text = contents;
        }

    }
}