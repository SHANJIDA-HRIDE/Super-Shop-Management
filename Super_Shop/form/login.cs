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
    public partial class login : Form
    {
        private static login Login = null;
        private SqlConnection sqlConnection;

        /// <summary>
        /// Used to create only one instance of this class
        /// Singleton Pattern
        /// </summary>
        /// <returns></returns>
        public static login GetLoginForm()
        {
            if (Login == null)
            {
                Login = new login();
            }
            return Login;
        }

        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.sqlConnection = DataAccess.Sqlcon;
            bool credentialsMatched =loginVerify(this.txtUsername.Text, this.txtPassword.Text);
            if (credentialsMatched)
            {
                switch (UserLogin.UserType)
                {
                    case 1:
                        {
                            this.txtUsername.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.Visible = false;
                            new Manager().Visible = true;
                            break;
                        }

                    case 2:
                        {
                            this.txtUsername.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.Visible = false;
                            new Salesmanhome().Visible = true;
                            break;
                        }

                    case 3:
                        {
                            this.txtUsername.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.Visible = false;
                            new Customer_Page().Visible = true;
                            break;
                        }
                    default:
                        break;
                }

            }
        }

        public static bool loginVerify(string username, string password)
        {
            try
            {
                string sql = @"select * from Person where username = '" + username + "' and password = '" + password + "'";
                DataSet ds = DataAccess.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Verification Successful");
                    UserLogin.UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["userid"].ToString());
                    UserLogin.Username = ds.Tables[0].Rows[0]["username"].ToString();
                    UserLogin.Password = ds.Tables[0].Rows[0]["password"].ToString();
                    UserLogin.UserType =Convert.ToInt32( ds.Tables[0].Rows[0]["usertype"].ToString());
                    UserLogin.Name = ds.Tables[0].Rows[0]["name"].ToString();
                    UserLogin.Gender = ds.Tables[0].Rows[0]["gender"].ToString();
                    UserLogin.PhoneNumber = Convert.ToInt32(ds.Tables[0].Rows[0]["phonenumber"].ToString());
                    UserLogin.Email = ds.Tables[0].Rows[0]["email"].ToString();
                    UserLogin.Address = ds.Tables[0].Rows[0]["address"].ToString();
                   // UserLogin.Salary = Convert.ToInt32(ds.Tables[0].Rows[0]["salary"].ToString());
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Register().Visible = true;
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
