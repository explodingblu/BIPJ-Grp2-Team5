using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Admin_ProductDetails_edit : System.Web.UI.Page
    {
        Product prod = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Product aProd = new Product();
                string prodID = Request.QueryString["Product_ID"].ToString();
                prod = aProd.getProduct(prodID);
                tb_ProdName.Text = prod.Product_Name.ToString();
                tb_ProdDesc.Text = prod.Product_Desc.ToString();
                tb_ProdPrice.Text = prod.Product_Price.ToString();
                tb_ProdDisc.Text = prod.Discount.ToString();
                img_result.ImageUrl = "~\\images\\" + prod.Product_Image;

                lbl_ProdID.Text = prodID.ToString();
            }
        }
    }
}