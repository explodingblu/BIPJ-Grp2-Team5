using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Customer_ProductView : System.Web.UI.Page
    {
        Product prod = null;
        Review aRev = new Review();
        Review aRate = new Review();
        string prodID = "";
        int totalrate = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Product aProd = new Product();
                prodID = Request.QueryString["Product_ID"].ToString();
                prod = aProd.getProduct(prodID);
                lbl_prodName.Text = prod.Product_Name;
                lbl_prodDesc.Text = prod.Product_Desc;
                lbl_prodPrice.Text = prod.Product_Price.ToString("c");
                lbl_Discount.Text = prod.Discount.ToString("c");

                List<Review> rateList = new List<Review>();
                rateList = aRate.getReviewAllSpecifyProdID(prodID);
                if (rateList.Count() == 0)
                {
                    lbl_prodReview.Text = "Not Rated Yet";
                }
                else
                {
                    foreach (var i in rateList)
                    {
                        totalrate += i.Product_Rating;
                    }
                    totalrate = totalrate / rateList.Count();
                    lbl_prodReview.Text = totalrate.ToString() + " Star";
                }

                if (prod.Discount > 0)
                {
                    lbl_Discount.Visible = true;
                    lbl_prodPrice.CssClass = "labelstrike";
                    decimal disccalc = (100 - prod.Discount) / 100;
                    decimal discprice = Math.Round((prod.Product_Price * disccalc), 2);
                    lbl_Discount.Text = "-" + lbl_Discount.Text + "% Off";
                    lbl_DiscPrice.Text = discprice.ToString();
                    lbl_Discount.CssClass = "lblDiscCss";
                    lbl_DiscPrice.Visible = true;
                }
                else
                {
                    lbl_Discount.Visible = false;
                    lbl_prodPrice.CssClass = "nolabelstrike";
                    lbl_DiscPrice.Visible = false;
                }

                lbl_status.Text = prod.Status;
                img_prodImg.ImageUrl = "~\\images\\" + prod.Product_Image;

                lbl_prodID.Text = prodID.ToString();
                bind();
            }
        }
        protected void bind()
        {
            List<Review> revList = new List<Review>();
            revList = aRev.getReviewAllSpecifyProdID(prodID);
            gv_ProdReview.DataSource = revList;
            gv_ProdReview.DataBind();
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductCatalogue.aspx");
        }

        protected void Btn_Edit_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Buy_Click(object sender, EventArgs e)
        {

        }

        protected void Link_Product_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductCatalogue.aspx");
        }
    }
}