using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Admin_Product : System.Web.UI.Page
    {
        Product aProd = new Product();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            List<Product> prodList = new List<Product>();
            prodList = aProd.getProductAll();
            gvProduct.DataSource = prodList;
            gvProduct.DataBind();
        }

        protected void Btn_AddProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Product_Add.aspx");
        }

        protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected row.
            GridViewRow row = gvProduct.SelectedRow;

            //Get Product ID from the selected row, which is the
            // first row, i.e. index 0.
            string prodID = row.Cells[1].Text;

            // Redirect to next page, with the Product Id added to the URL,
            // e.g. ProductDetails.aspx?ProdID=1
            Response.Redirect("Admin_ProductDetails.aspx?Product_ID=" + prodID);

        }

        protected void gvProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int result = 0;
            Product prod = new Product();
            string categoryID = gvProduct.DataKeys[e.RowIndex].Value.ToString();
            result = prod.ProductDelete(categoryID);

            if (result > 0)
            {
                Response.Write("<script>alert('Product Remove successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Product Removal NOT successfully');</script>");
            }

            Response.Redirect("ProductView.aspx");

        }
    }
}