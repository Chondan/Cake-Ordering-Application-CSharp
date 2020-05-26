using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.IO;


namespace Cake
{

    public class cake
    {
        public string cakeid;
        public string cakeaddress;
        public double cakeprice;
        public Byte[] cakeimg;
        public string tel;
        public string cakeusername;
       

     
        
    }
    
    class DB
    {


        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Cake.accdb");
        public static OleDbCommand cmd = new OleDbCommand();

        public static OleDbCommand cmdd = new OleDbCommand();

        public static string fname;
        public static string lname;
        public static string uname;
        public static string address;
        public static string tel;
        public static string pass;
        public static double price = 0;
        public static double p1; public static double p2; public static double p3; public static double p4;
        public static DataTable dtuser = new DataTable();
        public static List<cake> cake = new List<cake>();
        public static DataTable dtdelivery = new DataTable();
        public static DataTable dtdeliverybag = new DataTable();
        public static List<cake> bag = new List<cake>();
        public static string cakesize;
        public static string cakebase;
        public static string cakefrosting;
        public static string cakedecoration;
        static void opendb()
        {
            cmd.Connection = conn;
            cmdd.Connection = conn;
            conn.Open();
        }
        static void closedb()
        {
            conn.Close();
        }
        public static void LoadUserInfo(string username)
        {
            opendb();
            cmd.CommandText = "SELECT * FROM[User] WHERE(((User.UserName) = '" + username + "'))";
            OleDbDataReader dr = cmd.ExecuteReader();
            dtuser = new DataTable();
            dtuser.Load(dr);

            fname = dtuser.Rows[0][1].ToString();
            lname = dtuser.Rows[0][2].ToString();
            uname = dtuser.Rows[0][0].ToString();
            address = dtuser.Rows[0][3].ToString();
            tel = dtuser.Rows[0][4].ToString();
            pass = dtuser.Rows[0][5].ToString();

            closedb();
            


        }

        public static void UpdateUserInfo(string username,string name,string surname,string Address,string telephone,string password)
        {
            opendb();
            cmd.CommandText = "UPDATE [User] SET User.Name = '"+ name + "',User.Surname = '" + surname +"'," +
                "User.Address = '" + Address + "',User.Telephone = '" + telephone+ "',User.Password = '" + password + "' WHERE(((User.UserName) = '" + username +"'))";
            cmd.ExecuteNonQuery();

            closedb();


        }
        
        public static void CakePrice(string cakeProperty,int x)
        {
            
            opendb();
            if(cakeProperty != "")
            {
                if (x == 1)
                {
                    cmd.CommandText = "SELECT * FROM[QuerySize] WHERE(((QuerySize.CakeSize) = '" + cakeProperty + "'))";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    p1 = Convert.ToDouble(dt.Rows[0][2]);
                }
                else if (x == 2)
                {
                    cmd.CommandText = "SELECT * FROM[QueryBase] WHERE(((QueryBase.CakeBase) = '" + cakeProperty + "'))";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    p2 = Convert.ToDouble(dt.Rows[0][2]);
                }
                else if (x == 3)
                {
                    cmd.CommandText = "SELECT * FROM[QueryFrosting] WHERE(((QueryFrosting.CakeFrosting) = '" + cakeProperty + "'))";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    p3 = Convert.ToDouble(dt.Rows[0][2]);
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM[QueryDecoration] WHERE(((QueryDecoration.CakeDecoration) = '" + cakeProperty + "'))";
                    OleDbDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    p4 = Convert.ToDouble(dt.Rows[0][2]);
                }
                price = p1 + p2 + p3 + p4;
            }
            else
            {
                p1 = 0; p2 = 0; p3 = 0; p4 = 0;
                price = p1 + p2 + p3 + p4;
            }
         

            
            
            closedb();
        }
        
