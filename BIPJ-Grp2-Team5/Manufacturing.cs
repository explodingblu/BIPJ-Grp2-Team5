using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BIPJ_Grp2_Team5
{
    public class Manufacturing
    {
        string _connStr = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
        private int _manufacturingid = 0;
        private int _orderid = 0;
        private string _prodInfo = "";
        private string _prodImage = "";
        private int _quantity = 0;
        private string _status = "";


        public Manufacturing()
        {
        }

        public Manufacturing(int manufacturingid, int orderid, string prodinfo, int quantity, string status, string prodImage)
        {
            _manufacturingid = manufacturingid;
            _orderid = orderid;
            _prodInfo = prodinfo;
            _prodImage = prodImage;
            _quantity = quantity;
            _status = status;
        }

        public Manufacturing(int orderid, string prodinfo, int quantity, string status, string prodImage)
            : this(0, orderid, prodinfo, quantity, status, prodImage)
        {
        }

        public Manufacturing(string manufacturingid)
            : this(int.Parse(manufacturingid), 0, "", 0, "","")
        {
        }

        public int Manufacturing_ID
        {
            get { return _manufacturingid; }
            set { _manufacturingid = value; }
        }

        public int Order_ID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        public string Product_Info
        {
            get { return _prodInfo; }
            set { _prodInfo = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Product_Image
        {
            get { return _prodImage; }
            set { _prodImage = value; }
        }

        public Manufacturing getManufacturing(int manufacturingid)
        {
            Manufacturing mDetail = null;
            string prodinfo, Status, prod_Image;
            int orderid,quantity;

            string queryStr = "SELECT * FROM Manufacturing WHERE Manufacturing_ID=@Manufacturing_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Manufacturing_ID", manufacturingid);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                orderid = int.Parse(dr["Order_ID"].ToString());
                prodinfo = dr["Product_Info"].ToString();
                quantity = int.Parse(dr["Quantity"].ToString());
                Status = dr["Status"].ToString();
                prod_Image = dr["Product_Img"].ToString();
                mDetail = new Manufacturing(manufacturingid, orderid, prodinfo, quantity,Status, prod_Image);
            }
            else
            {
                mDetail = null;
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return mDetail;
        }

        public List<Manufacturing> getManufacturingAll()
        {
            List<Manufacturing> repList = new List<Manufacturing>();

            string prodinfo, Status, prod_Image;
            int manufacturingid,orderid, quantity;

            string queryStr = "SELECT * FROM Manufacturing Order By Manufacturing_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                manufacturingid = int.Parse(dr["Manufacturing_ID"].ToString());
                orderid = int.Parse(dr["Order_ID"].ToString());
                prodinfo = dr["Product_Info"].ToString();
                quantity = int.Parse(dr["Quantity"].ToString());
                Status = dr["Status"].ToString();
                prod_Image = dr["Product_Img"].ToString();
                Manufacturing a = new Manufacturing(manufacturingid, orderid, prodinfo, quantity,Status,prodinfo);
                repList.Add(a);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return repList;
        }

        //public int A()
        //{
        //    string stmt = "SELECT COUNT(*) FROM Repair";
        //    int count = 0;

        //    using (SqlConnection conn = new SqlConnection(_connStr))
        //    {
        //        using (SqlCommand cmdCount = new SqlCommand(stmt, conn))
        //        {
        //            conn.Open();
        //            count = (int)cmdCount.ExecuteScalar();
        //        }
        //    }
        //    return count;
        //}

        public int ManufacturingInsert()
        {
            //int lastId = 0;
            //int count = A();
            int result = 0;

            string queryStr = "INSERT INTO Manufacturing(Order_ID, Product_Info, Quantity,Status,Product_Img)"
                + " values (@Order_ID, @Product_Info,@Quantity, @Status,@Product_Img)";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Order_ID", this.Order_ID);
            cmd.Parameters.AddWithValue("@Product_Info", this.Product_Info);
            cmd.Parameters.AddWithValue("@Quantity", this.Quantity);
            cmd.Parameters.AddWithValue("@Status", this.Status);
            cmd.Parameters.AddWithValue("@Product_Image", this.Product_Image);

            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();

            return result;
        }//end Insert

        public int ManufacturingUpdate(int manufacturingid, int orderid, string prodinfo, int quantity, string status, string prodimg)
        {
            string queryStr = "UPDATE Manufacturing SET" +
                " Product_info = @Product_info," +
                " Quantity = @Quantity," +
                " Status = @Status" +
                " Product_Img = @Product_Img"+
                " WHERE Manufacturing_ID = @Manufacturing_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Manufacturing_ID", manufacturingid);
            cmd.Parameters.AddWithValue("@Order_ID", orderid);
            cmd.Parameters.AddWithValue("@Product_Info", prodinfo);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Product_Image", prodimg);


            conn.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();

            conn.Close();

            return nofRow;
        }//end Update

        public int ManufacturingDelete(string ID)
        {
            string queryStr = "DELETE FROM Manufacturing WHERE Manufacturing=@Manufacturing_ID";
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Manufacturing_ID", ID);
            conn.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();
            //  Response.Write("<script>alert('Delete successful');</script>");
            conn.Close();
            return nofRow;

        }//end Delete



    }


}
