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
    public partial class WebForm4 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PopulatePage();
            }
        }

        private void PopulatePage()
        {
            string pageName = this.Page.RouteData.Values["PageName"].ToString();
            string query = "SELECT [Title], [Content] FROM [Pages] WHERE [PageName] = @PageName";
            string conString = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@PageName", pageName);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            lblTitle.Text = dt.Rows[0]["Title"].ToString();
                            lblContent.Text = dt.Rows[0]["Content"].ToString();
                        }
                    }
                }
            }
        }
    }
}