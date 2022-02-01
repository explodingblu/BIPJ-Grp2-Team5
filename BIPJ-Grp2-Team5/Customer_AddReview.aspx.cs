using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Customer_AddReview : System.Web.UI.Page
    {
        Product aProd = new Product();
        List<Product> prodList = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load sample data only once, when the page is first loaded.
            if (!Page.IsPostBack)
            {
                DDLRateBindData();
                ImgBtnBindData();
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

        protected void ImgBtnBindData()
        {
            ImgBtn_Rating1.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating2.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating3.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating5.ImageUrl = "~/Images/EmptyStarRating.jpeg";

        }

        protected void ImgBtn_Rating1_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_Rating1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating2.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating3.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_Rating2_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_Rating1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating3.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_Rating3_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_Rating1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating3.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_Rating5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_Rating4_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_Rating1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating3.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating4.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_Rating5_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_Rating1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating3.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating4.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_Rating5.ImageUrl = "~/Images/FullStarRating.jpeg";
        }
    }
}