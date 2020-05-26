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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }
        void setPicturebox()
        {

            if (DB.cake.Count % 5 != 0)
            {
                pictureBox1.Height = ((DB.cake.Count / 5) + 1) * 100;


            }
            else
            {
                pictureBox1.Height = ((DB.cake.Count / 5) + 0) * 100;
            }

        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            label1.Text = LogIn.uname;           
            DB.DeliveryInfo();
            DB.DeliveryBag(LogIn.uname);
            setPicturebox();
            flowLayoutPanel1.Controls.Add(pictureBox1);
            label7.Text = "Capacity = " + DB.bag.Count().ToString();
            pictureBox2.Height = 100;
            pictureBox2.Width = 100 * DB.bag.Count; ;
            flowLayoutPanel2.Controls.Add(pictureBox2);
            Refresh();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int pos_x;
            int pos_y;

            pos_x = e.X;
            pos_y = e.Y;

            int indexx;
            indexx = (((pos_x / 100) + 1) + ((pos_y / 100)) * 5) - 1;
            if (MessageBox.Show("Are you sure to print the invoice?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (indexx < DB.cake.Count())
                {
                    printDocument1.Print();
                    DB.Delivered(DB.cake[indexx].cakeid, LogIn.uname);
                    DB.DeliveryInfo();
                    DB.DeliveryBag(LogIn.uname);
                    Refresh();
                    label7.Text = "Capacity = " + DB.bag.Count().ToString();

                    pictureBox2.Height = 100;
                    pictureBox2.Width = 100 * DB.bag.Count; ;
                    flowLayoutPanel2.Controls.Add(pictureBox2);
                    setPicturebox();
                }
            }
            
        }
            public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        Image convertToimg(byte[] x)
        {
            byte[] bytes = x;
            MemoryStream ms = new MemoryStream(bytes);
            Image xx = Image.FromStream(ms);
            xx = resizeImage(xx, new Size(100, 100));
            return (Image)xx;
        }
        
       
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < DB.cake.Count; i++)
            {
                int col = i % 5;
                int row = i / 5;


                Font f = new Font("Microsoft Sans Serif", 8.5f);
                e.Graphics.DrawImage(convertToimg(DB.cake[i].cakeimg), col * 100, row * 100);
                if ((row + col) % 2 == 0)
                {
                    e.Graphics.FillRectangle(Brushes.LightPink, col * 100, (row) * 100 + 80, 100, 20);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.LightBlue, col * 100, (row) * 100 + 80, 100, 20);
                }
                
                e.Graphics.DrawString(DB.cake[i].cakeaddress, f, Brushes.Black, col * 100, (row) * 100 + 83);
              
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            int pos_x;
            int pos_y;

            pos_x = e.X;
            pos_y = e.Y;

            int indexx;
            indexx = (((pos_x / 100) + 1) + ((pos_y / 100)) * 1) - 1;
            if (indexx < DB.bag.Count)
            {
                //pictureBox3.Image = convertToimg(DB.bag[indexx].cakeimg);
                try
                {
                    button1.BackgroundImage = convertToimg(DB.bag[indexx].cakeimg);
                }
                catch
                {

                }
                AddressTB.Text = DB.bag[indexx].cakeaddress;
                TelTB.Text = DB.bag[indexx].tel;
                PriceTB.Text = DB.bag[indexx].cakeprice.ToString();
                label8.Text = "CakeID: " + DB.bag[indexx].cakeid;
                label9.Text = DB.bag[indexx].cakeid;

            }
        }
      
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int x = 0; int y = 0;

            foreach (var xx in DB.bag)
            {
                e.Graphics.DrawImage(convertToimg(xx.cakeimg), y * 100, x * 100);
                if ((y%2) == 0)
                {
                    e.Graphics.FillRectangle(Brushes.LightPink, y * 100, (x) * 100 + 80, 100, 20);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.LightBlue, y * 100, (x) * 100 + 80, 100, 20);
                }
                
                e.Graphics.DrawString(xx.cakeid, Font, Brushes.Black, y * 100, (x) * 100 + 83);
                y = y + 1;
                

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int pos_x;
            int pos_y;

            pos_x = e.X;
            pos_y = e.Y;

            int indexx;
            indexx = (((pos_x / 100) + 1) + ((pos_y / 100)) * 5) - 1;
            if (indexx < DB.cake.Count)
            {
                //pictureBox3.Image = convertToimg(DB.cake[indexx].cakeimg);
                try
                {
                    button1.BackgroundImage = convertToimg(DB.cake[indexx].cakeimg);
                }
                catch
                {

                }
                

                AddressTB.Text = DB.cake[indexx].cakeaddress;
                TelTB.Text = DB.cake[indexx].tel;
                PriceTB.Text = DB.cake[indexx].cakeprice.ToString();
                label8.Text = "CakeID: "+DB.cake[indexx].cakeid;
                label9.Text = DB.cake[indexx].cakeid;

                Refresh();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 0;
           
            foreach(var x in DB.bag)
            {
                if(x.cakeid == label9.Text)
                {
                    check = 1;
                    if (MessageBox.Show("Comfirm to payment?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            
                            if (Convert.ToDouble(ReceiveTB.Text) >= Convert.ToDouble(PriceTB.Text))
                            {


                                DB.payment(label9.Text);
                                DB.createTransaction(DateTime.Now.ToString() +"_"+LogIn.uname ,label9.Text, Convert.ToDouble(ReceiveTB.Text), Convert.ToDouble(ChangeTB.Text));


                                MessageBox.Show("Success");
                                DB.DeliveryInfo();
                                DB.DeliveryBag(LogIn.uname);

                                Refresh();

                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Not enough money");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("wrong iput");
                        }
                        
                            
                        

                    }
                    break;
                }
                
            }
            if (check == 0)
            {
                MessageBox.Show("You have to print an Invoice");
            }


        }

        void clear()
        {
            button1.BackgroundImage = null;
            label8.Text = "";
            AddressTB.Text = "";
            TelTB.Text = "";
            PriceTB.Text = "";
            label7.Text = "Capacity = " + DB.bag.Count().ToString();
            ReceiveTB.Text = "";
            ChangeTB.Text = "";

        }
        public int xx = 300;
        public int yy = 600;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new
            System.Drawing.Printing.PaperSize("custom", xx, yy);


            Font f = new Font("Courier New", 8, FontStyle.Italic);
            Font fnt = new Font("Courier New", 8, FontStyle.Bold);
            Graphics g = e.Graphics;
            g.DrawString("Receipt", fnt, Brushes.Black, (xx - "Invoice".Length * 8) / 2, 10);

            g.DrawString(DateTime.Now.ToString(), fnt, Brushes.Black, ((xx - DateTime.Now.ToString().Length * 8) / 2) + 10, 30);
            g.DrawString(label9.Text, fnt, Brushes.Black, (xx - (label9.Text).Length * 8) / 2, 50);

            DB.cakeinfo(label9.Text);



            int i = 0;
            g.DrawString("CakeSize", f, Brushes.Black, xx / 8, 70 + (20 * i));
            g.DrawString(DB.cakesize, f, Brushes.Black, (3 * xx / 4) - (PriceTB.Text.Length - 1) * 8, 70 + (20 * i));
            i += 1;
            g.DrawString("CakeBase", f, Brushes.Black, xx / 8, 70 + (20 * i));
            g.DrawString(DB.cakebase, f, Brushes.Black, (3 * xx / 4) - (PriceTB.Text.Length - 1) * 8, 70 + (20 * i));
            i += 1;
            g.DrawString("CakeFrosting", f, Brushes.Black, xx / 8, 70 + (20 * i));
            g.DrawString(DB.cakefrosting, f, Brushes.Black, (3 * xx / 4) - (PriceTB.Text.Length - 1) * 8, 70 + (20 * i));
            i += 1;
            g.DrawString("CakeDecoration", f, Brushes.Black, xx / 8, 70 + (20 * i));
            g.DrawString(DB.cakedecoration, f, Brushes.Black, (3 * xx / 4) - (PriceTB.Text.Length - 1) * 8, 70 + (20 * i));
            i += 1;


            g.DrawString("Total", fnt, Brushes.Black, xx / 8, 70 + (20 * i));
            g.DrawString(PriceTB.Text, fnt, Brushes.Black, (3 * xx / 4) - (PriceTB.Text.Length - 1) * 8, 70 + (20 * i));
         
        
        }

        private void ReceiveTB_TextChanged(object sender, EventArgs e)
        {
            
            if(ReceiveTB.Text != "")
            {
                try
                {
                    ChangeTB.Text = (-Convert.ToDouble(PriceTB.Text) + Convert.ToDouble(ReceiveTB.Text)).ToString();
                }
                catch
                {

                }
            }
            
            
        }
    }
}
