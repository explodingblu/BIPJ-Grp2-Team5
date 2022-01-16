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
    public partial class Admin_Orders : System.Web.UI.Page
    {
        Checkout aCheckout = new Checkout();
        Checkout order = null;
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
            checkoutList = aCheckout.getCheckoutAll();
            Gv_Orders.DataSource = checkoutList;
            Gv_Orders.DataBind();
        }

        protected void Gv_Orders_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int result = 0;
            Checkout order = new Checkout();
            string orderID = Gv_Orders.DataKeys[e.RowIndex].Value.ToString();
            GridViewRow row = (GridViewRow)Gv_Orders.Rows[e.RowIndex];
            string deliverystatus = ((TextBox)row.Cells[11].Controls[0]).Text;
            result = order.checkoutDelete(orderID);

            if (result > 0 && deliverystatus =="delivered") // admin can only remove the delivered ones
            {
                Response.Write("<script>alert('Order Remove successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Order Removal NOT successfully');</script>");
            }
            bind();

        }

        protected void Gv_Orders_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Gv_Orders.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void Gv_Orders_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Gv_Orders.EditIndex = -1;
            bind();
        }

        protected void Gv_Orders_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int result = 0;
            Checkout order = new Checkout();
            GridViewRow row = (GridViewRow)Gv_Orders.Rows[e.RowIndex];
            string order_ID = ((TextBox)row.Cells[0].Controls[0]).Text;
            string fname = ((TextBox)row.Cells[1].Controls[0]).Text;
            string lname = ((TextBox)row.Cells[2].Controls[0]).Text;
            string country = ((TextBox)row.Cells[3].Controls[0]).Text;
            string city = ((TextBox)row.Cells[4].Controls[0]).Text;
            string address = ((TextBox)row.Cells[5].Controls[0]).Text;
            string zipcode = ((TextBox)row.Cells[6].Controls[0]).Text;
            string phoneno = ((TextBox)row.Cells[7].Controls[0]).Text;
            string comment = ((TextBox)row.Cells[8].Controls[0]).Text;
            string totalamt = ((TextBox)row.Cells[10].Controls[0]).Text;
            string paymentdate = ((TextBox)row.Cells[11].Controls[0]).Text;
            string deliverystatus = ((TextBox)row.Cells[12].Controls[0]).Text;



            result = order.checkoutUpdate(int.Parse(order_ID), fname, lname, country, city, address, zipcode,
                            phoneno, comment, decimal.Parse(totalamt),paymentdate, deliverystatus);
            if (result > 0)
            {
                Response.Write("<script>alert('Orders updated successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Orders NOT updated');</script>");
            }
            Gv_Orders.EditIndex = -1;
            bind();
        }

        protected void btn_submitUp_Click(object sender, EventArgs e)
        {
            int result = 0;
            Checkout order = new Checkout();
            int id = int.Parse(lbl_orderid.Text);
            string fname = lbl_fname.Text;
            string lname = lbl_lname.Text;
            string country = lbl_country.Text;
            string city = lbl_city.Text;
            string address = lbl_address.Text;
            string zipcode = lbl_zipcode.Text;
            string hp = lbl_phoneno.Text;
            string comments = lbl_comment.Text;
            decimal totalamt = decimal.Parse(lbl_totalamt.Text);
            string date = lbl_date.Text;
            string status = rbl_status.SelectedValue;






            result = order.checkoutUpdate(id, fname, lname, country, city, address, zipcode, hp, comments, totalamt, date, status);
            if (result > 0)
            {
                Response.Write("<script>alert(' Status updated successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Status NOT updated successfully');</script>");
            }
            bind();
        }

        protected void Gv_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = Gv_Orders.SelectedRow;

            string orderID = row.Cells[0].Text;
            Checkout aOrders = new Checkout();
            order = aOrders.getOrder(orderID);

            lbl_orderid.Text = order.Order_ID.ToString();
            lbl_fname.Text = order.FName;
            lbl_lname.Text = order.LName;
            lbl_country.Text = order.Country;
            lbl_city.Text = order.City;
            lbl_address.Text = order.Address;
            lbl_zipcode.Text = order.Zipcode;
            lbl_phoneno.Text = order.PhoneNo;
            lbl_comment.Text = order.Comment;
            lbl_products.Text = order.Product;
            lbl_totalamt.Text = order.TotalAmount.ToString();
            lbl_date.Text = order.PaymentDate;
            rbl_status.Text = order.DeliveryStatus;


            if (order.DeliveryStatus == "Undelivered")
            {
                rbl_status.SelectedValue = "Undelivered";
                
            }
            else if (order.DeliveryStatus == "In Transit")
            {
                rbl_status.SelectedValue = "In Transit";
            }
            else if (order.DeliveryStatus == "Delivered")
            {

                rbl_status.SelectedValue = "Delivered";
                rbl_status.Enabled = false;
            }
            else
            {
                rbl_status.SelectedValue = "Awaiting Design";

            }




        }

        protected void gv_OrderSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "select * from Orders where Order_ID like '%'+@Order_ID+'%' ";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            sqlcomm.Parameters.AddWithValue("@Order_ID", tb_search.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            gv_OrderSearch.DataSource = dt;
            gv_OrderSearch.DataBind();

            sqlconn.Close();
            tb_search.Text = "";
        }
    }
}
