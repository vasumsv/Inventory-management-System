namespace Inventory_managemenet_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HOMEcustomer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.seller = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.HOMEcustomer);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 95);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HOMEcustomer
            // 
            this.HOMEcustomer.AutoSize = true;
            this.HOMEcustomer.Font = new System.Drawing.Font("Times New Roman", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEcustomer.ForeColor = System.Drawing.Color.Black;
            this.HOMEcustomer.Location = new System.Drawing.Point(354, 19);
            this.HOMEcustomer.Name = "HOMEcustomer";
            this.HOMEcustomer.Size = new System.Drawing.Size(188, 61);
            this.HOMEcustomer.TabIndex = 1;
            this.HOMEcustomer.Text = "HOME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.seller);
            this.panel2.Controls.Add(this.customer);
            this.panel2.Location = new System.Drawing.Point(4, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 557);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.PaleGreen;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.Location = new System.Drawing.Point(664, 462);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(211, 58);
            this.exit.TabIndex = 2;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // seller
            // 
            this.seller.BackColor = System.Drawing.Color.PaleGreen;
            this.seller.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller.ForeColor = System.Drawing.Color.Maroon;
            this.seller.Location = new System.Drawing.Point(340, 462);
            this.seller.Name = "seller";
            this.seller.Size = new System.Drawing.Size(263, 58);
            this.seller.TabIndex = 1;
            this.seller.Text = "SELLER";
            this.seller.UseVisualStyleBackColor = false;
            this.seller.Click += new System.EventHandler(this.seller_Click);
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.PaleGreen;
            this.customer.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Maroon;
            this.customer.Location = new System.Drawing.Point(11, 462);
            this.customer.Margin = new System.Windows.Forms.Padding(0);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(284, 58);
            this.customer.TabIndex = 0;
            this.customer.Text = "CUSTOMER";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1014, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button seller;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Label HOMEcustomer;
    }
}

