using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Super_Shop.models;

namespace Super_Shop.form
{
    public partial class Register : Form
    {
        private SqlConnection sqlConnection;

        public Register()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.sqlConnection = DataAccess.Sqlcon;
            try
            {
                int usertype = 3;
                int phn = Convert.ToInt32(txtPhnNo.Text);
                string gender;

                if (rbMale.Checked)
                {
                    gender = rbMale.Text;
                }
                else
                {
                    gender = rbFemale.Text;
                }

                string sql = @"insert into Person values('" + txtUserName.Text + "', '" + txtPassword.Text + "', '"+usertype+"' , '" + txtName.Text + "', '" + gender + "', '" + phn + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', ' ')";
                DataAccess.ExecuteQuery(sql);
              
                this.Visible = false;
                new login().Visible = true;
                DataAccess.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new login().Visible = true;

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  this.Close();
            new login().Visible = true;
            DataAccess.CloseConnection();
        }
    }
}
