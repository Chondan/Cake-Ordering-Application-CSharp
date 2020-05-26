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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + LogIn.fname + " " + LogIn.lname;
            label3.Text = LogIn.type.ToString(); 
            if(label3.Text == "1")
            {
                OrderBTN.Enabled = true;
                ChefBTN.Enabled = false;
                DeliveryBTN.Enabled = false;
                DeliveryBTN.BackColor = default(Color);
                ChefBTN.BackColor = default(Color);

            }
            else if(label3.Text == "2")
            {
                OrderBTN.Enabled = false;
                ChefBTN.Enabled = true;
                DeliveryBTN.Enabled = false;
                OrderBTN.BackColor = default(Color);
                DeliveryBTN.BackColor = default(Color);
            }
            else if (label3.Text == "3")
            {
                OrderBTN.Enabled = false;
                ChefBTN.Enabled = false;
                DeliveryBTN.Enabled = false;
                DeliveryBTN.BackColor = default(Color);
                ChefBTN.BackColor = default(Color);
                OrderBTN.BackColor = default(Color);
            }
            else if (label3.Text == "4")
            {
                OrderBTN.Enabled = false;
                ChefBTN.Enabled = false;
                DeliveryBTN.Enabled = true;
                ChefBTN.BackColor = default(Color);
                OrderBTN.BackColor = default(Color);
            }
        

        }

        private void OrderBTN_Click(object sender, EventArgs e)
        {
            Order odr = new Order();
            odr.Show();
        }

        private void ChefBTN_Click(object sender, EventArgs e)
        {
            Chef chf = new Chef();
            chf.Show();
        }

        private void InventoryBTN_Click(object sender, EventArgs e)
        {
       
        }

        private void DeliveryBTN_Click(object sender, EventArgs e)
        {
            Delivery dv = new Delivery();
            dv.Show();
        }

        private void ProfileBTN_Click(object sender, EventArgs e)
        {
            Profile prf = new Profile();
            prf.Show();
        }
    }
}
