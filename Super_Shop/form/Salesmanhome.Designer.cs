namespace Super_Shop.form
{
    partial class Salesmanhome
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnCusInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelButton.Controls.Add(this.btnMyInfo);
            this.panelButton.Controls.Add(this.btnCusInfo);
            this.panelButton.Controls.Add(this.btnLogout);
            this.panelButton.Controls.Add(this.btnPurchase);
            this.panelButton.Controls.Add(this.btnProduct);
            this.panelButton.Location = new System.Drawing.Point(1, 12);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(171, 479);
            this.panelButton.TabIndex = 0;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnMyInfo.Location = new System.Drawing.Point(11, 150);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(144, 38);
            this.btnMyInfo.TabIndex = 4;
            this.btnMyInfo.Text = "My Information";
            this.btnMyInfo.UseVisualStyleBackColor = false;
            this.btnMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
            // 
            // btnCusInfo
            // 
            this.btnCusInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnCusInfo.Location = new System.Drawing.Point(11, 106);
            this.btnCusInfo.Name = "btnCusInfo";
            this.btnCusInfo.Size = new System.Drawing.Size(144, 38);
            this.btnCusInfo.TabIndex = 3;
            this.btnCusInfo.Text = "Customer Information";
            this.btnCusInfo.UseVisualStyleBackColor = false;
            this.btnCusInfo.Click += new System.EventHandler(this.btnCusInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(24, 430);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 36);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Lavender;
            this.btnPurchase.Location = new System.Drawing.Point(11, 53);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(144, 38);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "Purchase ";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Lavender;
            this.btnProduct.Location = new System.Drawing.Point(11, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(144, 35);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(178, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(692, 488);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Salesmanhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 503);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButton);
            this.Name = "Salesmanhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesmanhome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Salesmanhome_FormClosed);
            this.panelButton.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnCusInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
    }
}