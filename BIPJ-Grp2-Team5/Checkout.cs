using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BIPJ_Grp2_Team5
{
    public class Checkout
    {
        string _connStr = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
        private int _orderid = 0;
        private string _fname = string.Empty;
        private string _lname = string.Empty;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _address = string.Empty;
        private string _zipcode = string.Empty;
        private string _phone = string.Empty;
        private string _comment = string.Empty;
        private string _product = string.Empty;
        private decimal _totalamt = 0;
        private string _paymentdate = string.Empty;
        private string _cardnumber = string.Empty;
        private string _sessionname = string.Empty;
        private string _deliverystatus = string.Empty;


        public Checkout()
        {

        }

        public Checkout(int orderid, string fname, string lname, string country,
            string city, string address, string zipcode, string phone, string comment, string product, decimal totalamt,
            string paymentdate, string cardnumber, string sessionname, string deliverystatus)
        {
            _orderid = orderid;
            _fname = fname;
            _lname = lname;
            _country = country;
            _city = city;
            _address = address;
            _zipcode = zipcode;
            _phone = phone;
            _comment = comment;
            _product = product;
            _totalamt = totalamt;
            _paymentdate = paymentdate;
            _cardnumber = cardnumber;
            _sessionname = sessionname;
            _deliverystatus = deliverystatus;
        }

        public Checkout(int orderid, string fname, string lname, string country,
            string city, string address, string zipcode, string phone, string comment, string product, decimal totalamt,
            string paymentdate, string cardnumber, string deliverystatus)
            : this(orderid, fname, lname, country, city, address, zipcode, phone, comment, product, totalamt, paymentdate, cardnumber, null, deliverystatus)
        {
        }


        public int Order_ID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        public string FName
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public string LName
        {
            get { return _lname; }
            set { _lname = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }
        public string PhoneNo
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public decimal TotalAmount
        {
            get { return _totalamt; }
            set { _totalamt = value; }
        }
        public string PaymentDate
        {
            get { return _paymentdate; }
            set { _paymentdate = value; }
        }

        public string CardNumber
        {
            get { return _cardnumber; }
            set { _cardnumber = value; }
        }

        public string SessionName
        {
            get { return _sessionname; }
            set { _sessionname = value; }
        }


        public string DeliveryStatus
        {
            get { return _deliverystatus; }
            set { _deliverystatus = value; }
        }

        public Checkout getOrder(string orderID)
        {
            Checkout orderdetail = null;
            string FName, LName, Country, City, Address, Zipcode, phoneno, Comment, Product, PaymentDate, CardNumber, DeliveryStatus;
            decimal TotalAmount;

            string queryStr = "SELECT * FROM Orders WHERE Order_ID=@Order_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Order_ID", orderID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FName = dr["FName"].ToString();
                LName = dr["FName"].ToString();
                Country = dr["Country"].ToString();
                City = dr["City"].ToString();
                Address = dr["Address"].ToString();
                Zipcode = dr["Zipcode"].ToString();
                phoneno = dr["PhoneNo"].ToString();
                Comment = dr["Comment"].ToString();
                Product = dr["Product"].ToString();
                TotalAmount = decimal.Parse(dr["TotalAmount"].ToString());
                PaymentDate = dr["PaymentDate"].ToString();
                CardNumber = dr["CardNumber"].ToString();
                DeliveryStatus = dr["DeliveryStatus"].ToString();

                orderdetail = new Checkout(int.Parse(orderID), FName, LName, Country, City, Address, Zipcode, phoneno, Comment, Product, TotalAmount, PaymentDate, CardNumber, DeliveryStatus);
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

        public int CheckoutInsert()
        {

            // string msg = null;
            int result = 0;

            string queryStr = "INSERT INTO Orders(FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, CardNumber, Session_Name, DeliveryStatus)"
                + " values (@FName, @LName, @Country, @City, @Address, @Zipcode, @PhoneNo, @Comment, @Product, @TotalAmount, @PaymentDate, @CardNumber, @Session_Name, @DeliveryStatus)";

            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@FName", this.FName);
                cmd.Parameters.AddWithValue("@LName", this.LName);
                cmd.Parameters.AddWithValue("@Country", this.Country);
                cmd.Parameters.AddWithValue("@City", this.City);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@Zipcode", this.Zipcode);
                cmd.Parameters.AddWithValue("@PhoneNo", this.PhoneNo);
                cmd.Parameters.AddWithValue("@Comment", this.Comment);
                cmd.Parameters.AddWithValue("@Product", this.Product);
                cmd.Parameters.AddWithValue("@TotalAmount", this.TotalAmount);
                cmd.Parameters.AddWithValue("@PaymentDate", this.PaymentDate);
                cmd.Parameters.AddWithValue("@CardNumber", this.CardNumber);
                cmd.Parameters.AddWithValue("@Session_Name", this.SessionName);
                cmd.Parameters.AddWithValue("@DeliveryStatus", this.DeliveryStatus);

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

        public List<Checkout> getCheckoutAll()
        {
            List<Checkout> checkoutList = new List<Checkout>();

            string FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, PaymentDate, CardNumber, Product, DeliveryStatus;
            decimal TotalAmount;
            int Order_ID;


            string queryStr = "SELECT Order_ID, FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, CardNumber, DeliveryStatus" +
                " FROM Orders Order By Order_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Order_ID = int.Parse(dr["Order_ID"].ToString());
                FName = dr["Fname"].ToString();
                LName = dr["LName"].ToString();
                Country = dr["Country"].ToString();
                City = dr["City"].ToString();
                Address = dr["Address"].ToString();
                Zipcode = dr["Zipcode"].ToString();
                PhoneNo = dr["PhoneNo"].ToString();
                Comment = dr["Comment"].ToString();
                Product = dr["Product"].ToString();
                TotalAmount = decimal.Parse(dr["TotalAmount"].ToString());
                PaymentDate = dr["PaymentDate"].ToString();
                CardNumber = dr["CardNumber"].ToString();
                DeliveryStatus = dr["DeliveryStatus"].ToString();
                Checkout a = new Checkout(Order_ID, FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, CardNumber, DeliveryStatus);
                checkoutList.Add(a);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return checkoutList;

        }
        public int checkoutUpdate(int order_ID, string fname, string lname, string country, string city,
                string address, string zipcode, string phoneno, string comment, decimal totalamt,
                string paymentdate, string deliverystatus)
        {

            string queryStr = "UPDATE Orders SET" +
                " FName = @fname, " +
                " LName = @lname, " +
                " Country = @country, " +
                " City = @city, " +
                " Address = @address, " +
                " Zipcode = @zipcode, " +
                " PhoneNo = @phoneno, " +
                " Comment = @comment, " +
                " TotalAmount = @totalamt, " +
                " PaymentDate = @paymentdate," +
                " DeliveryStatus = @deliverystatus " +
                " WHERE Order_ID = @order_ID";

            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Order_ID", order_ID);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@zipcode", zipcode);
                cmd.Parameters.AddWithValue("@phoneno", phoneno);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@totalamt", totalamt);
                cmd.Parameters.AddWithValue("@paymentdate", paymentdate);
                cmd.Parameters.AddWithValue("@deliverystatus", deliverystatus);


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

        //public List<Checkout> getOwnCheckout(string name, string password)
        //{
        //    List<Checkout> checkoutList = new List<Checkout>();

        //    string FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, PaymentDate, Product, DeliveryStatus;
        //    decimal TotalAmount;
        //    int ;


        //    string queryStr = "SELECT , FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, DeliveryStatus" +
        //        " FROM Checkout WHERE Session_Name=@sessionname Order By DeliveryStatus DESC";

        //    SqlConnection conn = new SqlConnection(_connStr);
        //    SqlCommand cmd = new SqlCommand(queryStr, conn);
        //    cmd.Parameters.AddWithValue("@sessionname", name);


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
        //        Checkout a = new Checkout(Checkout_ID, FName, LName, Country, City, Address, Zipcode, PhoneNo, Comment, Product, TotalAmount, PaymentDate, DeliveryStatus);
        //        checkoutList.Add(a);
        //    }

        //    conn.Close();
        //    dr.Close();
        //    dr.Dispose();

        //    return checkoutList;

        //}

        public int checkoutDelete(string ID)
        {
            string queryStr = "DELETE FROM Orders WHERE Order_ID=@ID";

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


    }
}