namespace Super_Shop
{
    partial class Customer_Page
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnProductDetails = new System.Windows.Forms.Button();
            this.btnPurchaseDetails = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Controls.Add(this.btnMyInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnProductDetails);
            this.flowLayoutPanel1.Controls.Add(this.btnPurchaseDetails);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(189, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnMyInfo.ForeColor = System.Drawing.Color.Black;
            this.btnMyInfo.Location = new System.Drawing.Point(3, 3);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(181, 52);
            this.btnMyInfo.TabIndex = 1;
            this.btnMyInfo.Text = "My Info";
            this.btnMyInfo.UseVisualStyleBackColor = false;
            this.btnMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
            // 
            // btnProductDetails
            // 
            this.btnProductDetails.BackColor = System.Drawing.Color.Lavender;
            this.btnProductDetails.Location = new System.Drawing.Point(3, 61);
            this.btnProductDetails.Name = "btnProductDetails";
            this.btnProductDetails.Size = new System.Drawing.Size(181, 52);
            this.btnProductDetails.TabIndex = 1;
            this.btnProductDetails.Text = "Product Details";
            this.btnProductDetails.UseVisualStyleBackColor = false;
            this.btnProductDetails.Click += new System.EventHandler(this.btnProductDetails_Click);
            // 
            // btnPurchaseDetails
            // 
            this.btnPurchaseDetails.BackColor = System.Drawing.Color.Lavender;
            this.btnPurchaseDetails.Location = new System.Drawing.Point(3, 119);
            this.btnPurchaseDetails.Name = "btnPurchaseDetails";
            this.btnPurchaseDetails.Size = new System.Drawing.Size(181, 52);
            this.btnPurchaseDetails.TabIndex = 2;
            this.btnPurchaseDetails.Text = "Purchase Details";
            this.btnPurchaseDetails.UseVisualStyleBackColor = false;
            this.btnPurchaseDetails.Click += new System.EventHandler(this.btnPurchaseDetails_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Lavender;
            this.btnLogout.Location = new System.Drawing.Point(3, 177);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.White;
            this.panelCustomer.Controls.Add(this.label1);
            this.panelCustomer.Location = new System.Drawing.Point(195, 3);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(712, 485);
            this.panelCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Customer_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 488);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Customer_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Page_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnProductDetails;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPurchaseDetails;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label label1;
    }
}