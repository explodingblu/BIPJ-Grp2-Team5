﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Product aProd = new Product();
                string prodID = Request.QueryString["Product_ID"].ToString();
                prod = aProd.getProduct(prodID);
                lbl_prodName.Text = prod.Product_Name;
                lbl_prodDesc.Text = prod.Product_Desc;
                lbl_prodPrice.Text = prod.Product_Price.ToString("c");
                lbl_Discount.Text = prod.Discount.ToString("c");
                lbl_status.Text = prod.Status;
                img_prodImg.ImageUrl = "~\\images\\" + prod.Product_Image;

                lbl_prodID.Text = prodID.ToString();
            }
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