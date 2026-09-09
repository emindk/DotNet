using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

public partial class DataPage : System.Web.UI.Page
{
    string ConString = WebConfigurationManager.ConnectionStrings["SurveyDB"].ConnectionString;
    SqlConnection conn = new SqlConnection();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnClickForDataReader_Click(object sender, EventArgs e)
    {
        // Data Reader Example
        conn.ConnectionString = ConString;
        SqlCommand cmd = new SqlCommand("Select * From UserInfo", conn);

        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        String str = "";
        while (reader.Read())
        {
            str += reader["FirstName"] + "<br/>";
        }
        conn.Close();

        // Do whatever you want with the info
    }
    protected void btnDeleteLastRecord_Click(object sender, EventArgs e)
    {
        // ExecuteScalar Example: Get Last ELement's UserID 
        conn.ConnectionString = ConString;
        SqlCommand cmd = new SqlCommand("Select Max(UserID) From UserInfo", conn);
        conn.Open();
        int IDOftheElement = (int)cmd.ExecuteScalar();
        conn.Close();

        // ExecuteNonQuery Example: Delete the selected Info
        cmd = new SqlCommand("Delete From UserInfo Where UserID = " + IDOftheElement.ToString(), conn);
        conn.Open();
        int affectedNumber = (int)cmd.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("DataPage.aspx");

    }
}