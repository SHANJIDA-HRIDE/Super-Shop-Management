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

namespace Super_Shop.form
{
    public partial class Salesmanhome : Form
    {
        //  internal bool visible;
        SalesProduct salesPro = new SalesProduct();
        SalesPurchase salesPur = new SalesPurchase();
        SalesCustomer salesCus = new SalesCustomer();
        My_Info info = new My_Info();
        public Salesmanhome()
        {
            InitializeComponent();
            label1.Text = "Welcome  "+UserLogin.Name;
        }
        
        private void btnProduct_Click(object sender, EventArgs e)
        {
            salesPur.Hide();
            salesCus.Hide();
            info.Hide();
            label1.Hide();

            salesPro.Refresh();
            salesPro.Dock = DockStyle.Fill;
            salesPro.TopLevel = false;
            panelMain.Controls.Add(salesPro);
            salesPro.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            salesPro.Hide();
            salesCus.Hide();
            info.Hide();
            label1.Hide();

            salesPur.Refresh();
            salesPur.Dock = DockStyle.Fill;
            salesPur.TopLevel = false;
            panelMain.Controls.Add(salesPur);
            salesPur.Show();
        }

        private void btnCusInfo_Click(object sender, EventArgs e)
        {
            salesPro.Hide();
            salesPur.Hide();
            info.Hide();
            label1.Hide();

            salesCus.Refresh();
            salesCus.Dock = DockStyle.Fill;
            salesCus.TopLevel = false;
            panelMain.Controls.Add(salesCus);
            salesCus.Show();
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            salesPro.Hide();
            salesPur.Hide();
            salesCus.Hide();
            label1.Hide();

            info.Refresh();
            info.Dock = DockStyle.Fill;
            info.TopLevel = false;
            panelMain.Controls.Add(info);
            info.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new login().Visible = true;
            DataAccess.CloseConnection();
        }

        private void Salesmanhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            new login().Visible = true;
            DataAccess.CloseConnection();
        }
    }
}
