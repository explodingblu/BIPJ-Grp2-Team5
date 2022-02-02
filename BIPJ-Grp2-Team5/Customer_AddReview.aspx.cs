using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BIPJ_Grp2_Team5
{
    public partial class Customer_AddReview : System.Web.UI.Page
    {
        Product aProd = new Product();
        Review aRev = new Review();
        List<Product> prodList = new List<Product>();
        List<Review> revList = new List<Review>();
        List<Review> revlengthList = new List<Review>();
        Review aReview = new Review();
        string lastrevID;
        int lastrevnum;
        int reviewValue;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load sample data only once, when the page is first loaded.
            if (!Page.IsPostBack)
            {
                DDLRateBindData();
                ImgBtnBindData();
            }
            revlengthList = aRev.getReviewAll();
            if (revlengthList.Count == 0)
            {
                lastrevID = "0";
            }
            else
            {
                lastrevID = revlengthList[revlengthList.Count - 1].Review_ID;
            }
            lastrevnum = int.Parse(lastrevID) + 1;
        }

        protected void DDLRateBindData()
        {
            prodList = aProd.getProductAll();// returns a list full of class

            DDL_Product.DataSource = prodList;
            DDL_Product.DataTextField = "Product_Name";
            DDL_Product.DataValueField = "Product_ID";
            DDL_Product.DataBind();

        }

        protected void ImgBtnBindData()
        {
            ImgBtn_1.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_2.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_3.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_5.ImageUrl = "~/Images/EmptyStarRating.jpeg";

        }

        protected void ImgBtn_1_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_2.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_3.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_2_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_3.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_3_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_3.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_4.ImageUrl = "~/Images/EmptyStarRating.jpeg";
            ImgBtn_5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_4_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_3.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_4.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_5.ImageUrl = "~/Images/EmptyStarRating.jpeg";
        }

        protected void ImgBtn_5_Click(object sender, ImageClickEventArgs e)
        {
            ImgBtn_1.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_2.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_3.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_4.ImageUrl = "~/Images/FullStarRating.jpeg";
            ImgBtn_5.ImageUrl = "~/Images/FullStarRating.jpeg";
        }

        protected void btn_Create_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (ImgBtn_5.ImageUrl == "~/Images/FullStarRating.jpeg")
            {
                reviewValue = 5;
            }
            else if (ImgBtn_4.ImageUrl == "~/Images/FullStarRating.jpeg")
            {
                reviewValue = 4;
            }
            else if (ImgBtn_3.ImageUrl == "~/Images/FullStarRating.jpeg")
            {
                reviewValue = 3;
            }
            else if (ImgBtn_2.ImageUrl == "~/Images/FullStarRating.jpeg")
            {
                reviewValue = 2;
            }
            else if (ImgBtn_1.ImageUrl == "~/Images/FullStarRating.jpeg")
            {
                reviewValue = 1;
            }
            Review rev = new Review(lastrevnum.ToString(), reviewValue, tb_Comment.Text, DDL_Product.SelectedValue, "");
            result = rev.ReviewInsert();

            if (result > 0)
            {
                string message = "Created Review Successfully";
                MessageBox.Show(message);
                Response.Write("<script>alert('Insert successful');</script>");
                Response.Redirect("Customer_AllReview.aspx");
            }
            else
            {
                string message = "Not Successful";
                MessageBox.Show(message);
                Response.Write("<script>alert('Insert NOT successful');</script>");
            }
        }
    }
}