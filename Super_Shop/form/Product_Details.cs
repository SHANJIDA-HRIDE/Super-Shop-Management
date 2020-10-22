using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Super_Shop
{
    public partial class Product_Details : Form
    {
        private SqlConnection sqlConnection;
        


        public Product_Details()
        {
            InitializeComponent();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Details_Load(object sender, EventArgs e)
        {

            this.sqlConnection = DataAccess.Sqlcon;
            string sql = @"select productid, productname,availablequantity, priceps from Product";
            this.dgvProductDetails.DataSource = DataAccess.GetDataTable(sql);
            

        }

        private void txtSrchProduct_TextChanged(object sender, EventArgs e)
        {
            this.sqlConnection = DataAccess.Sqlcon;
            string sql1 = @"select productid, productname,availablequantity, priceps from Product where productname like '%" + this.txtSrchProduct.Text + @"%'";
            this.dgvProductDetails.DataSource = DataAccess.GetDataTable(sql1);

        }
   
        
    }
}
