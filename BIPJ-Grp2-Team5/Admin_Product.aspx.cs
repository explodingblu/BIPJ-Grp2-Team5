using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Button = System.Web.UI.WebControls.Button;

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
            foreach (GridViewRow row in gvProduct.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    Button btn = row.FindControl("btn_Status") as Button;
                    if (btn.CommandName == "Not In Stock")
                    {
                        btn.Text = "Not In Stock";
                    }
                    else if (btn.CommandName == "In Stock")
                    {
                        btn.Text = "In Stock";
                    }
                }
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
            string message = "Do you want to delete this product?";
            string title = "Delete Product";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resulting = MessageBox.Show(message, title, buttons);
            if (resulting == DialogResult.Yes)
            {
                result = prod.ProductDelete(categoryID);

                if (result > 0)
                {
                    Response.Write("<script>alert('Product Remove successfully');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Product Removal NOT successfully');</script>");
                }

                Response.Redirect("Admin_Product.aspx");
            }
            else
            {
                // Do something  
            }
        }

        private string ConvertSortDirectionToSql(SortDirection sortDirection)
        {
            string newSortDirection = String.Empty;

            switch (sortDirection)
            {
                case SortDirection.Ascending:
                    newSortDirection = "ASC";
                    break;

                case SortDirection.Descending:
                    newSortDirection = "DESC";
                    break;
            }

            return newSortDirection;
        }

        protected void gvProduct_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dataTable = gvProduct.DataSource as DataTable;

            if (dataTable != null)
            {
                DataView dataView = new DataView(dataTable);
                dataView.Sort = e.SortExpression + " " + ConvertSortDirectionToSql(e.SortDirection);

                gvProduct.DataSource = dataView;
                gvProduct.DataBind();
            }
        }

        protected void btn_Status_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //1: red   0:green

            string constr = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
            if (btn.CommandName == "Not In Stock")
            {
                btn.Text = "In Stock";
                //change red to green.
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string cmdtext = "UPDATE Products SET Status = @Status WHERE Product_ID = @ID";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = cmdtext;
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(btn.CommandArgument.ToString()));
                        cmd.Parameters.AddWithValue("@Status", "In Stock");

                        cmd.ExecuteNonQuery();

                    }
                }

            }
            else
            {
                btn.Text = "Not In Stock";
                //change green to red
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string cmdtext = "UPDATE Products SET Status = @Status WHERE Product_ID = @ID";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = cmdtext;
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(btn.CommandArgument.ToString()));
                        cmd.Parameters.AddWithValue("@Status", "Not In Stock");

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            bind(); //rebind GridView
        }

        //learn row data bound

        protected void gvProduct_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            Button btnDateRange = e.Row.FindControl("btnDateRange") as Button;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button btn = e.Row.Cells[5].Controls[1] as Button;
                string datakey = gvProduct.DataKeys[e.Row.RowIndex].Value.ToString();

                btn.Attributes["onclick"] = "javascript:document.getElementById('hdnImpressionTagID').value = '" + datakey + "'";
            }
        }
    }
}