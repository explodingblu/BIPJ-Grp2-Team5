using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BIPJ_Grp2_Team5
{
    public partial class Admin_User : System.Web.UI.Page
    {
        Customer aCust = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bind();
            }
            lbl_SortDr.Text = "Ascending";
            lbl_NotFound.Visible = false;
        }

        string _connStr = ConfigurationManager.ConnectionStrings["RiftDBContext"].ConnectionString;

        protected void bind()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(_connStr);
            string query = "SELECT * FROM Customers ORDER BY " + this.SortColumn + " " + this.SortDirection;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                gv_Customer.DataSource = dt;
                gv_Customer.DataBind();
            }
        }

        protected void gv_Customer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int nofRow = 0;
            Customer cust = new Customer();
            string custID = gv_Customer.DataKeys[e.RowIndex].Value.ToString();
            nofRow = cust.CustomerDelete(custID);

            if (nofRow > 0)
            {
                Response.Write("<script>alert('Customer has been deleted!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Unable to delete customer!');</script>");
            }

            Response.Redirect("AdminCustomer.aspx");
        }

        protected void gv_Customer_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_Customer.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void gv_Customer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_Customer.EditIndex = -1;
            bind();
        }

        protected void gv_Customer_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int nofRow = 0;
            Customer cust = new Customer();
            GridViewRow row = (GridViewRow)gv_Customer.Rows[e.RowIndex];
            string id = gv_Customer.DataKeys[e.RowIndex].Value.ToString();
            string tname = ((TextBox)row.Cells[1].Controls[0]).Text;
            /*            string temail = ((TextBox)row.Cells[2].Controls[0]).Text;
            */
            string thp = ((TextBox)row.Cells[4].Controls[0]).Text;

            nofRow = cust.CustomerUpdate(id, tname, thp);
            if (nofRow > 0)
            {
                Response.Write("<script>alert('Customer updated successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Customer NOT updated');</script>");
            }
            Response.Redirect("AdminCustomer.aspx");
            gv_Customer.EditIndex = -1;
            bind();
        }

        protected void gv_Customer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton DeleteLB = (LinkButton)e.Row.FindControl("DeleteLB");

                DeleteLB.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this Customer, " +
                DataBinder.Eval(e.Row.DataItem, "Name") + "')");
            }
        }

        protected void gv_Customer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_Customer.PageIndex = e.NewPageIndex;
            bind();
        }

        private string SortColumn
        {
            get { return ViewState["SortColumn"] != null ? ViewState["SortColumn"].ToString() : "Name"; }
            set { ViewState["SortColumn"] = value; }
        }

        private string SortDirection
        {
            get { return ViewState["SortDirection"] != null ? ViewState["SortDirection"].ToString() : "ASC"; }
            set { ViewState["SortDirection"] = value; }
        }

        protected void gv_Customer_Sorting(object sender, GridViewSortEventArgs e)
        {
            this.SortDirection = this.SortDirection == "ASC" ? "DESC" : "ASC";
            this.SortColumn = e.SortExpression;
            if (SortDirection.ToString() == "ASC")
            {
                lbl_SortDr.Text = "Ascending";
            }
            else
            {
                lbl_SortDr.Text = "Descending";
            }
            this.bind();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            conn.Open();

            //create search command to retrieve data from table
            string checksearch = "SELECT COUNT(*) FROM [Customers] WHERE Name LIKE @search OR Hp LIKE @search";
            SqlCommand com = new SqlCommand(checksearch, conn);

            //declare @search
            com.Parameters.AddWithValue("@search", tb_SearchResult.Text);
            com.Parameters["@search"].Value = "%" + tb_SearchResult.Text + "%";

            //use temp to create a fucntion
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            //close the connection
            conn.Close();
            //if the record exists
            if (temp > 0)
            {
                string strCommandText = "SELECT *";
                strCommandText += " FROM Customers WHERE Name LIKE @Name OR Hp LIKE @Hp";
                SqlCommand cmd = new SqlCommand(strCommandText, conn);

                //declare cmd parameters for title and author to be dispayed
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50);
                cmd.Parameters["@name"].Value = "%" + tb_SearchResult.Text + "%";
                cmd.Parameters.Add("@hp", SqlDbType.NVarChar, 50);
                cmd.Parameters["@hp"].Value = "%" + tb_SearchResult.Text + "%";

                //open the connection
                conn.Open();

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "Name");
                gv_Customer.DataSource = ds;
                gv_Customer.DataBind();

                //close the connection
                conn.Close();
            }

            //else record does not exist
            else
            {
                lbl_NotFound.Visible = true;
            }
        }

        protected void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_SearchResult.Text = "";
            bind();
        }
    }
}