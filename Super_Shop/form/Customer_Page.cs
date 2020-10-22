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
using Super_Shop.form;


namespace Super_Shop
{
    public partial class Customer_Page : Form
    {
         My_Info info = new My_Info();
        Product_Details ProDel = new Product_Details();
        Purchase_Details PurDel = new Purchase_Details();
        public Customer_Page()
        {
            InitializeComponent();
            label1.Text = "Welcome  " + UserLogin.Name;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            PurDel.Hide();
            ProDel.Hide();
            label1.Hide();
            
            info.Refresh();
            info.Dock = DockStyle.Fill;
            info.TopLevel = false;
            panelCustomer.Controls.Add(info);
            info.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new login().Visible = true;
            DataAccess.CloseConnection();
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            PurDel.Hide();
            info.Hide();
            label1.Hide();

            ProDel.Refresh();
            ProDel.Dock = DockStyle.Fill;
            ProDel.TopLevel = false;
            panelCustomer.Controls.Add(ProDel);
            ProDel.Show();
        }

        private void btnPurchaseDetails_Click(object sender, EventArgs e)
        {
            ProDel.Hide();
            info.Hide();
            label1.Hide();

            PurDel.Refresh();
            PurDel.Dock = DockStyle.Fill;
            PurDel.TopLevel = false;
            panelCustomer.Controls.Add(PurDel);
            PurDel.Show();
        }

        private void Customer_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            new login().Visible = true;
            DataAccess.CloseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
