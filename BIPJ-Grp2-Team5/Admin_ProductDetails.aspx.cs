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
        protected void Page_Load(object sender, EventArgs e)
        {
           
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
    }
}