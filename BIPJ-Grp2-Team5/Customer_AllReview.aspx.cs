using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPJ_Grp2_Team5
{
    public partial class Customer_AllReview : System.Web.UI.Page
    {
        Review aRev = new Review();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            List<Review> prodList = new List<Review>();
            prodList = aRev.getReviewAll();
            gv_Reviews.DataSource = prodList;
            gv_Reviews.DataBind();
        }
    }
}