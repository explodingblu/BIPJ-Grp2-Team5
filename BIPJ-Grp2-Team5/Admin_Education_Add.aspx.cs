using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;



namespace BIPJ_Grp2_Team5
{
    public partial class Admin_Education_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit(object sender, EventArgs e)
        {
            string query = "INSERT INTO [Pages] VALUES (@PageName, @Title, @Content)";
            string conString = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PageName", txtPageName.Text.Replace(" ", "-"));
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Content", txtContent.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Redirect("~/Education.aspx");
                }
            }
        }
    }
}