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
    public partial class Mngr_Salesman_Info : Form
    {
        //int Sid;
        string Sname;
        int PhnNo;
        string Gender;
        string Email;
        string Address;
        int Salary;

        private SqlConnection sqlConnection;

        public Mngr_Salesman_Info()
        {
            InitializeComponent();
            string sql2 = @"select userid, username,name,gender,phonenumber,email,address,salary from Person where usertype=2";
            PopulateGridView(sql2);
        }

        private void btnAddSalesman_Click(object sender, EventArgs e)
        {
            this.sqlConnection = DataAccess.Sqlcon;
            try
            {
                int usertype = 2;
                
                Sname = txtSalesName.Text;
                Gender = cbGender.Text;
                PhnNo = Convert.ToInt32(txtPhnNo.Text);
                Email = txtEmail.Text;
                Address = txtAddress.Text;
                Salary = Convert.ToInt32(txtSalary.Text);

                string sql = @"Insert into Person values('" + txtSalesUName.Text + "', '" + txtPassword.Text + "' , '" + usertype + "', '" + Sname + "','" + Gender + "','" + PhnNo + "', '" + Email + "','" +Address + "','" + Salary + "')";
                DataAccess.ExecuteQuery(sql);
                MessageBox.Show("Salesman Inserted Successfully!!");

                //gridview 
                string sql2 = @"select userid, username,name,gender,phonenumber,email,address,salary from Person where usertype=2";
                PopulateGridView(sql2);

                //clearing
                Clear();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }




        }

        private void btnUpdateSalesmanInfo_Click(object sender, EventArgs e)
        {

            try
            {
                
                string sql = @"update Person
                                set username = '" + txtSalesUName.Text + @"',
                                name = '" + txtSalesName.Text + @"',
                                phonenumber = '" + txtPhnNo.Text + @"',
                                email = '" + txtEmail.Text + @"', address = '" + txtAddress.Text + @"',                                
                                salary = '" + txtSalary.Text + @"'
                                where userid = '" + txtSalesId.Text + "';";
                DataAccess.ExecuteQuery(sql);

                MessageBox.Show("Salesman Updated Successfully!!");
                //grid view
                string sql2 = @"select userid, username,name,gender,phonenumber,email,address,salary from Person where usertype=2";
                PopulateGridView(sql2);

                //clearing
                Clear();

            }
            catch (Exception exc)
            { MessageBox.Show(exc.Message); }
        }

        private void btnDeleteSalesman_Click(object sender, EventArgs e)
        {
            string sql = @"delete from Person where userid='" + txtSalesId.Text + "'";
            DataAccess.ExecuteQuery(sql);
            MessageBox.Show("Record Deleted!!");

            //grid view
            string sql2 = @"select * from Person where usertype=2";
            PopulateGridView(sql2);

            //clearing
            Clear();
        }
        private void PopulateGridView(string query)
        {
            this.dgvSI.DataSource = DataAccess.GetDataTable(query);

        }
        private void Clear()
        {
            txtSalesId.Clear();
            txtSalesName.Clear();
            txtSalesUName.Clear();
            txtPassword.Clear();
            txtPhnNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSalary.Clear();

            txtPassword.Enabled = true;
            cbGender.Enabled = true;

        }

        private void dgvSI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtPassword.Enabled = false;
                cbGender.Enabled = false;
                DataGridViewRow dataRow = dgvSI.CurrentRow;
                txtSalesId.Text = dataRow.Cells[0].Value.ToString();
                txtSalesName.Text = dataRow.Cells[1].Value.ToString();
                txtSalesUName.Text = dataRow.Cells[2].Value.ToString();
                //txtPassword.Text= dataRow.Cells[2].Value.ToString();
                cbGender.Text = dataRow.Cells[3].Value.ToString();
                txtPhnNo.Text = dataRow.Cells[4].Value.ToString();
                txtEmail.Text = dataRow.Cells[5].Value.ToString();
                txtAddress.Text = dataRow.Cells[6].Value.ToString();
                txtSalary.Text = dataRow.Cells[7].Value.ToString();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
