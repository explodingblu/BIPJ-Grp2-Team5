using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Button = System.Web.UI.WebControls.Button;
using Label = System.Web.UI.WebControls.Label;
using System.Drawing;
using Image = System.Web.UI.WebControls.Image;


namespace BIPJ_Grp2_Team5
{
    public partial class ProductCatalogue : System.Web.UI.Page
    {
        Product aProd = new Product();
        string sortingby = null;
        string theme = null;
        List<Product> prodList = new List<Product>();
        Review aRate = new Review();
        int totalrate = 0;
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
                Label lbl_ID = (Label)item.FindControl("ProdID");
                Label itemlbl = (Label)item.FindControl("lbl_Disc");
                Label pricelbl = (Label)item.FindControl("lbl_Price");
                Label discpricelbl = (Label)item.FindControl("lbl_DiscPrice");
                Label ratelbl = (Label)item.FindControl("Lbl_Rate");
                double pricenum = Convert.ToDouble(pricelbl.Text);
                double discnum = Convert.ToDouble(itemlbl.Text);

                List<Review> rateList = new List<Review>();
                rateList = aRate.getReviewAllSpecifyProdID(lbl_ID.Text);
                if (rateList.Count() == 0)
                {
                    ratelbl.Text = "Not Rated Yet";
                    Image ImageRate = (Image)item.FindControl("Img_Rate");
                    ImageRate.Visible = false;
                }
                else
                {
                    foreach (var i in rateList)
                    {
                        totalrate += i.Product_Rating;
                    }
                    totalrate = totalrate / rateList.Count();
                    ratelbl.Text = totalrate.ToString();
                }
                if (discnum > 0)
                {
                    itemlbl.Visible = true;
                    pricelbl.CssClass = "labelstrike";
                    double disccalc = (100 - discnum) / 100;
                    double discprice = Math.Round((pricenum * disccalc), 2);
                    itemlbl.Text = "-" + itemlbl.Text + "% Off";
                    discpricelbl.Text = discprice.ToString();
                    itemlbl.CssClass = "DiscCss";
                    discpricelbl.Visible = true;
                }
                else
                {
                    itemlbl.Visible = false;
                    pricelbl.CssClass = "nolabelstrike";
                    discpricelbl.Visible = false;
                }
                
            }
        }
    }
}