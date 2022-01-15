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
    public class Orders
    {
        string _connStr = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
        private string _orderid = null;
        private string _custname = string.Empty;
        private string _prodinfo = string.Empty;
        private decimal _price = 0;
        private string _paymentdate = string.Empty;
        //private string _sessionname = string.Empty; // if session is done in login logout
        //private string _sessionpassword = string.Empty;
        private string _status = string.Empty;


        public Orders()
        {

        }

        public Orders(string orderid, string custname, string prodinfo, decimal price,
            string paymentdate, string status)
        {
            _orderid = orderid;
            _custname = custname;
            _prodinfo = prodinfo;
            _price = price;
            _paymentdate = paymentdate;
            _status = status;
        }

        public Orders(string custname, string prodinfo, decimal price, string status, string paymentdate)
            : this(null, custname, prodinfo, price, paymentdate, status)
        {

        }

        public Orders(string orderID)
            :this(orderID,"","",0,"","")
         {
        
        
        }


        public string Order_ID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        public string Cust_Name
        {
            get { return _custname; }
            set { _custname = value; }
        }

        public string Product_Info
        {
            get { return _prodinfo; }
            set { _prodinfo = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string paymentDate
        {
            get { return _paymentdate; }
            set { _paymentdate = value; }
        }

        //public string SessionName
        //{
        //    get { return _sessionname; }
        //    set { _sessionname = value; }
        //}
        //public string SessionPassword
        //{
        //    get { return _sessionpassword; }
        //    set { _sessionpassword = value; }
        //}
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Orders getOrder(string orderID)
        {
            Orders orderdetail = null;
            string custname, prodinfo, status, PaymentDate;
            decimal price;

            string queryStr = "SELECT * FROM Orders WHERE Order_ID=@orderID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                custname = dr["Cust_Name"].ToString();
                prodinfo = dr["Product_Info"].ToString();
                price = decimal.Parse(dr["Price"].ToString());
                PaymentDate = dr["Date of purchase"].ToString();
                status = dr["Status"].ToString();

                orderdetail = new Orders(orderID, custname, prodinfo, price, status, PaymentDate);
            }
            else
            {
                orderdetail = null;
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return orderdetail;
        }

        public int OrdersInsert()
        {

            // string msg = null;
            int result = 0;

            string queryStr = "INSERT INTO Orders(Cust_Name, Product_Info, Price, Status, Date of purchase)"
                + " values (@Cust_Name, @Product_Info, @Price, @Status, @Date of purchase)";

            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Cust_Name", this.Cust_Name);
                cmd.Parameters.AddWithValue("@Product_Info", this.Product_Info);
                cmd.Parameters.AddWithValue("@Price", this.Price);
                cmd.Parameters.AddWithValue("@Date of purchase", this.paymentDate);
                cmd.Parameters.AddWithValue("@Status", this.Status);

                conn.Open();
                result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
                conn.Close();

                return result;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }//end Insert

        public List<Orders> getCheckoutAll()
        {
            List<Orders> ordersList = new List<Orders>();

            string custname, prodinfo, PaymentDate, status;
            decimal price;
            string Order_ID;


            string queryStr = "SELECT Order_ID, Cust_Name, Product_Info, Price, Status, Date of purchase" +
                " FROM Orders Order By Order_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Order_ID =dr["Order_ID"].ToString();
                custname = dr["Cust_Name"].ToString();
                prodinfo = dr["Product_Info"].ToString();
                price = decimal.Parse(dr["Price"].ToString());
                PaymentDate = dr["Date of purchase"].ToString();
                status = dr["Status"].ToString();
                Orders a = new Orders(Order_ID, custname, prodinfo, price, PaymentDate, status);
                ordersList.Add(a);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return ordersList;

        }

        //public List<Orders> getOwnCheckout(string name, string password)
        //{
        //    List<Orders> checkoutList = new List<Orders>();

        //    string FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, PaymentDate, Product, DeliveryStatus;
        //    decimal TotalAmount;
        //    string Orders_ID;


        //    string queryStr = "SELECT Orders_ID, , LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, DeliveryStatus" +
        //        " FROM Orders";

        //    SqlConnection conn = new SqlConnection(_connStr);
        //    SqlCommand cmd = new SqlCommand(queryStr, conn);
        //    cmd.Parameters.AddWithValue("@sessionname", name);
        //    cmd.Parameters.AddWithValue("@sessionpassword", password);


        //    conn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        Checkout_ID = int.Parse(dr["Checkout_ID"].ToString());
        //        FName = dr["Fname"].ToString();
        //        LName = dr["LName"].ToString();
        //        Country = dr["Country"].ToString();
        //        City = dr["City"].ToString();
        //        Address = dr["Address"].ToString();
        //        Zipcode = dr["Zipcode"].ToString();
        //        PhoneNo = dr["PhoneNo"].ToString();
        //        Comment = dr["Comment"].ToString();
        //        Product = dr["Product"].ToString();
        //        TotalAmount = decimal.Parse(dr["TotalAmount"].ToString());
        //        PaymentDate = dr["PaymentDate"].ToString();
        //        DeliveryStatus = dr["DeliveryStatus"].ToString();
        //        Checkouts a = new Checkouts(Checkout_ID, FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, DeliveryStatus);
        //        checkoutList.Add(a);
        //    }

        //    conn.Close();
        //    dr.Close();
        //    dr.Dispose();

        //    return checkoutList;

        //}

        public int ordersDelete(string ID)
        {
            string queryStr = "DELETE FROM Orders WHERE Orders_ID=@ID";

            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                conn.Open();
                int nofRow = 0;
                nofRow = cmd.ExecuteNonQuery();
                //  Response.Write("<script>alert('Delete successful');</script>");
                conn.Close();
                return nofRow;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }//end Delete

        public int checkoutUpdate(int order_ID, string custname, string prodinfo,decimal price, string status,
            string paymentdate)
        {

            string queryStr = "UPDATE Orders SET" +
                " Cust_Name = @Cust_Name, " +
                " Product_Info = @Product_Info, " +
                " Price = @Price, " +
                " Status = @Status, " +
                " paymentdate  = @Date of purchase," +
                " WHERE Order_ID = @Order_ID";

            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Order_ID", order_ID);
                cmd.Parameters.AddWithValue("@Cust_Name", custname);
                cmd.Parameters.AddWithValue("@Product_Info", prodinfo);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Date of purchase", paymentdate);
                cmd.Parameters.AddWithValue("@tatus", status);


                conn.Open();
                int nofRow = 0;
                nofRow = cmd.ExecuteNonQuery();

                conn.Close();

                return nofRow;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }//end Update
    }
}