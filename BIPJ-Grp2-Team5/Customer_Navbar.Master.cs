using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Customer_Navbar : System.Web.UI.MasterPage
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
                case "#header":
                    {
                        nav2.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav1.Attributes.Add("class", "active");
                        break;
                    }
                case "#welcome":
                    {
                        nav1.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav2.Attributes.Add("class", "active");
                        break;
                    }

                case "ProductCatalogue":
                case "ProductCatalogue.aspx":
                    {
                        nav1.Attributes.Remove("active");
                        nav2.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav3.Attributes.Add("class", "active");
                        break;
                    }

                case "Education":
                case "Education.aspx":
                    {
                        nav1.Attributes.Remove("active");
                        nav2.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav4.Attributes.Add("class", "active");
                        break;
                    }

                case "#event":
                    {
                        nav1.Attributes.Remove("active");
                        nav2.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav5.Attributes.Add("class", "active");
                        break;
                    }


                case "#testimonial":
                    {
                        nav1.Attributes.Remove("active");
                        nav2.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav6.Attributes.Add("class", "active");
                        break;
                    }
                case "#blog":
                    {
                        nav1.Attributes.Remove("active");
                        nav2.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav8.Attributes.Remove("active");
                        nav7.Attributes.Add("class", "active");
                        break;
                    }
                case "#contact":
                    {
                        nav1.Attributes.Remove("active");
                        nav2.Attributes.Remove("active");
                        nav3.Attributes.Remove("active");
                        nav4.Attributes.Remove("active");
                        nav5.Attributes.Remove("active");
                        nav6.Attributes.Remove("active");
                        nav7.Attributes.Remove("active");
                        nav8.Attributes.Add("class", "active");
                        break;
                    }
            }
        }
        
    }
}