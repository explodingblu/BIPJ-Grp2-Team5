using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class AddReview : System.Web.UI.Page
    {
        Product aProd = new Product();
        List<Product> prodList = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load sample data only once, when the page is first loaded.
            if (!Page.IsPostBack)
            {
                DDLRateBindData();
            }
        }

        protected void DDLRateBindData()
        {
            prodList = aProd.getProductAll();// returns a list full of class

            DDL_Product.DataSource = prodList;
            DDL_Product.DataTextField = "Product_Name";
            DDL_Product.DataValueField = "Product_Name";
            DDL_Product.DataBind();

        }
    }
}