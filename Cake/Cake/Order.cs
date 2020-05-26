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
  
    public partial class Order : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Cake.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr = null;

        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;


        public Order()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 3);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //bitmap = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
            panel1.BackgroundImage = bmp;
            panel1.BackgroundImageLayout = ImageLayout.None;
        }
        //Bitmap bitmap;
        private void Order_Load(object sender, EventArgs e)
        {
            DB.p1 = 0; DB.p2 = 0; DB.p3 = 0; DB.p4 = 0;
            label6.Text = LogIn.fname + " " + LogIn.lname + " " + DateTime.Now;
            textBox1.BackColor = Color.Black;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "SELECT * FROM [Size]";
   
            
            dr = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            dt1.Load(dr);
            foreach(DataRow row in dt1.Rows)
            {
                comboBoxSize.Items.Add(row[1]);
            }

            cmd.CommandText = "SELECT * FROM [Base]";
            dr = cmd.ExecuteReader();
            
            dt2.Load(dr);
            foreach (DataRow row in dt2.Rows)
            {
                comboBoxBase.Items.Add(row[1]);
            }

            cmd.CommandText = "SELECT * FROM [Frosting]";
            dr = cmd.ExecuteReader();

            dt3.Load(dr);
            foreach (DataRow row in dt3.Rows)
            {
                comboBoxFrosting.Items.Add(row[1]);
            }


            cmd.CommandText = "SELECT * FROM [Decoration]";
            dr = cmd.ExecuteReader();

            dt4.Load(dr);
            foreach (DataRow row in dt4.Rows)
            {
                comboBoxDecoration.Items.Add(row[1]);
            }



            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x!=-1 && y!=-1)
            {

                g.DrawLine(pen, new Point(x, y), e.Location);
                
                x = e.X;
                y = e.Y;
                panel1.Invalidate();
            }
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
            textBox1.BackColor = p.BackColor;
        }
        Bitmap bmp;
        private void SubmitBTN_Click(object sender, EventArgs e)
        {

            if (comboBoxSize.Text != "" && comboBoxBase.Text != "" && comboBoxFrosting.Text != "" && comboBoxDecoration.Text != "")
            {



                int sizeid;
                int baseid;
                int frostingid;
                int decorationid;

                //Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);

                panel1.DrawToBitmap(bmp, rect);
                //bitmap.Save( "Test" + ".jpg", ImageFormat.Jpeg);


                bmp.Save("Test" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                conn.Open();
                cmd.CommandText = "SELECT * FROM OrderDetail WHERE (UserName='" + LogIn.uname + "')";
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                int od = dt.Rows.Count;
                //string cakeid = LogIn.uname + "Cake" + od.ToString();
                string cakeid = LogIn.uname + "Cake_" + DateTime.Now;


                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();



                cmd.CommandText = "SELECT * FROM[QuerySize] WHERE(((QuerySize.CakeSize) = '" + comboBoxSize.Text + "'))";          
                OleDbDataReader dbReader = cmd.ExecuteReader();
                dt2.Load(dbReader);
                sizeid = Convert.ToInt32(dt2.Rows[0][0]);


                cmd.CommandText = "SELECT * FROM[QueryBase] WHERE(((QueryBase.CakeBase) = '" + comboBoxBase.Text + "'))";
                dbReader = cmd.ExecuteReader();
                dt3.Load(dbReader);
                baseid = Convert.ToInt32(dt3.Rows[0][0]);


                cmd.CommandText = "SELECT * FROM[QueryFrosting] WHERE(((QueryFrosting.CakeFrosting) = '" + comboBoxFrosting.Text + "'))";
                dbReader = cmd.ExecuteReader();
                dt4.Load(dbReader);
                frostingid = Convert.ToInt32(dt4.Rows[0][0]);


                cmd.CommandText = "SELECT * FROM[QueryDecoration] WHERE(((QueryDecoration.CakeDecoration) = '" + comboBoxDecoration.Text + "'))";
                dbReader = cmd.ExecuteReader();
                dt5.Load(dbReader);
                decorationid = Convert.ToInt32(dt5.Rows[0][0]);


                conn.Close();
                string sql;


                sql = "Insert into OrderDetail (CakeID, UserName, CakeSize, CakeBase, CakeFrosting, CakeDecoration, Finish, CakeFace, [DueDate], [OrderDate], Price, Payment) " +
                    "Values ('" + cakeid + "','" + LogIn.uname + "'," + sizeid + "," + baseid + "," + frostingid + "," + decorationid + ",'N',@IM,'" + dateTimePicker1.Value.Date + "', '" + DateTime.Now + "', "+ Convert.ToDouble(PriceTB.Text) +", 'N')";
                saveImage(sql);
                MessageBox.Show("You have orderd your cake, price : "+DB.price.ToString());
                DB.p1 = 0; DB.p2 = 0; DB.p3 = 0; DB.p4 = 0;
                //PriceTB.Text = "";


                g = Graphics.FromImage(bmp);
                g.Clear(Color.White);
                panel1.Invalidate();
                comboBoxSize.SelectedIndex = -1;
                comboBoxBase.SelectedIndex = -1;
                comboBoxFrosting.SelectedIndex = -1;
                comboBoxDecoration.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please fill information");
                if(comboBoxSize.Text == "")
                {
                    comboBoxSize.Focus();
                }
                else if(comboBoxBase.Text == "")
                {
                    comboBoxBase.Focus();

                }
                else if(comboBoxDecoration.Text =="")
                {
                    comboBoxDecoration.Focus();
                }
                else
                {
                    comboBoxFrosting.Focus();
                }
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

     
        }

        private void saveImage(string sql)
        {
            try
            {
                conn.Open();
                string path = "Test.jpg";
                byte[] imageData;

                cmd = new OleDbCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                imageData = System.IO.File.ReadAllBytes(@path);
                cmd.Parameters.AddWithValue("@IM", imageData);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void update_grid()
        {
            //conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=testdb.accdb");

            conn.Open();

            cmd.CommandText = "SELECT * FROM QueryOrderDetail WHERE UserName='"+ LogIn.uname +"'";
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;

  


            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_grid();
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
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[7].Value.GetType().ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            panel1.Invalidate();

            
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Heyy");
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB.CakePrice(comboBoxSize.Text,1);
            PriceTB.Text = DB.price.ToString(); ;
        }

        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB.CakePrice(comboBoxBase.Text, 2);
            PriceTB.Text = DB.price.ToString(); ;
        }

        private void comboBoxFrosting_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB.CakePrice(comboBoxFrosting.Text, 3);
            PriceTB.Text = DB.price.ToString(); ;
        }

        private void comboBoxDecoration_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB.CakePrice(comboBoxDecoration.Text, 4);
            PriceTB.Text = DB.price.ToString(); ;
        }
    }
    public class TPanel : Panel
    {
        public TPanel()
        {

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
