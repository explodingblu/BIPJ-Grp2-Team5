using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BIPJ_Grp2_Team5
{
    public partial class Admin_Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string thisURL = Request.Url.Segments[Request.Url.Segments.Length - 1];


            // login/logout for elston to settle *to check if admin as logged in*
            //try
            //{
            //    Session["AdminUserName"].ToString();
            //    lbl_AdminName.Text = " " + Session["AdminUserName"];
            //}
            //catch (NullReferenceException)
            //{
            //    Response.Write("<script language='javascript'>window.alert('Your not logged in');window.location='adminsignin.aspx';</script>");
            //}


            switch (thisURL)
            {
                case "Admin_Index":
                case "Admin_Index.aspx":
                    {
                        tabadminproduct.Attributes.Remove("active");
                        tabadminorders.Attributes.Remove("active");
                        tabadminmanufacturing.Attributes.Remove("active");
                        tabadmindelivery.Attributes.Remove("active");
                        tabadminindex.Attributes.Add("class", "active");
                        break;
                    }

                case "Admin_Product":
                case "Admin_Product.aspx":

                    {
                        tabadminindex.Attributes.Remove("active");
                        tabadminorders.Attributes.Remove("active");
                        tabadminmanufacturing.Attributes.Remove("active");
                        tabadmindelivery.Attributes.Remove("active");
                        tabadminproduct.Attributes.Add("class", "active");
                        break;
                    }

                case "Admin_Orders":
                case "Admin_Orders.aspx":
                    {
                        tabadminindex.Attributes.Remove("active");
                        tabadminproduct.Attributes.Remove("active");
                        tabadminmanufacturing.Attributes.Remove("active");
                        tabadmindelivery.Attributes.Remove("active");
                        tabadminorders.Attributes.Add("class", "active");
                        break;
                    }

                case "Admin_Manufacturing":
                case "Admin_Manufacturing.aspx":
                    {
                        tabadminindex.Attributes.Remove("active");
                        tabadminproduct.Attributes.Remove("active");
                        tabadminorders.Attributes.Remove("active");
                        tabadmindelivery.Attributes.Remove("active");
                        tabadminmanufacturing.Attributes.Add("class", "active");
                        break;
                    }

                case "Admin_Delivery":
                case "Admin_Delivery.aspx":
                    {
                        tabadminindex.Attributes.Remove("active");
                        tabadminproduct.Attributes.Remove("active");
                        tabadminorders.Attributes.Remove("active");
                        tabadminmanufacturing.Attributes.Remove("active");
                        tabadmindelivery.Attributes.Add("class", "active");
                        break;
                    }


                case "AdminDatabase":
                case "AdminDatabase.aspx":
                    {
                        tabadmindelivery.Attributes.Remove("active");
                        tabadminindex.Attributes.Remove("active");
                        tabadminproduct.Attributes.Remove("active");
                        tabadminorders.Attributes.Remove("active");
                        tabadminmanufacturing.Attributes.Remove("active");
                        break;
                    }

                //case "AdminUser":
                //case "AdminUser.aspx":
                //    {
                //        tabadmindelivery.Attributes.Remove("active");
                //        tabadminindex.Attributes.Remove("active");
                //        tabadminproduct.Attributes.Remove("active");
                //        tabadminorders.Attributes.Remove("active");
                //        tabadminmanufacturing.Attributes.Remove("active");
                //        tabadminuser.Attributes.Add("class", "active");
                //        break;
                //    }

                //case "AdminContactus":
                //case "AdminContactus.aspx":
                //    {
                //        tabadmindelivery.Attributes.Remove("active");
                //        tabadminindex.Attributes.Remove("active");
                //        tabadminproduct.Attributes.Remove("active");
                //        tabadminorders.Attributes.Remove("active");
                //        tabadminmanufacturing.Attributes.Remove("active");
                //        tabcontactus.Attributes.Add("class", "active");
                //        break;
                //    }




            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {

            Session.Clear();
            Session.Abandon();
            Response.Write("<script language='javascript'>window.alert('Admin Successfully logout!');window.location='adminsignin.aspx';</script>");

        }
    }
}