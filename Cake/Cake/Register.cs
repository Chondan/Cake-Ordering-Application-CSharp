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
    public partial class Register : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Cake.accdb");
        OleDbCommand cmd = new OleDbCommand();
      

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
        }

        private void LastNameTB_Enter(object sender, EventArgs e)
        {
            if (LastNameTB.Text == "Last Name")
            {
                //LastNameTB.ForeColor = Color.Silver;
                LastNameTB.Text = "";
            }
        }

        private void LastNameTB_Leave(object sender, EventArgs e)
        {
            if (LastNameTB.Text == "")
            {
                //LastNameTB.ForeColor = Color.Silver;
                LastNameTB.Text = "Last Name";
            }
        }

        private void FirstNameTB_Enter(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "First Name")
            {
                //LastNameTB.ForeColor = Color.Silver;
                FirstNameTB.Text = "";
            }
        }

        private void FirstNameTB_Leave(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "")
            {
                //LastNameTB.ForeColor = Color.Silver;
                FirstNameTB.Text = "First Name";
            }
        }

        string fname;
        string lname;
        string address;
        string tel;
        string username;
        string password;
        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            fname = FirstNameTB.Text;
            lname = LastNameTB.Text;
            address = AddressTB.Text;
            tel = TelTB.Text;
            username = UsernameTB.Text;
            password = PassWordTB.Text;


            conn.Open();
            if (fname != "" && lname != "" && address != "" && tel != "" && username != "" && password != "")
            {


                if (check == 1)
                {
                    //cmd.CommandText = "INSERT INTO User (UserName,Name,Surname,Address,Telephone,Password,UserTypeID) VALUES ('"+ username +"','"+
                    //fname +"','"+ lname +"','"+address +"','"+ tel +"','" + password + "'," + 1 + ")";

                    cmd.CommandText = "INSERT INTO [User] ( UserName, Name, Surname, Address, Telephone, [Password], UserTypeID ) " +
                        "SELECT '" + username + "' AS Expr1, '" + fname + "' AS Expr2, '" + lname + "' AS Expr3, '" + address + "' AS Expr4, '" + tel + "' AS Expr5, '" + password + "' AS Expr6, " + 1 + " AS Expr7";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    this.Close();
                    LogIn login = new LogIn();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("This username is already used");
                    UsernameTB.Focus();

                }
            }
            else
            {
                MessageBox.Show("Please fill an empty textbox");
                
            }
            //cmd.ExecuteNonQuery();
            conn.Close();
            
           
        }
        int check = 0;
        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {

            int count;
            conn.Open();
            cmd.CommandText = "SELECT User.UserName FROM[User] WHERE(((User.UserName) = '"+ UsernameTB.Text + "'))";
            
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            count = dt.Rows.Count;
            if (UsernameTB.Text != "")
            {


                if (count == 0)
                {
                    label7.Text = "You can use this UserName";
                    label7.ForeColor = Color.DarkGreen;
                    check = 1;
                }
                else
                {
                    label7.Text = "This UserName is already used";
                    label7.ForeColor = Color.DarkRed;
                    check = 0;
                }
            }
            else
            {
                label7.Text = "";
            }
            //cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }
    }
}
