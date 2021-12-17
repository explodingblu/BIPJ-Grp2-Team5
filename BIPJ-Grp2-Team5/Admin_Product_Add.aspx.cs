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

        /*protected void ProdAdd_Btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string image = "";

            if (ProdImg_FileUpload.HasFile == true)
            {
                image = "Images\\" + ProdImg_FileUpload.FileName;
            }

            Product prod = new Product(tb_ProdID.Text, tb_ProdName.Text, decimal.Parse(tb_ProdPrice.Text), tb_ProdDesc.Text, ProdImg_FileUpload.FileName, 0, 0);
            result = prod.ProductInsert();

            if (result > 0)
            {
                string saveimg = Server.MapPath(" ") + "\\" + image;
                lbl_result.Text = saveimg.ToString();
                ProdImg_FileUpload.SaveAs(saveimg);
                //loadProductInfo();
                //loadProduct();
                //clear1();
                Response.Write("<script>alert('Insert successful');</script>");
            }
            else { Response.Write("<script>alert('Insert NOT successful');</script>"); }

        }

        protected void ProdBackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product.aspx");
        }*/
    }
}