        public static void DeliveryInfo()
        {
            opendb();
            cmd.CommandText = "SELECT * FROM[CopyDeliveryQuery]";
            OleDbDataReader dr = cmd.ExecuteReader();

            dtdelivery.Rows.Clear();
            cake.Clear();
            
            dtdelivery.Load(dr);
            

            foreach (DataRow row in dtdelivery.Rows)
            {
                cake tmp = new cake();

                tmp.cakeid = row["CakeID"].ToString();
                tmp.cakeusername = row["UserName"].ToString();
                tmp.cakeaddress = row["Address"].ToString();
                tmp.tel = row["Telephone"].ToString();
                tmp.cakeprice = (double)row["Price"];
                tmp.cakeimg = (Byte[])row["CakeFace"];
                cake.Add(tmp);
            }
               

           
            closedb();
        }

        public static void Delivered(string cakeeee,string deliver)
        {
            opendb();
            cmd.CommandText = "UPDATE OrderDetail SET OrderDetail.DeliverBy = '"+ deliver + "' WHERE(((OrderDetail.CakeID) = '" + cakeeee + "'))";
            cmd.ExecuteNonQuery();
            closedb();       
        }

        public static void DeliveryBag(string username)
        {
            opendb();
            cmd.CommandText = "SELECT OrderDetail.CakeID, OrderDetail.Finish, OrderDetail.UserName, User.Address, User.Telephone, OrderDetail.Price, OrderDetail.Payment, OrderDetail.CakeFace, OrderDetail.DeliverBy " +
                "FROM[User] INNER JOIN OrderDetail ON User.UserName = OrderDetail.UserName " +
                "WHERE(((OrderDetail.Finish) = 'Y') AND((OrderDetail.Payment) = 'N') AND((OrderDetail.DeliverBy) = '"+username+"'))";
            OleDbDataReader dr = cmd.ExecuteReader();
            dtdeliverybag.Rows.Clear();
            bag.Clear();
            dtdeliverybag.Load(dr);

            foreach (DataRow row in dtdeliverybag.Rows)
            {
                cake tmp = new cake();

                tmp.cakeid = row["CakeID"].ToString();
                tmp.cakeusername = row["UserName"].ToString();
                tmp.cakeaddress = row["Address"].ToString();
                tmp.tel = row["Telephone"].ToString();
                tmp.cakeprice = (double)row["Price"];
                tmp.cakeimg = (Byte[])row["CakeFace"];
                bag.Add(tmp);
            }



            closedb();
        }

        public static void payment(string cakeeee)
        {
            opendb();
            cmdd.CommandText = "UPDATE OrderDetail SET OrderDetail.Payment = 'Y' WHERE(((OrderDetail.CakeID) = '" + cakeeee + "'))";
            cmdd.ExecuteNonQuery();
            closedb();
        }

        public static void cakeinfo(string cakeeee)
        {
            opendb();
            cmd.CommandText = "SELECT QueryOrderDetail.CakeID, QueryOrderDetail.CakeSize, QueryOrderDetail.CakeBase, QueryOrderDetail.CakeFrosting, QueryOrderDetail.CakeDecoration " +
                "FROM QueryOrderDetail WHERE(((QueryOrderDetail.CakeID) = '" + cakeeee +"'))";

            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cakesize = (string)dt.Rows[0][1];
            cakebase = (string)dt.Rows[0][2];
            cakefrosting = (string)dt.Rows[0][3];
            cakedecoration = (string)dt.Rows[0][4];
            closedb();

        }

        public static void createTransaction(string x, string cakeeee,double receive,double change)
        {
            opendb();
            cmd.CommandText = "INSERT INTO [Transaction] ( TransactionID, CakeID, Receive, Change ) " +
                "SELECT '"+x+"' AS Expr1, '"+cakeeee+"' AS Expr2, "+receive+" AS Expr3, "+change+" AS Expr4";

            cmd.ExecuteNonQuery();
            closedb();
        }
    }

  

}
