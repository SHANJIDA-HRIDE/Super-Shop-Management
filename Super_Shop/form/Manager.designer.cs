namespace Super_Shop
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManagerInfo = new System.Windows.Forms.Button();
            this.btnTransactionDetails = new System.Windows.Forms.Button();
            this.btnViewSalesmanInfo = new System.Windows.Forms.Button();
            this.btnViewCustomerInfo = new System.Windows.Forms.Button();
            this.btnProductDetails = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelManager = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnManagerInfo);
            this.panel1.Controls.Add(this.btnTransactionDetails);
            this.panel1.Controls.Add(this.btnViewSalesmanInfo);
            this.panel1.Controls.Add(this.btnViewCustomerInfo);
            this.panel1.Controls.Add(this.btnProductDetails);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 485);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(20, 440);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 33);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManagerInfo
            // 
            this.btnManagerInfo.Location = new System.Drawing.Point(20, 399);
            this.btnManagerInfo.Name = "btnManagerInfo";
            this.btnManagerInfo.Size = new System.Drawing.Size(108, 35);
            this.btnManagerInfo.TabIndex = 5;
            this.btnManagerInfo.Text = "My Info";
            this.btnManagerInfo.UseVisualStyleBackColor = true;
            this.btnManagerInfo.Click += new System.EventHandler(this.btnManagerInfo_Click);
            // 
            // btnTransactionDetails
            // 
            this.btnTransactionDetails.BackColor = System.Drawing.Color.Lavender;
            this.btnTransactionDetails.Location = new System.Drawing.Point(20, 199);
            this.btnTransactionDetails.Name = "btnTransactionDetails";
            this.btnTransactionDetails.Size = new System.Drawing.Size(108, 38);
            this.btnTransactionDetails.TabIndex = 4;
            this.btnTransactionDetails.Text = "Transaction Details";
            this.btnTransactionDetails.UseVisualStyleBackColor = false;
            this.btnTransactionDetails.Click += new System.EventHandler(this.btnTransactionDetails_Click);
            // 
            // btnViewSalesmanInfo
            // 
            this.btnViewSalesmanInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnViewSalesmanInfo.Location = new System.Drawing.Point(20, 145);
            this.btnViewSalesmanInfo.Name = "btnViewSalesmanInfo";
            this.btnViewSalesmanInfo.Size = new System.Drawing.Size(108, 38);
            this.btnViewSalesmanInfo.TabIndex = 3;
            this.btnViewSalesmanInfo.Text = "View Salesman Info";
            this.btnViewSalesmanInfo.UseVisualStyleBackColor = false;
            this.btnViewSalesmanInfo.Click += new System.EventHandler(this.btnViewSalesmanInfo_Click);
            // 
            // btnViewCustomerInfo
            // 
            this.btnViewCustomerInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnViewCustomerInfo.Location = new System.Drawing.Point(20, 82);
            this.btnViewCustomerInfo.Name = "btnViewCustomerInfo";
            this.btnViewCustomerInfo.Size = new System.Drawing.Size(108, 36);
            this.btnViewCustomerInfo.TabIndex = 1;
            this.btnViewCustomerInfo.Text = "View Customer Info";
            this.btnViewCustomerInfo.UseVisualStyleBackColor = false;
            this.btnViewCustomerInfo.Click += new System.EventHandler(this.btnViewCustomerInfo_Click);
            // 
            // btnProductDetails
            // 
            this.btnProductDetails.BackColor = System.Drawing.Color.Lavender;
            this.btnProductDetails.Location = new System.Drawing.Point(20, 24);
            this.btnProductDetails.Name = "btnProductDetails";
            this.btnProductDetails.Size = new System.Drawing.Size(108, 42);
            this.btnProductDetails.TabIndex = 0;
            this.btnProductDetails.Text = "Product Details";
            this.btnProductDetails.UseVisualStyleBackColor = false;
            this.btnProductDetails.Click += new System.EventHandler(this.btnProductDetails_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelManager
            // 
            this.panelManager.Controls.Add(this.label1);
            this.panelManager.Location = new System.Drawing.Point(151, 1);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(723, 485);
            this.panelManager.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 488);
            this.Controls.Add(this.panelManager);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panelManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManagerInfo;
        private System.Windows.Forms.Button btnTransactionDetails;
        private System.Windows.Forms.Button btnViewSalesmanInfo;
        private System.Windows.Forms.Button btnViewCustomerInfo;
        private System.Windows.Forms.Button btnProductDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.Label label1;
    }
}