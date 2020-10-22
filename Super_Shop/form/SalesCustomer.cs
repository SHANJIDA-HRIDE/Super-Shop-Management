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
    public partial class SalesCustomer : Form
    {
        public SalesCustomer()
        {
            InitializeComponent();
        }

        private void SalesCustomer_Load(object sender, EventArgs e)
        {
            string sql = @"select userid, name, gender, phonenumber, email, address from Person where usertype = 3";
            this.dgvSaleCustomer.DataSource = DataAccess.GetDataTable(sql);
        }
    }
}
