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
    public partial class SalesPurchase : Form
    {
        public SalesPurchase()
        {
            InitializeComponent();
            string sql = @"select * from Purchase where salesid = '" + UserLogin.UserId + "'";
            this.dgvSalePurchase.DataSource = DataAccess.GetDataTable(sql);
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = @"select * from Purchase where salesid = '" + UserLogin.UserId + "'";
            this.dgvSalePurchase.DataSource = DataAccess.GetDataTable(sql);
        }
    }
}
