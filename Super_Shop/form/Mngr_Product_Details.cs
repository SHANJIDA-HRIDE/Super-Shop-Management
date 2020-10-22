using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_Shop.models;
using System.Data.SqlClient;
using Super_Shop.form;

namespace Super_Shop
{

    public partial class Mngr_Product_Details : Form

    {
       
       // int Productid;
        string Productname;
        int Totalquantity;
        int Soldquantity;
        int Availablequantity;
        int Priceps;
        int Pricecom;

        private SqlConnection sqlConnection;


        public Mngr_Product_Details()
        {
            InitializeComponent();
            string sql2 = @"select * from Product";
            PopulateGridView(sql2);
        }
       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sqlConnection = DataAccess.Sqlcon;

                Productname = txtProName.Text;
                Totalquantity = Convert.ToInt32(txtQuantity.Text);
                Soldquantity = 0;
                Availablequantity = Convert.ToInt32(txtQuantity.Text);
                Priceps = Convert.ToInt32(txtAPrice.Text);
                Pricecom = Convert.ToInt32(txtSPrice.Text);

                string sql = @"Insert into Product values('" + Productname + "', '" + Totalquantity + "','" + Soldquantity + "', '" + Availablequantity + "','" + Priceps + "','" + Pricecom + "')";
                DataAccess.ExecuteQuery(sql);
                MessageBox.Show("Product Inserted Successfully!!");

                //gridview 
                string sql2 = @"select * from Product";
                PopulateGridView(sql2);

                //clearing
                Clear();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnUpdatePro_Click_1(object sender, EventArgs e)
        {
            try
            {
                //  Console.WriteLine(Product.Availablequantity);
                int available = Convert.ToInt32(txtQuantity.Text) - Product.Soldquantity;
                Totalquantity = Convert.ToInt32(txtQuantity.Text);
                //Soldquantity = 0;
                //Availablequantity = Convert.ToInt32(txtQuantity.Text);
                Priceps = Convert.ToInt32(txtAPrice.Text);
                Pricecom = Convert.ToInt32(txtSPrice.Text);

                string sql = @"update Product set productname='" + txtProName.Text + "',totalquantity='" + Totalquantity + "',availablequantity='" + available + "',priceps='" + Priceps + "',pricecom='" + Pricecom + "' where productid ='" + txtProId.Text + "'";
                DataAccess.ExecuteQuery(sql);

                MessageBox.Show("Product Updated Successfully!!");
                //grid view
                string sql2 = @"select * from Product";
                PopulateGridView(sql2);

                //clearing
                Clear();
            }
            catch(Exception exc)
            { MessageBox.Show(exc.Message); }
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            string sql = @"delete from Product where productid='" + txtProId.Text + "'";
            DataAccess.ExecuteQuery(sql);
            MessageBox.Show("Record Deleted!!");

            //grid view
            string sql2 = @"select * from Product";
            PopulateGridView(sql2);

            //clearing
            Clear();
        }

       

        private void PopulateGridView(string query)
        {
            this.dgvMngrPro.DataSource = DataAccess.GetDataTable(query);

        }
        private void Clear()
        {
            txtProId.Clear();
            txtProName.Clear();
            txtQuantity.Clear();
            txtAPrice.Clear();
            txtSPrice.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from Product where productname like '" + txtSearch.Text + "%'";
            this.dgvMngrPro.DataSource = DataAccess.GetDataTable(sql);

        }

        private void dgvMngrPro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dataRow = dgvMngrPro.CurrentRow;
                txtProId.Text = dataRow.Cells[0].Value.ToString();
                txtProName.Text = dataRow.Cells[1].Value.ToString();
                txtQuantity.Text = dataRow.Cells[2].Value.ToString();
                Product.Totalquantity= Convert.ToInt32(dataRow.Cells[2].Value.ToString());
                Product.Soldquantity= Convert.ToInt32(dataRow.Cells[3].Value.ToString());
                Product.Availablequantity= Convert.ToInt32(dataRow.Cells[4].Value.ToString());
                txtAPrice.Text = dataRow.Cells[5].Value.ToString();
                txtSPrice.Text = dataRow.Cells[6].Value.ToString();
               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

      
    }
}
