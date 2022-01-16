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
    public class Product
    {
        //Private string _connStr = Properties.Settings.Default.DBConnStr;

        //System.Configuration.ConnectionStringSettings _connStr;
        string _connStr = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
        private string _prodID = null;
        private string _prodName = string.Empty;
        private string _prodDesc = ""; // this is another way to specify empty string
        private decimal _prodPrice = 0;
        private string _prodImage = "";
        private decimal _discount = 0;
        private string _status = "";
        private int _stklvl = 0;

        // Default constructor
        public Product()
        {
        }

        // Constructor that take in all data required to build a Product object
        public Product(string prodID, string prodName, decimal prodPrice, string prodDesc, string prodImage, decimal discount, string status, int stocklevel)
        {
            _prodID = prodID;
            _prodName = prodName;
            _prodPrice = prodPrice;
            _prodDesc = prodDesc;
            _prodImage = prodImage;
            _discount = discount;
            _status = status;
            _stklvl = stocklevel;
        }

        // Constructor that take in all except product ID
        public Product(string prodName, decimal prodPrice, string prodDesc, string prodImage, decimal discount, string status, int stocklevel)
            : this(null, prodName, prodPrice, prodDesc, prodImage, discount, status, stocklevel)
        {
        }

        // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
        public Product(string prodID)
            : this(prodID, "", 0, "", "", 0, "", 0)
        {
        }

        // Get/Set the attributes of the Product object.
        // Note the attribute name (e.g. Product_ID) is same as the actual database field name.
        // This is for ease of referencing.
        public string Product_ID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }
        public string Product_Name
        {
            get { return _prodName; }
            set { _prodName = value; }
        }
        public decimal Product_Price
        {
            get { return _prodPrice; }
            set { _prodPrice = value; }
        }
        public string Product_Desc
        {
            get { return _prodDesc; }
            set { _prodDesc = value; }
        }
        public string Product_Image
        {
            get { return _prodImage; }
            set { _prodImage = value; }
        }
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public int Stock_Lvl
        {
            get { return _stklvl; }
            set { _stklvl = value; }
        }

        //Below as the Class methods for some DB operations. 
        public Product getProduct(string prodID)
        {

            Product prodDetail = null;

            string prod_Name, prod_Desc, prod_Image, status;
            decimal prod_Price, discount;
            int stocklevel;

            string queryStr = "SELECT * FROM Products WHERE Product_ID = @ProdID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@ProdID", prodID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                prod_Name = dr["Product_Name"].ToString();
                prod_Price = decimal.Parse(dr["Product_Price"].ToString());
                prod_Desc = dr["Product_Desc"].ToString();
                prod_Image = dr["Product_Img"].ToString();
                discount = decimal.Parse(dr["Discount"].ToString());
                status = dr["Status"].ToString();
                stocklevel = int.Parse(dr["Stock_Lvl"].ToString());

                prodDetail = new Product(prodID, prod_Name, prod_Price, prod_Desc, prod_Image, discount, status, stocklevel);
            }
            else
            {
                prodDetail = null;
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return prodDetail;
        }

        public List<Product> getProductAll()
        {
            List<Product> prodList = new List<Product>();

            string prod_ID, prod_Name, prod_Desc, prod_Image, status;
            decimal prod_Price, discount;
            int stklvl;

            string queryStr = "SELECT * FROM Products Order By Product_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                prod_ID = dr["Product_ID"].ToString();
                prod_Name = dr["Product_Name"].ToString();
                prod_Price = decimal.Parse(dr["Product_Price"].ToString());
                prod_Desc = dr["Product_Desc"].ToString();
                prod_Image = dr["Product_Img"].ToString();
                discount = decimal.Parse(dr["Discount"].ToString());
                status = dr["Status"].ToString();
                stklvl = int.Parse(dr["Stock_Lvl"].ToString());
                Product a = new Product(prod_ID, prod_Name, prod_Price, prod_Desc, prod_Image, discount, status, stklvl);
                prodList.Add(a);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return prodList;
        }

        public int ProductInsert()
        {
            // string msg = null;
            int result = 0;

            string queryStr = "INSERT INTO Products(Product_ID, Product_Name, Product_Price, Product_Desc, Product_Img, Discount, Status, Stock_Lvl)"
                + " values (@Product_ID,@Product_Name, @Product_Price, @Product_Desc, @Product_Image, @Discount, @Status, @StkLvl)";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Product_ID", this.Product_ID);
            cmd.Parameters.AddWithValue("@Product_Name", this.Product_Name);
            cmd.Parameters.AddWithValue("@Product_Price", this.Product_Price);
            cmd.Parameters.AddWithValue("@Product_Desc", this.Product_Desc);
            cmd.Parameters.AddWithValue("@Product_Image", this.Product_Image);
            cmd.Parameters.AddWithValue("@Discount", this.Discount);
            cmd.Parameters.AddWithValue("@Status", "Not In Stock");
            cmd.Parameters.AddWithValue("@StkLvl", 0);

            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();

            return result;

        }//end Insert

        public int ProductDelete(string ID)
        {
            string queryStr = "DELETE FROM Products WHERE Product_ID=@ID";
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            conn.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();
            //Response.Write("<script>alert('Delete successful');</script>");
            conn.Close();
            return nofRow;

        }//end Delete


        public int ProductUpdate(string pId, string pName, decimal pPrice, string pDesc, string pImage, string pDiscount, string pStatus)
        {
            string queryStr = "UPDATE Products SET" + " Product_Name = @productName, " + " Product_Price = @productPrice, " + " Product_Desc = @productDesc, " + " Product_Img = @productImg, " + " Discount = @discount, " + " Status = @status" + " WHERE Product_ID = @productID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@productID", pId);
            cmd.Parameters.AddWithValue("@productName", pName);
            cmd.Parameters.AddWithValue("@productPrice", pPrice);
            cmd.Parameters.AddWithValue("@productDesc", pDesc);
            cmd.Parameters.AddWithValue("@productImg", pImage);
            cmd.Parameters.AddWithValue("@discount", pDiscount);
            cmd.Parameters.AddWithValue("@status", pStatus);

            conn.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();

            conn.Close();

            return nofRow;
        }//end Update

    }
}