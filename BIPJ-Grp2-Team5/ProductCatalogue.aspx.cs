using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BIPJ_Grp2_Team5
{
    public partial class ProductCatalogue : System.Web.UI.Page
    {
        Product aProd = new Product();
        string sortingby = null;
        string theme = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
            List<Product> prodList = new List<Product>();
            prodList = aProd.getProductAll();// returns a list full of class
            DL_ProdCat.DataSource = prodList;
            DL_ProdCat.DataBind();
            /*string mainconn = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from Products";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = sqlcomm;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DL_ProdCat.DataSource = ds;
            DL_ProdCat.DataBind();
            sqlconn.Close();*/

            if (DD_scending.SelectedIndex > -1)
            {
                sortingby = DD_scending.SelectedItem.Text;
            }
            if (DD_Theme.SelectedIndex > -1)
            {
                theme = DD_Theme.SelectedItem.Text;
            }
        }
    }
}