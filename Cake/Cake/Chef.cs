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
using System.IO;

namespace Cake
{
    public partial class Chef : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Cake.accdb");
        OleDbCommand cmd = new OleDbCommand();

        public Chef()
        {
            InitializeComponent();
        }

        private void Chef_Load(object sender, EventArgs e)
        {
            label6.Text = LogIn.uname;
            cmd.Connection = conn;
            FinishBTN.BackColor = default(Color);
            FinishBTN.Enabled = false;
            x = "SELECT * FROM QueryOrderDetail WHERE Finish='N'";
            update_grid(x);
        }
        string x;
        private void LoadBTN_Click(object sender, EventArgs e)
        {
            press = 2;
            FinishedBTN.BackColor = Color.LightSalmon;
            OrderBTN.BackColor = default(Color);
            MakingBTN.BackColor = default(Color);
            ReceiveOrderBTN.Enabled = false;
            FinishBTN.Enabled = false;
            ReceiveOrderBTN.BackColor = default(Color);
            FinishBTN.BackColor = default(Color);
            refreshDT();
            updateDT();




        }
        int press;
        void refreshDT()
        {
            if (press ==1)
            {
                x = "SELECT * FROM QueryOrderDetail WHERE Finish='N'";
            }
            else if(press == 2)
            {
                x = "SELECT * FROM QueryOrderDetail WHERE Finish='Y'";

            }
            else if (press == 3)
            {
                x = "SELECT * FROM QueryOrderDetail WHERE Finish='Making'";

            }
            update_grid(x);
        }

        private void update_grid(string x)
        {
    

            conn.Open();
            cmd.CommandText = x;
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        void updateDT()
        {
            try
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[0];
                //populate the textbox from specific value of the coordinates of column and row.
                byte[] bytes = (byte[])dataGridView1.Rows[0].Cells[7].Value;
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox7.Image = Image.FromStream(ms);
                SizeTB.Text = row.Cells[2].Value.ToString();
                BaseTB.Text = row.Cells[3].Value.ToString();
                FrostingTB.Text = row.Cells[4].Value.ToString();
                DecorationTB.Text = row.Cells[5].Value.ToString();
                label5.Text = row.Cells[0].Value.ToString();
                label7.Text = row.Cells[10].Value.ToString();
            }
            catch
            {
                pictureBox7.Image = null;
                label5.Text = "";
                SizeTB.Text = "";
                BaseTB.Text = "";
                FrostingTB.Text = "";
                DecorationTB.Text = "";
            }

            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                byte[] bytes = (byte[])dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox7.Image = Image.FromStream(ms);
                SizeTB.Text = row.Cells[2].Value.ToString();
                BaseTB.Text = row.Cells[3].Value.ToString();
                FrostingTB.Text = row.Cells[4].Value.ToString();
                DecorationTB.Text = row.Cells[5].Value.ToString();
                label5.Text = row.Cells[0].Value.ToString();
                label7.Text = row.Cells[10].Value.ToString();

            }
        }

        private void FinishBTN_Click(object sender, EventArgs e)
        {
            if (SizeTB.Text != "")
            {
                if (label6.Text == label7.Text)
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE OrderDetail SET OrderDetail.Finish = 'Y',OrderDetail.FinishedDateByChef = '"+ DateTime.Now +"' WHERE(((OrderDetail.CakeID) = '" + label5.Text + "'))";
                    cmd.ExecuteNonQuery();


                    conn.Close();
                    MessageBox.Show(label5.Text + " is finished");

                    pictureBox7.Image = null;
                    SizeTB.Text = "";
                    BaseTB.Text = "";
                    FrostingTB.Text = "";
                    DecorationTB.Text = "";
                    label5.Text = "";
                    refreshDT();
                    updateDT();
                   
                }
                else
                {
                    MessageBox.Show("You can't finish this cake");
                }
            }
            else
            {
                MessageBox.Show("Please select a cake");
            }
         


        }

        private void OrderBTN_Click(object sender, EventArgs e)
        {
            press = 1;
            ReceiveOrderBTN.Enabled = true;
            FinishBTN.Enabled = false;

            OrderBTN.BackColor = Color.LightSalmon;
            ReceiveOrderBTN.BackColor = Color.DodgerBlue;

            FinishedBTN.BackColor = default(Color);
            MakingBTN.BackColor = default(Color);


            FinishBTN.BackColor = default(Color);
            refreshDT();
            updateDT();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SizeTB.Text != "")
            {


                conn.Open();
                cmd.CommandText = "UPDATE OrderDetail SET OrderDetail.Finish = 'Making',OrderDetail.Chef = '" + LogIn.uname + "' WHERE(((OrderDetail.CakeID) = '" + label5.Text + "'))";
                cmd.ExecuteNonQuery();


                conn.Close();
                MessageBox.Show("Order received");
                refreshDT();
                updateDT();
            }
            else
            {
                MessageBox.Show("Please select a cake");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            press = 3;
            ReceiveOrderBTN.Enabled = false;
            FinishBTN.Enabled = true;
            
            OrderBTN.BackColor = default(Color);
            FinishedBTN.BackColor = default(Color);
            ReceiveOrderBTN.BackColor = default(Color);

            MakingBTN.BackColor = Color.LightSalmon;
            FinishBTN.BackColor = Color.SpringGreen;
            refreshDT();
            updateDT();
        }
    }
}
