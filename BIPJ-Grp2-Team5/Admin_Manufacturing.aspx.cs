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
    public partial class Admin_Manufacturing : System.Web.UI.Page
    {
        Manufacturing aManufacture = new Manufacturing();

        Manufacturing rep = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

       protected void bind()
            {
                List<Manufacturing> repList = new List<Manufacturing>();
                repList = aManufacture.getManufacturingAll();
                gvManufacture.DataSource = repList;
                gvManufacture.DataBind();
             }

       protected void gvManufacture_SelectedIndexChanged(object sender, EventArgs e)
            {
                GridViewRow row = gvManufacture.SelectedRow;

                int manufactureID = int.Parse(row.Cells[0].Text);
                Manufacturing bManufacturing = new Manufacturing();
                rep = bManufacturing.getManufacturing(manufactureID);
                lbl_manufacturingid.Text = rep.Manufacturing_ID.ToString();
                lbl_Order_ID.Text = rep.Order_ID.ToString();
                lbl_Prodinfo.Text = rep.Product_Info;
                lbl_Quantity.Text = rep.Quantity.ToString();
                lbl_Status.Text = rep.Status;




            if (rep.Status == "Accepted")
                {
                    rbl_status.SelectedValue = "Accepted";
                }
                else
                {
                    rbl_status.SelectedValue = "Rejected";
                }
            }

            protected void btn_submitUp_Click(object sender, EventArgs e)
            {
                int result = 0;
                Manufacturing rep = new Manufacturing();
                int id = int.Parse( lbl_manufacturingid.Text);
                int orderid = int.Parse( lbl_Order_ID.Text);
                string prodinfo = lbl_Prodinfo.Text;
                int quantity = int.Parse(lbl_Quantity.Text);
                string status = rbl_status.SelectedValue;

                result = rep.ManufacturingUpdate(id, orderid, prodinfo, quantity, status,"");
                if (result > 0)
                {
                    Response.Write("<script>alert('Form updated successfully');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Form NOT updated successfully');</script>");
                }
                bind();

            }

            //protected void gvRepair_RowDeleting(object sender, GridViewDeleteEventArgs e)
            //{
            //    int result = 0;
            //    Repair rep = new Repair();
            //    string categoryID = gvRepair.DataKeys[e.RowIndex].Value.ToString();
            //    result = rep.RepairDelete(categoryID);
            //    if (result > 0)
            //    {
            //        Response.Write("<script>alert('Product Remove successfully');</script>");
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Product Removal NOT successfully');</script>");
            //    }

            //    Response.Redirect("AdminErepair.aspx");

            //}

            protected void rbl_status_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            protected void Button3_Click(object sender, EventArgs e)
            {
                gv_openclose.Visible = true;

            }

            protected void btn_search_Click(object sender, EventArgs e)
            {
                String SearchValue = tb_search.Text;
                Manufacturing manu = new Manufacturing();
                Manufacturing SearchResult = new Manufacturing();
                List<Manufacturing> searchList = new List<Manufacturing>();
                SearchResult = manu.getManufacturing(int.Parse(SearchValue));
                searchList.Add(SearchResult);
                if (searchList.Contains(null))
                {
                    string message = "ID " + SearchValue + " does not exist. Please search another ID.";
                    string title = "Search ID";
                    DialogResult resulting = MessageBox.Show(message, title);
                }
                else
                {
                    gvManufacture.DataSource = searchList;
                    gvManufacture.DataBind();
                }
        }

    }
}