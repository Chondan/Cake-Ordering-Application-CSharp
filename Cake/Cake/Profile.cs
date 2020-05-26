using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cake
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        int press = 0;

        void enableTB(Boolean x)
        {
            FirstNameTB.Enabled = x;
            LastNameTB.Enabled = x;
            AddressTB.Enabled = x;
            //UsernameTB.Enabled = x;
            PassWordTB.Enabled = x;
            TelTB.Enabled = x;

        }
        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (press == 0)
            {
                EditBTN.BackColor = Color.LightGreen;
                EditBTN.Text = "Update";
                press = 1;
                enableTB(true);
                FirstNameTB.Focus();

            }
            else
            {
                EditBTN.BackColor = Color.LightBlue;
                EditBTN.Text = "Edit";
                press = 0;
                enableTB(false);
                DB.UpdateUserInfo(LogIn.uname, FirstNameTB.Text, LastNameTB.Text, AddressTB.Text, TelTB.Text, PassWordTB.Text);
                MessageBox.Show("Updated");
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            EditBTN.BackColor = Color.LightBlue;

            DB.LoadUserInfo(LogIn.uname);
            FirstNameTB.Text = DB.fname;
            LastNameTB.Text = DB.lname;
            AddressTB.Text = DB.address;
            UsernameTB.Text = DB.uname;
            PassWordTB.Text = DB.pass;
            TelTB.Text = DB.tel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
