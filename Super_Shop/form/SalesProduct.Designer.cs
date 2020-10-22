namespace Super_Shop.form
{
    partial class SalesProduct
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTakeOrder = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAddProduct = new System.Windows.Forms.DataGridView();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabTakeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTakeOrder);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTakeOrder
            // 
            this.tabTakeOrder.BackColor = System.Drawing.Color.GhostWhite;
            this.tabTakeOrder.Controls.Add(this.label9);
            this.tabTakeOrder.Controls.Add(this.label8);
            this.tabTakeOrder.Controls.Add(this.btnDelete);
            this.tabTakeOrder.Controls.Add(this.btnUpdate);
            this.tabTakeOrder.Controls.Add(this.btnDone);
            this.tabTakeOrder.Controls.Add(this.label7);
            this.tabTakeOrder.Controls.Add(this.txtTotalPrice);
            this.tabTakeOrder.Controls.Add(this.btnProductAdd);
            this.tabTakeOrder.Controls.Add(this.label5);
            this.tabTakeOrder.Controls.Add(this.txtPrice);
            this.tabTakeOrder.Controls.Add(this.txtQuantity);
            this.tabTakeOrder.Controls.Add(this.label4);
            this.tabTakeOrder.Controls.Add(this.dgvAddProduct);
            this.tabTakeOrder.Controls.Add(this.txtProduct);
            this.tabTakeOrder.Controls.Add(this.txtCustomerid);
            this.tabTakeOrder.Controls.Add(this.txtSalesId);
            this.tabTakeOrder.Controls.Add(this.label3);
            this.tabTakeOrder.Controls.Add(this.label2);
            this.tabTakeOrder.Controls.Add(this.label1);
            this.tabTakeOrder.Location = new System.Drawing.Point(4, 22);
            this.tabTakeOrder.Name = "tabTakeOrder";
            this.tabTakeOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabTakeOrder.Size = new System.Drawing.Size(652, 394);
            this.tabTakeOrder.TabIndex = 0;
            this.tabTakeOrder.Text = "Take Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 88;
            this.label9.Text = "TK.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 87;
            this.label8.Text = "TK.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(530, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(442, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(541, 362);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 17;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(87, 136);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(102, 20);
            this.txtTotalPrice.TabIndex = 15;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(361, 192);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(204, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 20);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrice_MouseClick);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(87, 89);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(65, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // dgvAddProduct
            // 
            this.dgvAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProduct.Location = new System.Drawing.Point(6, 221);
            this.dgvAddProduct.Name = "dgvAddProduct";
            this.dgvAddProduct.Size = new System.Drawing.Size(610, 135);
            this.dgvAddProduct.TabIndex = 6;
            this.dgvAddProduct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAddProduct_MouseDoubleClick);
            // 
            // txtProduct
            // 
            this.txtProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProduct.Location = new System.Drawing.Point(87, 44);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(165, 20);
            this.txtProduct.TabIndex = 5;
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Location = new System.Drawing.Point(463, 136);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(142, 20);
            this.txtCustomerid.TabIndex = 4;
            // 
            // txtSalesId
            // 
            this.txtSalesId.Enabled = false;
            this.txtSalesId.Location = new System.Drawing.Point(463, 92);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(142, 20);
            this.txtSalesId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvProductList);
            this.tabPage2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Product List:";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(6, 66);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(640, 308);
            this.dgvProductList.TabIndex = 1;
            // 
            // SalesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 426);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesProduct";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.SalesProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTakeOrder.ResumeLayout(false);
            this.tabTakeOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTakeOrder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAddProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}