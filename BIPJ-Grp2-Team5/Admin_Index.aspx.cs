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
    public partial class Admin_Index : System.Web.UI.Page
    {
        string mainconn = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
        //retrieve counts
        protected void Page_Load(object sender, EventArgs e)
        {

            int a, b, c, total;

            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();

            //products
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT COUNT(Product_ID)FROM Products";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            lbl_ProductCounts.Text = sqlcomm.ExecuteScalar().ToString();

            //employees(admins) *awaiting elstons parts*
            //string sqlquery1 = "SELECT COUNT(Admin_ID)FROM AdminUsers";
            //sqlcomm.CommandText = sqlquery1;
            //sqlcomm.Connection = sqlconn;
            //lbl_UserCounts.Text = sqlcomm.ExecuteScalar().ToString();

            //orders
            string sqlquery2 = "SELECT COUNT(Order_ID)FROM Orders";
            sqlcomm.CommandText = sqlquery2;
            sqlcomm.Connection = sqlconn;
            lbl_OrdersCount.Text = sqlcomm.ExecuteScalar().ToString();

            //sum manufacturing , education and contact us *await finish of datas* 
            //a = int.Parse(lbl_ContactusCount.Text);
            //b = int.Parse(lbl_EconsultCount.Text);
            //c = int.Parse(lbl_RepairCount.Text);
            //total = a + b + c;
            //lbl_NotificationsCount.Text = total.ToString();


            sqlconn.Close();

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //sqlconn.Open();
            //SqlCommand sqlcomm = new SqlCommand();
            //Label1.Text = "Stock level as at: " + DateTime.Now.ToLongTimeString();
            //string sqlquery = "SELECT SUM(Stock_level)FROM Product ";
            //sqlcomm.CommandText = sqlquery;
            //sqlcomm.Connection = sqlconn;
            //lbl_StockLevel.Text = sqlcomm.ExecuteScalar().ToString() + " Items in warehouse";


            //string sqlquery1 = "SELECT SUM(Stock_level)FROM Product where Category = @Phonecategory ";
            //sqlcomm.Parameters.AddWithValue("@Phonecategory", "Phone");
            //sqlcomm.CommandText = sqlquery1;
            //sqlcomm.Connection = sqlconn;
            //lbl_Phonecount.Text = "Phone Count: " + sqlcomm.ExecuteScalar().ToString();

            //string sqlquery2 = "SELECT SUM(Stock_level)FROM Product where Category = @Mousecategory ";
            //sqlcomm.Parameters.AddWithValue("@Mousecategory", "Mouse");
            //sqlcomm.CommandText = sqlquery2;
            //sqlcomm.Connection = sqlconn;
            //lbl_Mousecount.Text = "Mouse Count: " + sqlcomm.ExecuteScalar().ToString();

            //string sqlquery3 = "SELECT SUM(Stock_level)FROM Product where Category = @Keyboardcategory ";
            //sqlcomm.Parameters.AddWithValue("@Keyboardcategory", "Keyboard");
            //sqlcomm.CommandText = sqlquery3;
            //sqlcomm.Connection = sqlconn;
            //lbl_Keyboardcount.Text = "Keyboard Count: " + sqlcomm.ExecuteScalar().ToString();

            //string sqlquery4 = "SELECT SUM(Stock_level)FROM Product where Category = @Headsetcategory ";
            //sqlcomm.Parameters.AddWithValue("@Headsetcategory", "Headset");
            //sqlcomm.CommandText = sqlquery4;
            //sqlcomm.Connection = sqlconn;
            //lbl_Headsetcoun.Text = "Headset Count: " + sqlcomm.ExecuteScalar().ToString();

            //sqlconn.Close();

        }
    }
}