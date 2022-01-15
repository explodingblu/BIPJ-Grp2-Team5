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
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindPages();
            }

        }

        private void BindPages()
            {
                string query = "SELECT [PageName], [Title], [Content] FROM [Pages]";
                string conString = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                rptPages.DataSource = dt;
                                rptPages.DataBind();
                            }
                        }
                    }
                }
            }
        
    }
}