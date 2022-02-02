using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Admin_ProductDetails : System.Web.UI.Page
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
                lbl_Breadcrumb.Text = "ID " + prodID.ToString();
                lbl_prodName.Text = prod.Product_Name;
                lbl_prodDesc.Text = prod.Product_Desc;
                lbl_prodPrice.Text = prod.Product_Price.ToString("c");
                lbl_Discount.Text = prod.Discount.ToString();
                img_prodImg.ImageUrl = "~\\images\\" + prod.Product_Image;
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
            Response.Redirect("Admin_Product.aspx");
        }

        protected void Btn_Edit_Click(object sender, EventArgs e)
        {
            string prodID = lbl_prodID.Text;
            Response.Redirect("Admin_ProductDetails_edit.aspx?Product_ID=" + prodID);
        }

        protected void Link_Product_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product.aspx");
        }
    }
}