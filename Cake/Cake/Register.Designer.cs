namespace Cake
{
    partial class Register
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
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PassWordTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastNameTB
            // 
            this.LastNameTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LastNameTB.Location = new System.Drawing.Point(257, 56);
            this.LastNameTB.Multiline = true;
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(187, 26);
            this.LastNameTB.TabIndex = 6;
            this.LastNameTB.Text = "Last Name";
            this.LastNameTB.Enter += new System.EventHandler(this.LastNameTB_Enter);
            this.LastNameTB.Leave += new System.EventHandler(this.LastNameTB_Leave);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FirstNameTB.Location = new System.Drawing.Point(47, 56);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(187, 26);
            this.FirstNameTB.TabIndex = 4;
            this.FirstNameTB.Text = "First Name";
            this.FirstNameTB.Enter += new System.EventHandler(this.FirstNameTB_Enter);
            this.FirstNameTB.Leave += new System.EventHandler(this.FirstNameTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // UsernameTB
            // 
            this.UsernameTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTB.Location = new System.Drawing.Point(47, 314);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(187, 26);
            this.UsernameTB.TabIndex = 9;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // PassWordTB
            // 
            this.PassWordTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PassWordTB.Location = new System.Drawing.Point(257, 314);
            this.PassWordTB.Name = "PassWordTB";
            this.PassWordTB.PasswordChar = '*';
            this.PassWordTB.Size = new System.Drawing.Size(187, 26);
            this.PassWordTB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address";
            // 
            // AddressTB
            // 
            this.AddressTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddressTB.Location = new System.Drawing.Point(47, 111);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(397, 125);
            this.AddressTB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tel.";
            // 
            // TelTB
            // 
            this.TelTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TelTB.Location = new System.Drawing.Point(47, 262);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(187, 26);
            this.TelTB.TabIndex = 15;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Location = new System.Drawing.Point(47, 361);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(325, 70);
            this.RegisterBTN.TabIndex = 17;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(261, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 70);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassWordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassWordTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}