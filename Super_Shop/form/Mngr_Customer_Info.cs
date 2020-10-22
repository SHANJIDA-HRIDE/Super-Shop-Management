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
    public partial class Mngr_Customer_Info : Form
    { 

        

        public Mngr_Customer_Info()
        {
            InitializeComponent();
            string sql2 = @"select userid,username,gender,phonenumber,email,address from Person where usertype=3 "; 
            PopulateGridView(sql2); 
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string sql = @"delete from Person where userid='" + txtCusId.Text + "'";
            DataAccess.ExecuteQuery(sql);
            MessageBox.Show("Record Deleted!!");

            //grid view
            string sql2 = @"select userid,username,gender,phonenumber,email,address  from Person  where usertype=3";
            PopulateGridView(sql2);

            //clearing
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select userid,username,gender,phonenumber,email,address  from Person where usertype=3 and username like '" + txtSearch.Text + "%'";
            this.dgvMCI.DataSource = DataAccess.GetDataTable(sql);
            
        }


        private void PopulateGridView(string query)
        {
            this.dgvMCI.DataSource = DataAccess.GetDataTable(query);

        }
        private void Clear()
        {
            txtCusId.Clear();
            txtCusName.Clear();
            txtCusGender.Clear();
            txtCusPhnNo.Clear();
            txtCusEmail.Clear();
            txtCusAddress.Clear();
        }

        private void dgvMCI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dataRow = dgvMCI.CurrentRow;
                txtCusId.Text = dataRow.Cells[0].Value.ToString();
                txtCusName.Text = dataRow.Cells[1].Value.ToString();
                txtCusGender.Text = dataRow.Cells[2].Value.ToString();
                txtCusPhnNo.Text= dataRow.Cells[3].Value.ToString();
                txtCusEmail.Text = dataRow.Cells[4].Value.ToString();
                txtCusAddress.Text = dataRow.Cells[5].Value.ToString();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        
    }
}
