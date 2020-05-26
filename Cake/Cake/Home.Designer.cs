namespace Cake
{
    partial class Home
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
            this.ChefBTN = new System.Windows.Forms.Button();
            this.OrderBTN = new System.Windows.Forms.Button();
            this.DeliveryBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfileBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChefBTN
            // 
            this.ChefBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ChefBTN.Enabled = false;
            this.ChefBTN.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChefBTN.Location = new System.Drawing.Point(96, 71);
            this.ChefBTN.Name = "ChefBTN";
            this.ChefBTN.Size = new System.Drawing.Size(493, 210);
            this.ChefBTN.TabIndex = 0;
            this.ChefBTN.Text = "Chef";
            this.ChefBTN.UseVisualStyleBackColor = false;
            this.ChefBTN.Click += new System.EventHandler(this.ChefBTN_Click);
            // 
            // OrderBTN
            // 
            this.OrderBTN.BackColor = System.Drawing.Color.Crimson;
            this.OrderBTN.Enabled = false;
            this.OrderBTN.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBTN.Location = new System.Drawing.Point(96, 305);
            this.OrderBTN.Name = "OrderBTN";
            this.OrderBTN.Size = new System.Drawing.Size(235, 210);
            this.OrderBTN.TabIndex = 2;
            this.OrderBTN.Text = "Order";
            this.OrderBTN.UseVisualStyleBackColor = false;
            this.OrderBTN.Click += new System.EventHandler(this.OrderBTN_Click);
            // 
            // DeliveryBTN
            // 
            this.DeliveryBTN.BackColor = System.Drawing.Color.Tomato;
            this.DeliveryBTN.Enabled = false;
            this.DeliveryBTN.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryBTN.Location = new System.Drawing.Point(354, 305);
            this.DeliveryBTN.Name = "DeliveryBTN";
            this.DeliveryBTN.Size = new System.Drawing.Size(235, 210);
            this.DeliveryBTN.TabIndex = 3;
            this.DeliveryBTN.Text = "Delivery";
            this.DeliveryBTN.UseVisualStyleBackColor = false;
            this.DeliveryBTN.Click += new System.EventHandler(this.DeliveryBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // ProfileBTN
            // 
            this.ProfileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileBTN.Location = new System.Drawing.Point(514, 22);
            this.ProfileBTN.Name = "ProfileBTN";
            this.ProfileBTN.Size = new System.Drawing.Size(75, 34);
            this.ProfileBTN.TabIndex = 7;
            this.ProfileBTN.Text = "Profile";
            this.ProfileBTN.UseVisualStyleBackColor = true;
            this.ProfileBTN.Click += new System.EventHandler(this.ProfileBTN_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 592);
            this.Controls.Add(this.ProfileBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliveryBTN);
            this.Controls.Add(this.OrderBTN);
            this.Controls.Add(this.ChefBTN);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChefBTN;
        private System.Windows.Forms.Button OrderBTN;
        private System.Windows.Forms.Button DeliveryBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProfileBTN;
    }
}

