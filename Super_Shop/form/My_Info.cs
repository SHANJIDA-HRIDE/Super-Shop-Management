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
using Super_Shop.form;

namespace Super_Shop
{
    public partial class My_Info : Form
    {
        public My_Info()
        {
            InitializeComponent();
        }

        private void My_Info_Load(object sender, EventArgs e)
        {


            txtId.Text=Convert.ToString(UserLogin.UserId);
            txtName.Text = UserLogin.Name;
            //txtPassword.Text = UserLogin.Password;
            txtUserName.Text = UserLogin.Username;
            txtPhnNo.Text = Convert.ToString(UserLogin.PhoneNumber);
            txtEmail.Text = UserLogin.Email;
            txtAddress.Text = UserLogin.Address;
            cbGender.Text = UserLogin.Gender;
            string[] Gender = new string[6];
            Gender[0] = "Male";
            Gender[1] = "Female";
            cbGender.DataSource = Gender;

            if (UserLogin.UserType == 2)
            {
                btnDeleteManger.Enabled = false;
            }
            else
                btnDeleteManger.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            int phn = Convert.ToInt32(txtPhnNo.Text);
            string sql1 = @"update Person
                                set username = '" + txtUserName.Text + @"',
                                name = '" + txtName.Text + @"',
                                gender = '" + cbGender.Text + @"', phonenumber = '" + phn + @"',
                                email = '" + txtEmail.Text + @"', address = '" + txtAddress.Text + @"'
                                where userid = '" + txtId.Text + "';";
            DataAccess.ExecuteQuery(sql1);
            MessageBox.Show("Successful");
        }

        private void btnDeleteManger_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM Person WHERE userid = '" + txtId.Text + "'; ";
            DataAccess.ExecuteQuery(sql);
            this.Visible = false;
            new login().Visible = true;
            DataAccess.CloseConnection();
        }

        private void btnPassUpdate_Click(object sender, EventArgs e)
        {
            //if(txtPassword.Text == UserLogin.Password)
            //{
            //    if (txtNewPass.Text == txtConfirmPass.Text)
            //    {
            //        string sql1 = @"update Person
            //                    set  password = '" + txtConfirmPass.Text + @"'
            //                    where userid = '" + txtId.Text + "';";
            //        DataAccess.ExecuteQuery(sql1);
            //        MessageBox.Show("Successful");
            //    }
            //    else
            //    { MessageBox.Show("New Password and Confirm Password does not match"); }
            //}
            //else { MessageBox.Show("Can not update Password"); }

            //txtConfirmPass.Clear();
            //txtNewPass.Clear();
            //txtPassword.Clear();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ChangePass().Visible = true;
        }
    }
}
