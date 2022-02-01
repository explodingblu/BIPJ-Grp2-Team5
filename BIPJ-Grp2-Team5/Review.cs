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
    public class Review
    {
        //Private string _connStr = Properties.Settings.Default.DBConnStr;

        //System.Configuration.ConnectionStringSettings _connStr;
        string _connStr = ConfigurationManager.ConnectionStrings["MainDBContext"].ConnectionString;
        private string _reviewID = null;
        private int _rating = 0;
        private string _comment = string.Empty;
        private string _prodID = "";
        private string _custID = "";

        // Default constructor
        public Review()
        {
        }

        // Constructor that take in all data required to build a Product object
        public Review(string reviewID, int rating, string comment, string prodID, string custID)
        {
            _reviewID = reviewID;
            _rating = rating;
            _comment = comment;
            _prodID = prodID;
            _custID = custID;
        }

        // Constructor that take in all except product ID
        public Review(int prodrating, string prodcomment, string productID, string prodcustID)
            : this(null, prodrating, prodcomment, productID, prodcustID)
        {
        }

        // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
        public Review(string reviewID)
            : this(reviewID, 0, "", "", "")
        {
        }

        // Get/Set the attributes of the Product object.
        // Note the attribute name (e.g. Product_ID) is same as the actual database field name.
        // This is for ease of referencing.
        public string Review_ID
        {
            get { return _reviewID; }
            set { _reviewID = value; }
        }
        
        public int Product_Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Product_Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public string Product_ID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }
        public string Customer_ID
        {
            get { return _custID; }
            set { _custID = value; }
        }


        //Below as the Class methods for some DB operations. 
        public Review getReview(string reviewID)
        {

            Review reviewDetail = null;

            string rev_Com, rev_prodID, rev_custID;
            int rev_rating;

            string queryStr = "SELECT * FROM Reviews WHERE Review_ID = @RevID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@RevID", reviewID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                rev_rating = int.Parse(dr["Product_Rating"].ToString());
                rev_Com = dr["Product_Comment"].ToString();
                rev_prodID = dr["Product_ID"].ToString();
                rev_custID = dr["Customer_ID"].ToString();

                reviewDetail = new Review(reviewID, rev_rating, rev_Com, rev_prodID, rev_custID);
            }
            else
            {
                reviewDetail = null;
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return reviewDetail;
        }

        public List<Review> getReviewAll()
        {
            List<Review> reviewList = new List<Review>();

            string rev_ID, rev_Com, rev_prodID, rev_custID;
            int rev_rating;

            string queryStr = "SELECT * FROM Reviews Order By Review_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rev_ID = dr["Review_ID"].ToString();
                rev_rating = int.Parse(dr["Product_Rating"].ToString());
                rev_Com = dr["Product_Comment"].ToString();
                rev_prodID = dr["Product_ID"].ToString();
                rev_custID = dr["Customer_ID"].ToString();
                Review a = new Review(rev_ID, rev_rating, rev_Com, rev_prodID, rev_custID);
                reviewList.Add(a);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return reviewList;
        }

        public int ReviewInsert()
        {
            // string msg = null;
            int result = 0;

            string queryStr = "INSERT INTO Reviews(Review_ID, Product_Rating, Product_Comment, Product_ID, Customer_ID)"
                + " values (@Review_ID,@Product_Rating, @Product_Comment, @Product_ID, @Customer_ID)";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@Review_ID", this.Review_ID);
            cmd.Parameters.AddWithValue("@Product_Rating", this.Product_Rating);
            cmd.Parameters.AddWithValue("@Product_Comment", this.Product_Comment);
            cmd.Parameters.AddWithValue("@Product_ID", this.Product_ID);
            cmd.Parameters.AddWithValue("@Customer_ID", "");

            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();

            return result;

        }//end Insert

        public int ProductDelete(string ID)
        {
            string queryStr = "DELETE FROM Reviews WHERE Review_ID=@ID";
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


        public int ProductUpdate(string rId, int rRate, string rCom, string rProdID, string rCustID)
        {
            string queryStr = "UPDATE Reviews SET" + " Product_Rating = @productRating, " + " Product_Comment = @productComment, " + " Product_ID = @productID, " + " Customer_ID = @customerID" + " WHERE Review_ID = @reviewID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@reviewID", rId);
            cmd.Parameters.AddWithValue("@productRating", rRate);
            cmd.Parameters.AddWithValue("@productComment", rCom);
            cmd.Parameters.AddWithValue("@productID", rProdID);
            cmd.Parameters.AddWithValue("@customerID", rCustID);

            conn.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();

            conn.Close();

            return nofRow;
        }//end Update

    }
}