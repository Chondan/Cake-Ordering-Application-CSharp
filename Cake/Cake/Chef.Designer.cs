namespace Cake
{
    partial class Chef
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.FinishedBTN = new System.Windows.Forms.Button();
            this.FinishBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeTB = new System.Windows.Forms.TextBox();
            this.BaseTB = new System.Windows.Forms.TextBox();
            this.FrostingTB = new System.Windows.Forms.TextBox();
            this.DecorationTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderBTN = new System.Windows.Forms.Button();
            this.ReceiveOrderBTN = new System.Windows.Forms.Button();
            this.MakingBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(762, 595);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(782, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(506, 346);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // FinishedBTN
            // 
            this.FinishedBTN.BackColor = System.Drawing.SystemColors.Control;
            this.FinishedBTN.Location = new System.Drawing.Point(544, 613);
            this.FinishedBTN.Name = "FinishedBTN";
            this.FinishedBTN.Size = new System.Drawing.Size(229, 62);
            this.FinishedBTN.TabIndex = 17;
            this.FinishedBTN.Text = "FINISHED";
            this.FinishedBTN.UseVisualStyleBackColor = false;
            this.FinishedBTN.Click += new System.EventHandler(this.LoadBTN_Click);
            // 
            // FinishBTN
            // 
            this.FinishBTN.BackColor = System.Drawing.Color.SpringGreen;
            this.FinishBTN.Location = new System.Drawing.Point(1045, 516);
            this.FinishBTN.Name = "FinishBTN";
            this.FinishBTN.Size = new System.Drawing.Size(223, 152);
            this.FinishBTN.TabIndex = 18;
            this.FinishBTN.Text = "FINISH";
            this.FinishBTN.UseVisualStyleBackColor = false;
            this.FinishBTN.Click += new System.EventHandler(this.FinishBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1041, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Decoration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1041, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Frosting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Size";
            // 
            // SizeTB
            // 
            this.SizeTB.Enabled = false;
            this.SizeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SizeTB.Location = new System.Drawing.Point(793, 399);
            this.SizeTB.Name = "SizeTB";
            this.SizeTB.Size = new System.Drawing.Size(223, 26);
            this.SizeTB.TabIndex = 27;
            // 
            // BaseTB
            // 
            this.BaseTB.Enabled = false;
            this.BaseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BaseTB.Location = new System.Drawing.Point(793, 456);
            this.BaseTB.Name = "BaseTB";
            this.BaseTB.Size = new System.Drawing.Size(223, 26);
            this.BaseTB.TabIndex = 28;
            // 
            // FrostingTB
            // 
            this.FrostingTB.Enabled = false;
            this.FrostingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FrostingTB.Location = new System.Drawing.Point(1045, 401);
            this.FrostingTB.Name = "FrostingTB";
            this.FrostingTB.Size = new System.Drawing.Size(223, 26);
            this.FrostingTB.TabIndex = 29;
            // 
            // DecorationTB
            // 
            this.DecorationTB.Enabled = false;
            this.DecorationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DecorationTB.Location = new System.Drawing.Point(1045, 456);
            this.DecorationTB.Name = "DecorationTB";
            this.DecorationTB.Size = new System.Drawing.Size(223, 26);
            this.DecorationTB.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "CakeID";
            // 
            // OrderBTN
            // 
            this.OrderBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.OrderBTN.Location = new System.Drawing.Point(12, 613);
            this.OrderBTN.Name = "OrderBTN";
            this.OrderBTN.Size = new System.Drawing.Size(260, 62);
            this.OrderBTN.TabIndex = 32;
            this.OrderBTN.Text = "ORDER";
            this.OrderBTN.UseVisualStyleBackColor = false;
            this.OrderBTN.Click += new System.EventHandler(this.OrderBTN_Click);
            // 
            // ReceiveOrderBTN
            // 
            this.ReceiveOrderBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ReceiveOrderBTN.Location = new System.Drawing.Point(793, 516);
            this.ReceiveOrderBTN.Name = "ReceiveOrderBTN";
            this.ReceiveOrderBTN.Size = new System.Drawing.Size(223, 152);
            this.ReceiveOrderBTN.TabIndex = 33;
            this.ReceiveOrderBTN.Text = "RECEIVE ORDER";
            this.ReceiveOrderBTN.UseVisualStyleBackColor = false;
            this.ReceiveOrderBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakingBTN
            // 
            this.MakingBTN.BackColor = System.Drawing.SystemColors.Control;
            this.MakingBTN.Location = new System.Drawing.Point(278, 613);
            this.MakingBTN.Name = "MakingBTN";
            this.MakingBTN.Size = new System.Drawing.Size(260, 62);
            this.MakingBTN.TabIndex = 34;
            this.MakingBTN.Text = "MAKING";
            this.MakingBTN.UseVisualStyleBackColor = false;
            this.MakingBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 687);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "ChefUserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1188, 687);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "CakeChef";
            this.label7.Visible = false;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 716);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MakingBTN);
            this.Controls.Add(this.ReceiveOrderBTN);
            this.Controls.Add(this.OrderBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DecorationTB);
            this.Controls.Add(this.FrostingTB);
            this.Controls.Add(this.BaseTB);
            this.Controls.Add(this.SizeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishBTN);
            this.Controls.Add(this.FinishedBTN);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button FinishedBTN;
        private System.Windows.Forms.Button FinishBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SizeTB;
        private System.Windows.Forms.TextBox BaseTB;
        private System.Windows.Forms.TextBox FrostingTB;
        private System.Windows.Forms.TextBox DecorationTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OrderBTN;
        private System.Windows.Forms.Button ReceiveOrderBTN;
        private System.Windows.Forms.Button MakingBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}