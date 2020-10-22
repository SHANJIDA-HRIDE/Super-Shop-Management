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
    public partial class Mngr_Transaction : Form
    {
        public Mngr_Transaction()
        {
            InitializeComponent();

            string sql = @"select pricecom ,soldquantity,priceps from Product ";
            DataTable Table = DataAccess.GetDataTable(sql);

           

            int pricecom = 0;
            int priceps = 0;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                pricecom += Convert.ToInt32(Table.Rows[i][0].ToString())* Convert.ToInt32(Table.Rows[i][1].ToString());
                bought.Text = Convert.ToString(pricecom);

                priceps += Convert.ToInt32(Table.Rows[i][1].ToString()) * Convert.ToInt32(Table.Rows[i][2].ToString());
                sold.Text = Convert.ToString(priceps);
            }

            //grid view
            string sql2 = @"select * from Purchase ";
            this.dgvPurchase.DataSource = DataAccess.GetDataTable(sql2);
           
        }

        

        private void dgvPurchase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dataRow = dgvPurchase.CurrentRow;
           
            txtItem.Text = dataRow.Cells[3].Value.ToString();
            // txtQuantity.Text = dataRow.Cells[4].Value.ToString();

            string sql = @"select soldquantity,totalquantity, availablequantity, priceps from Product where productname='"+txtItem.Text+"' ";
            DataTable Table = DataAccess.GetDataTable(sql);

            txtSQ.Text = Table.Rows[0][0].ToString();
            txtTQ.Text = Table.Rows[0][1].ToString();
            txtAQ.Text= Table.Rows[0][2].ToString();
            txtSP.Text = Table.Rows[0][3].ToString();
            txtSold.Text =Convert.ToString( Convert.ToInt32(Table.Rows[0][0].ToString())* Convert.ToInt32(Table.Rows[0][3].ToString()));
        }
    }
}
