﻿using System;
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
namespace Super_Shop
{
    public partial class Purchase_Details : Form
    {
        private SqlConnection sqlConnection;

        public Purchase_Details()
        {
            InitializeComponent();
            
        }

        private void Purchase_Details_Load(object sender, EventArgs e)
        {
            this.sqlConnection = DataAccess.Sqlcon;
            string sql = @"select * from Purchase where customerid = '" + UserLogin.UserId + "'";
            this.dgvPurchaseDetails.DataSource = DataAccess.GetDataTable(sql);
        }

        private void dgvPurchaseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
