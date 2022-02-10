using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RIFT_New
{
    public partial class AdminDetails : System.Web.UI.Page
    {
        Admin aAdmin = new Admin();
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
            string query = "SELECT * FROM Admin ORDER BY " + this.SortColumn + " " + this.SortDirection;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                gv_Admin.DataSource = dt;
                gv_Admin.DataBind();
            }
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

        protected void gv_Admin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int nofRow = 0;
            Admin admin = new Admin();
            string adminID = gv_Admin.DataKeys[e.RowIndex].Value.ToString();
            nofRow = admin.DeleteAdmin(adminID);

            if (nofRow > 0)
            {
                Response.Write("<script>alert('Admin has been deleted!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Unable to delete admin!');</script>");
            }

            Response.Redirect("AdminDetails.aspx");
        }

        protected void gv_Admin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_Admin.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void gv_Admin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int nofRow = 0;
            Admin admin = new Admin();
            GridViewRow row = (GridViewRow)gv_Admin.Rows[e.RowIndex];
            string id = gv_Admin.DataKeys[e.RowIndex].Value.ToString();
            string tname = ((TextBox)row.Cells[1].Controls[0]).Text;

            nofRow = admin.UpdateAdmin(id, tname);
            if (nofRow > 0)
            {
                Response.Write("<script>alert('Admin updated successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Admin NOT updated');</script>");
            }
            Response.Redirect("AdminDetails.aspx");
            gv_Admin.EditIndex = -1;
            bind();
        }

        protected void gv_Admin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_Admin.EditIndex = -1;
            bind();
        }

        protected void gv_Admin_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton DeleteLB = (LinkButton)e.Row.FindControl("DeleteLB");

                DeleteLB.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this admin, " +
                DataBinder.Eval(e.Row.DataItem, "Name") + "')");
            }
        }

        protected void gv_Admin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_Admin.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void gv_Admin_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminRegister.aspx");
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            conn.Open();

            //create search command to retrieve data from table
            string checksearch = "SELECT COUNT(*) FROM [Admin] WHERE AdminID LIKE @search OR Name LIKE @search";
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
                strCommandText += " FROM Admin WHERE AdminID LIKE @AdminID OR Name LIKE @Name";
                SqlCommand cmd = new SqlCommand(strCommandText, conn);

                //declare cmd parameters for title and author to be dispayed
                cmd.Parameters.Add("@AdminID", SqlDbType.NVarChar, 50);
                cmd.Parameters["@AdminID"].Value = "%" + tb_SearchResult.Text + "%";
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                cmd.Parameters["@Name"].Value = "%" + tb_SearchResult.Text + "%";

                //open the connection
                conn.Open();

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "Name");
                gv_Admin.DataSource = ds;
                gv_Admin.DataBind();

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