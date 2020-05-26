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

namespace Cake
{
    public partial class LogIn : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Cake.accdb");
        OleDbCommand cmd = new OleDbCommand();
   
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            UserNameTB.Focus();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            Register rgst = new Register();
            
            rgst.Show();
            this.Hide();
        }
        public static string fname;
        public static string lname;
        public static string uname;
        public static string address;
        public static string tel;
        public static string pass;
        public static int type;
        private void LogInBTN_Click(object sender, EventArgs e)
        {
            string username = UserNameTB.Text;
            string password = PassWordTB.Text;


            conn.Open();
            cmd.CommandText = "SELECT * FROM[User] WHERE(((User.UserName) = '"+ username +"'))";
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            int count = dt.Rows.Count;
            if(count == 0)
            {
                MessageBox.Show("You don't have an account");

            }
            else
            {
                if (password == dt.Rows[0][5].ToString())
                {
                    MessageBox.Show("Logged in");
                    fname = dt.Rows[0][1].ToString();
                    lname = dt.Rows[0][2].ToString();
                    uname = dt.Rows[0][0].ToString();
                    address = dt.Rows[0][3].ToString();
                    tel = dt.Rows[0][4].ToString();
                    pass = dt.Rows[0][5].ToString();

                    type = Convert.ToInt32(dt.Rows[0][6]);

                    Home hm = new Home();
                    
                    hm.Show();
                    //UserNameTB.Text = "";
                    //PassWordTB.Text = "";
                    //this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    PassWordTB.Focus();
                }

            }


            conn.Close();



        }
    }
}
