using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Admin_Product_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_AddProdConfirm_Click(object sender, EventArgs e)
        {
            int result = 0;
            string image = "";

            if (fu_ProdImg.HasFile == true)
            {
                image = "Images\\" + fu_ProdImg.FileName;
            }

            Product prod = new Product(tb_ProdID.Text, tb_ProdName.Text, decimal.Parse(tb_ProdPrice.Text), tb_ProdDesc.Text, fu_ProdImg.FileName, 0, 0);
            result = prod.ProductInsert();

            if (result > 0)
            {
                string saveimg = Server.MapPath(" ") + "\\" + image;
                lbl_ImgTemp.Text = saveimg.ToString();
                fu_ProdImg.SaveAs(saveimg);
                //loadProductInfo();
                //loadProduct();
                //clear1();
                Response.Write("<script>alert('Insert successful');</script>");
            }
            else { Response.Write("<script>alert('Insert NOT successful');</script>"); }
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product.aspx");
        }
    }
}