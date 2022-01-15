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
                Link_ProdID.Text = "ID " + prodID.ToString();
                tb_ProdName.Text = prod.Product_Name.ToString();
                tb_ProdDesc.Text = prod.Product_Desc.ToString();
                tb_ProdPrice.Text = prod.Product_Price.ToString();
                tb_ProdDisc.Text = prod.Discount.ToString();
                img_result.ImageUrl = "~\\images\\" + prod.Product_Image;

                lbl_ProdID.Text = prodID.ToString();
            }
        }

        protected void Btn_EditProdConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int result = 0;
                string image = "";

                if (fu_ProdImg.HasFile == true)
                {
                    image = "images\\" + fu_ProdImg.FileName;
                    img_result.ImageUrl = fu_ProdImg.FileName;
                }
                else
                {
                    image = img_result.ImageUrl;
                }

                Product Prod = new Product();
                string datProdID = lbl_ProdID.Text;
                string datProdName = tb_ProdName.Text;
                string datProdDesc = tb_ProdDesc.Text;
                string datProdImg = img_result.ImageUrl;
                decimal datProdPrice = decimal.Parse(tb_ProdPrice.Text);
                string datDiscount = tb_ProdDisc.Text;
                string datstatus = DD_Status.SelectedItem.Value;
                result = Prod.ProductUpdate(datProdID, datProdName, datProdPrice, datProdDesc, datProdImg, datDiscount, datstatus);
                if (result > 0)
                {
                    string saveimg = Server.MapPath(" ") + "\\" + image;
                    fu_ProdImg.SaveAs(saveimg);
                    Response.Write("<script>alert('Update successful');</script>");
                    Response.Redirect("Admin_ProductDetails.aspx?Product_ID=" + datProdID);

                }
                else
                {
                    Response.Write("<script>alert('Update fail');</script>");
                }
            }
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            string prodID = lbl_ProdID.Text;
            Response.Redirect("Admin_ProductDetails.aspx?Product_ID=" + prodID);
        }

        protected void Link_Product_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product.aspx");
        }

        protected void Link_ProdID_Click(object sender, EventArgs e)
        {
            string prodID = lbl_ProdID.Text;
            Response.Redirect("Admin_ProductDetails.aspx?Product_ID=" + prodID);
        }
    }
}