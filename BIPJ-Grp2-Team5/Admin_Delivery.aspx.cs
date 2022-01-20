using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BIPJ_Grp2_Team5
{
    public partial class Admin_Delivery : System.Web.UI.Page
    {
        Checkout aCheckout = new Checkout();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }

        }
        protected void bind()
        {
            List<Checkout> checkoutList = new List<Checkout>();
            checkoutList = aCheckout.getdeliveredOrders();
            Gv_Delivery.DataSource = checkoutList;
            Gv_Delivery.DataBind();
        }


    }
}