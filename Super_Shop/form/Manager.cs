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

namespace Super_Shop
{
    public partial class Manager : Form
    {
        Mngr_Product_Details ProductDetails = new Mngr_Product_Details();
        My_Info info = new My_Info();
        Mngr_Customer_Info CusInfo = new Mngr_Customer_Info();
        Mngr_Salesman_Info SalesInfo = new Mngr_Salesman_Info();
        Mngr_Transaction transaction = new Mngr_Transaction();

        public Manager()
        {
            InitializeComponent();
            label1.Text = "Welcome  " + UserLogin.Name;
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
           
            info.Hide();
            CusInfo.Hide();
            SalesInfo.Hide();
            transaction.Hide();
            label1.Hide();

            ProductDetails.Refresh();
            ProductDetails.Dock = DockStyle.Fill;
            ProductDetails.TopLevel = false;
            panelManager.Controls.Add(ProductDetails);
            ProductDetails.Show();
        }

        private void btnManagerInfo_Click(object sender, EventArgs e)
        {
            ProductDetails.Hide();
            CusInfo.Hide();
            SalesInfo.Hide();
            transaction.Hide();
            label1.Hide();

            info.Refresh();
            info.Dock = DockStyle.Fill;
            info.TopLevel = false;
            panelManager.Controls.Add(info);
            info.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new login().Visible = true;
            DataAccess.CloseConnection();
        }

        private void btnViewCustomerInfo_Click(object sender, EventArgs e)
        {
            ProductDetails.Hide();
            info.Hide();
            SalesInfo.Hide();
            transaction.Hide();
            label1.Hide();

            CusInfo.Refresh();
            CusInfo.Dock = DockStyle.Fill;
            CusInfo.TopLevel = false;
            panelManager.Controls.Add(CusInfo);
            CusInfo.Show();
        }

        private void btnViewSalesmanInfo_Click(object sender, EventArgs e)
        {
            ProductDetails.Hide();
            info.Hide();
            CusInfo.Hide();
            transaction.Hide();
            label1.Hide();

            SalesInfo.Refresh();
            SalesInfo.Dock = DockStyle.Fill;
            SalesInfo.TopLevel = false;
            panelManager.Controls.Add(SalesInfo);
            SalesInfo.Show();
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Close();
            new login().Visible = true;
            DataAccess.CloseConnection();
        }

        private void btnTransactionDetails_Click(object sender, EventArgs e)
        {
            ProductDetails.Hide();
            info.Hide();
            CusInfo.Hide();
            SalesInfo.Hide();
            label1.Hide();

            transaction.Refresh();
            transaction.Dock = DockStyle.Fill;
            transaction.TopLevel = false;
            panelManager.Controls.Add(transaction);
            transaction.Show();

        }
    }
}
