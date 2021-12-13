using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        private int _stockLevel = 0;
        private decimal _discount = 0;

        // Default constructor
        public Product()
        {
        }

        // Constructor that take in all data required to build a Product object
        public Product(string prodID, string prodName, decimal prodPrice, string prodDesc, string prodImage, int stockLevel, decimal discount)
        {
            _prodID = prodID;
            _prodName = prodName;
            _prodPrice = prodPrice;
            _prodDesc = prodDesc;
            _prodImage = prodImage;
            _stockLevel = stockLevel;
            _discount = discount;
        }

        // Constructor that take in all except product ID
        public Product(string prodName, decimal prodPrice, string prodDesc, string prodImage, int stockLevel, decimal discount)
            : this(null, prodName, prodPrice, prodDesc, prodImage, stockLevel, discount)
        {
        }

        // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
        public Product(string prodID)
            : this(prodID, "", 0, "", "", 0, 0)
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
        public int Stock_Level
        {
            get { return _stockLevel; }
            set { _stockLevel = value; }
        }
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        //Below as the Class methods for some DB operations. 
        public Product getProduct(string prodID)
        {

            Product prodDetail = null;

            string prod_Name, prod_Desc, prod_Image;
            decimal prod_Price, discount;
            int stock_Level;

            string queryStr = "SELECT * FROM Products WHERE Product_ID = @ProdID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@ProdID", prodID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                prod_Name = dr["Product_Name"].ToString();
                prod_Price = decimal.Parse(dr["Unit_Price"].ToString());
                prod_Desc = dr["Product_Desc"].ToString();
                prod_Image = dr["Product_Image"].ToString();
                stock_Level = int.Parse(dr["Stock_Level"].ToString());
                discount = decimal.Parse(dr["Discount"].ToString());

                prodDetail = new Product(prodID, prod_Name, prod_Price, prod_Desc, prod_Image, stock_Level, discount);
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

            string prod_ID, prod_Name, prod_Desc, prod_Image;
            decimal prod_Price, discount;
            int stock_Level;

            string queryStr = "SELECT * FROM Products Order By Product_Name";

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
                stock_Level = int.Parse(dr["Stock_Lvl"].ToString());
                discount = decimal.Parse(dr["Discount"].ToString());
                Product a = new Product(prod_ID, prod_Name, prod_Price, prod_Desc, prod_Image, stock_Level,  discount);
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

            string queryStr = "INSERT INTO Products(Product_ID, Product_Name, Product_Price, Product_Desc, Product_Img, Stock_Lvl, Discount)"
                + " values (@Product_ID,@Product_Name, @Product_Price, @Product_Desc, @Product_Image, @Stock_Level, @Discount)";
            //+ "values (@Product_ID,@Product_Name, @Product_Price, @Product_Desc, @Product_Image, @Stock_Level, @Discount)";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Product_ID", this.Product_ID);
            cmd.Parameters.AddWithValue("@Product_Name", this.Product_Name);
            cmd.Parameters.AddWithValue("@Product_Price", this.Product_Price);
            cmd.Parameters.AddWithValue("@Product_Desc", this.Product_Desc);
            cmd.Parameters.AddWithValue("@Product_Image", this.Product_Image);
            cmd.Parameters.AddWithValue("@Stock_Level", this.Stock_Level);
            cmd.Parameters.AddWithValue("@Discount", this.Discount);

            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();

            return result;

        }//end Insert

        //public int ProductDelete(decimal ID)
        //{

        //}//end Delete

        //public int ProductUpdate(string pId, string pName, decimal pUnitPrice)
        //{

        //}//end Update
    }
}