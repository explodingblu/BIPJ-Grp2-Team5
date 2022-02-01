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
    public partial class Admin_Product_Add : System.Web.UI.Page
    {
        Product aProd = new Product();
        Product prods = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_AddProdConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int result = 0;
                string image = "";

                if (fu_ProdImg.HasFile == true)
                {
                    image = "Images\\" + fu_ProdImg.FileName;
                }

                Product prod = new Product(tb_ProdID.Text, tb_ProdName.Text, decimal.Parse(tb_ProdPrice.Text), tb_ProdDesc.Text, fu_ProdImg.FileName, 0, "Not In Stock", 0);
                result = prod.ProductInsert();

                if (result > 0)
                {
                    string saveimg = Server.MapPath(" ") + "\\" + image;
                    lbl_ImgTemp.Text = saveimg.ToString();
                    fu_ProdImg.SaveAs(saveimg);
                    //loadProductInfo();
                    //loadProduct();
                    //clear1();
                    string message = "Inserted " + tb_ProdName.Text + " Successfully";
                    MessageBox.Show(message);
                    Response.Write("<script>alert('Insert successful');</script>");
                    Response.Redirect("Admin_Product.aspx");
                }
                else
                {
                    string message = "Not Successful";
                    MessageBox.Show(message);
                    Response.Write("<script>alert('Insert NOT successful');</script>");
                }
            }
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product.aspx");
        }

        protected void cv_LessProdID_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int newID = int.Parse(tb_ProdID.Text);
            if (newID < 0)
            {
                //error validation
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void cv_LessDiscount_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int newDisc = int.Parse(tb_ProdDisc.Text);
            if (newDisc < 0)
            {
                //error validation
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void Link_Product_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product.aspx");
        }

        protected void CV_Exist_ServerValidate(object source, ServerValidateEventArgs args)
        {
            List<Product> prodList = new List<Product>();
            prodList = aProd.getProductAll();
            List<string> DBIDList = new List<string>();
            for (int i = 0; i < prodList.Count; i++)
            {
                prods = prodList[i];
                DBIDList.Add(prods.Product_ID);
            }
            string newID = tb_ProdID.Text;
            if (DBIDList.Contains(newID))
            {
                //error validation
                string lastno = DBIDList[DBIDList.Count - 1];
                int suggestion = Int32.Parse(lastno) + 1;
                string message = "Product ID already exist. Please use a different ID. Try using " + suggestion;
                MessageBox.Show(message);
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}