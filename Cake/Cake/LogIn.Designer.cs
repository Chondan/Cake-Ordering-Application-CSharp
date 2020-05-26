namespace Cake
{
    partial class LogIn
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
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWordTB = new System.Windows.Forms.TextBox();
            this.LogInBTN = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(171, 58);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(187, 26);
            this.UserNameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // PassWordTB
            // 
            this.PassWordTB.Location = new System.Drawing.Point(171, 109);
            this.PassWordTB.Name = "PassWordTB";
            this.PassWordTB.PasswordChar = '*';
            this.PassWordTB.Size = new System.Drawing.Size(187, 26);
            this.PassWordTB.TabIndex = 2;
            // 
            // LogInBTN
            // 
            this.LogInBTN.Location = new System.Drawing.Point(86, 161);
            this.LogInBTN.Name = "LogInBTN";
            this.LogInBTN.Size = new System.Drawing.Size(272, 31);
            this.LogInBTN.TabIndex = 4;
            this.LogInBTN.Text = "LogIn";
            this.LogInBTN.UseVisualStyleBackColor = true;
            this.LogInBTN.Click += new System.EventHandler(this.LogInBTN_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Location = new System.Drawing.Point(86, 198);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(272, 31);
            this.RegisterBTN.TabIndex = 5;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.LogInBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassWordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameTB);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWordTB;
        private System.Windows.Forms.Button LogInBTN;
        private System.Windows.Forms.Button RegisterBTN;
    }
}