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
            // Load sample data only once, when the page is first loaded.
            if (!IsPostBack)
            {
            }
            List<Product> prodList = new List<Product>();
            prodList = aProd.getProductAll();// returns a list full of class
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
            if (theme == "Name")
            {
                if (sortingby == "Ascending")
                {
                    prodList.Sort((x, y) => string.Compare(x.Product_Name, y.Product_Name));
                }
                else if (sortingby == "Descending")
                {
                    prodList.Sort((x, y) => string.Compare(y.Product_Name, x.Product_Name));
                }
            }
            else if(theme == "Price")
            {
                if (sortingby == "Ascending")
                {
                    prodList.Sort((x, y) => decimal.Compare(x.Product_Price, y.Product_Price));
                }
                else if (sortingby == "Descending")
                {
                    prodList.Sort((x, y) => decimal.Compare(y.Product_Price, x.Product_Price));
                }
            }
            DL_ProdCat.DataSource = prodList;
            DL_ProdCat.DataBind();

            // Manually register the event-handling method for the 
            // ItemCommand event.
            DL_ProdCat.ItemCommand +=
                new DataListCommandEventHandler(this.Item_Command);
        }
        void Item_Command(Object sender, DataListCommandEventArgs e)
        {

            // Set the SelectedIndex property to select an item in the DataList.
            DL_ProdCat.SelectedIndex = e.Item.ItemIndex;

            // Rebind the data source to the DataList to refresh the control.
            List<Product> prodList = new List<Product>();
            prodList = aProd.getProductAll();
            DL_ProdCat.DataSource = prodList;
            DL_ProdCat.DataBind();

        }
        /*protected void DL_ProdCat_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Label lbl = (Label)e.Item.FindControl("ProdID");
            Response.Write(lbl.Text);
        }*/


    }
}