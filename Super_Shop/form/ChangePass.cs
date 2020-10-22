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

namespace Super_Shop.form
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
          
        }

        private void btnPassUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtPassword.Text == UserLogin.Password && txtPassword.Text != null)
                {
               
                        if (string.IsNullOrEmpty(txtNewPass.Text) && string.IsNullOrEmpty(txtConfirmPass.Text))
                        {
                            MessageBox.Show("Please give new password");
                        }
                        else
                        { 
                            if (txtNewPass.Text == txtConfirmPass.Text)
                            {
                                string sql1 = @"update Person
                                set  password = '" + txtConfirmPass.Text + @"'
                                where userid = '" + UserLogin.UserId + "';";
                                DataAccess.ExecuteQuery(sql1);
                                MessageBox.Show("Successful");
                            }
                            else
                            { MessageBox.Show("New Password and Confirm Password does not match"); }
                        }
                    
                }
                else { MessageBox.Show("Current Password is wrong"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            this.Visible = false;

            
           

        }

        private void ChangePass_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Visible = false;
        }
    }
}
