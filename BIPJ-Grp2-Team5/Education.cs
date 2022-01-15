using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace BIPJ_Grp2_Team5
{
    public class Education
    {
        protected void Submit(object sender, EventArgs e)
        {
            //event handler to insert content of Admin_Educaiton_Add into the table [Pages] in the db
            string query = "INSERT INTO [Pages] VALUES (@PageName, @Title, @Content)";
            string conString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
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
                    Response.Redirect("~/Default.aspx");
                }
            }
        }
    }