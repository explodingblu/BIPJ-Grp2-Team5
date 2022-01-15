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
        List<Product> prodList = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {

            // Load sample data only once, when the page is first loaded.
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
            prodList = aProd.getProductAll();// returns a list full of class
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
            else if (theme == "Price")
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

        }
        protected void DL_ProdCat_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ViewBtn") // check commandname here
            {
                int index = e.Item.ItemIndex;
                Label lbl = (Label)DL_ProdCat.Items[index].FindControl("ProdID");
                // your code
                Response.Redirect("Customer_ProductView.aspx?Product_ID=" + lbl.Text);
            }
        }

        protected void DD_scending_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodList = aProd.getProductAll();// returns a list full of class
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
            else if (theme == "Price")
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
        }

        protected void DD_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodList = aProd.getProductAll();// returns a list full of class
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
            else if (theme == "Price")
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
        }

        protected void DL_Condition(object sender, EventArgs e)
        {
            foreach (DataListItem item in DL_ProdCat.Items)
            {
            }
        }
    }
}