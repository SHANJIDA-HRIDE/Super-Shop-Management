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
using System.Data.SqlClient;

namespace Super_Shop.form
{
    public partial class SalesProduct : Form
    {
        private SqlConnection sqlConnection;
        private int Salesid;
           private int Customerid;
        private int quantity1;
        private int price;
        private string daytime;
        public SalesProduct()
        {
            InitializeComponent();
            
        }

       
        private void SalesProduct_Load(object sender, EventArgs e)
        {
            this.txtSalesId.Text = Convert.ToString(UserLogin.UserId);
            SqlConnection con = new SqlConnection();

            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\SEMISTER-9\C#\FINAL-C#\project\Final_Project\Super_Shop\Super_Shop\Shop.mdf;Integrated Security=True;Connect Timeout=30");

            var query = "select productname from Product";
            ////Generating SQL Query
            SqlCommand cmd = new SqlCommand(query, con);

            //Opening the connection:
            con.Open();


            
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtProduct.AutoCompleteCustomSource = MyCollection;

            string sql = @"select * from Product";
            this.dgvProductList.DataSource = DataAccess.GetDataTable(sql);

           con.Close();

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            
            //adding purchase
            this.sqlConnection = DataAccess.Sqlcon;
            //bool credentialsMatched = Pro(this.txtProduct.Text);
            //if (credentialsMatched)
            //{
                try
                {
                    if (Product.Availablequantity != 0)
                    {
                        Salesid = Convert.ToInt32(txtSalesId.Text);
                        Customerid = Convert.ToInt32(txtCustomerid.Text);
                        quantity1 = Convert.ToInt32(txtQuantity.Text);
                        price = quantity1 * Convert.ToInt32(txtPrice.Text);
                        daytime = DateTime.Today.ToString("dd-MM-yyyy");
                        string sql2 = @"insert into Purchase values('" + Salesid + "', '" + Customerid + "', '" + txtProduct.Text + "','" + quantity1 + "', '" + price + "', '" + daytime + "' )";
                        DataAccess.ExecuteQuery(sql2);
                    //new
                    string sql5 = @"insert into Show values('" + Salesid + "', '" + Customerid + "', '" + txtProduct.Text + "','" + quantity1 + "', '" + price + "', '" + daytime + "' )";
                    DataAccess.ExecuteQuery(sql5);
                }
                    else
                    { MessageBox.Show("this product is not available"); }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            //}

            //grid view
            string sql3 = @"select * from Show where salesid= '"+ Salesid +"' and customerid ='"+Customerid+"'";
            PopulateGridView(sql3);

            //total amount
            string sql4 = @"select price from Show where salesid= '" + Salesid + "' and customerid ='" + Customerid + "'";
            DataTable Table = DataAccess.GetDataTable(sql4);

            int pricepro = 0;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                pricepro += Convert.ToInt32(Table.Rows[i][0].ToString());
                txtTotalPrice.Text=Convert.ToString(pricepro);
            }

            txtProduct.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        

        public static bool Pro(string productname)
        {
            string sql = @"select * from Product where productname = '" + productname + "'";
            DataSet ds = DataAccess.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
               
                Product.ProductId = Convert.ToInt32(ds.Tables[0].Rows[0]["productid"].ToString());
                Product.Productname = ds.Tables[0].Rows[0]["productname"].ToString();
                Product.Totalquantity = Convert.ToInt32(ds.Tables[0].Rows[0]["totalquantity"].ToString());
                Product.Soldquantity = Convert.ToInt32(ds.Tables[0].Rows[0]["soldquantity"].ToString());
                Product.Availablequantity = Convert.ToInt32(ds.Tables[0].Rows[0]["availablequantity"].ToString());
                Product.Price = Convert.ToInt32(ds.Tables[0].Rows[0]["priceps"].ToString());
                
                
            }
            return true;
        }

        private void PopulateGridView(string query )
        {
            this.dgvAddProduct.DataSource = DataAccess.GetDataTable(query);
            
        }

        private void txtPrice_MouseClick(object sender, MouseEventArgs e)
        {
            bool credentialsMatched = Pro(this.txtProduct.Text);
            if (credentialsMatched)
            {
                string price = Convert.ToString(Product.Price);
                txtPrice.Text = price;
                //Console.WriteLine(Product.Availablequantity);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.dgvAddProduct.DataSource = null;
            txtTotalPrice.Clear();
            txtCustomerid.Clear();
            txtProduct.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            //this.sqlConnection = DataAccess.Sqlcon;
           
                    string sql = @"select productname, quantity from Show where salesid= '" + Salesid + "' and customerid ='" + Customerid + "' and daytime='" + daytime + "'";
                    DataTable Table = DataAccess.GetDataTable(sql);

                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        string Name = Table.Rows[i][0].ToString();
                        bool credentialsMatched = Pro(Name);
                        if (credentialsMatched)
                        {
                                try
                                {
                                    
                                    int quantity = Convert.ToInt32(Table.Rows[i][1].ToString());

                                    //int quantity = Convert.ToInt32(txtQuantity.Text);
                                    int sold = Product.Soldquantity + quantity;
                                    int available = Product.Totalquantity - sold;
                                    //Console.WriteLine(Name);
                                    //Console.WriteLine(sold);


                                    string sql1 = @"update Product
                                            set soldquantity = '" + sold + @"',
                                            availablequantity = '" + available + @"'
                                            where productname = '" + Name + "';";
                                    DataAccess.ExecuteQuery(sql1);
                                    //MessageBox.Show("Successful");
                                }
                                catch (Exception exc)
                                { MessageBox.Show(exc.Message); }
                         }

                    }


            string sql2 = @"delete from Show";
            DataAccess.ExecuteQuery(sql2);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          try
            { 
                Salesid = Convert.ToInt32(txtSalesId.Text);
                Customerid = Convert.ToInt32(txtCustomerid.Text);
                quantity1 = Convert.ToInt32(txtQuantity.Text);
                price = quantity1 * Convert.ToInt32(txtPrice.Text);
                daytime = DateTime.Today.ToString("dd-MM-yyyy");
                string sql1 = @"update Purchase
                                                set quantity = '" + quantity1 + @"',
                                                price = '" + price + @"'
                                                where productname = '" + txtProduct.Text + "' and daytime = '" + daytime + "' and  salesid = '" + Salesid + "' and customerid = '" + Customerid + "' ;";
                DataAccess.ExecuteQuery(sql1);
                string sql2 = @"update Show
                                                set quantity = '" + quantity1 + @"',
                                                price = '" + price + @"'
                                                where productname = '" + txtProduct.Text + "' and daytime = '" + daytime + "' and  salesid = '" + Salesid + "' and customerid = '" + Customerid + "' ;";
                DataAccess.ExecuteQuery(sql2);

                //Grid View
                string sql3 = @"select * from Show where salesid= '" + Salesid + "' and customerid ='" + Customerid + "'";
                PopulateGridView(sql3);

                //total amount
                string sql4 = @"select price from Show where salesid= '" + Salesid + "' and customerid ='" + Customerid + "'";
                DataTable Table = DataAccess.GetDataTable(sql4);

                int pricepro = 0;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    pricepro += Convert.ToInt32(Table.Rows[i][0].ToString());
                    txtTotalPrice.Text = Convert.ToString(pricepro);
                }

                txtProduct.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

       

        private void dgvAddProduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                DataGridViewRow dataRow = dgvAddProduct.CurrentRow;
                // txtProId.Text = dataRow.Cells[0].Value.ToString();
                txtProduct.Text = dataRow.Cells[3].Value.ToString();
                txtQuantity.Text = dataRow.Cells[4].Value.ToString();
                

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Salesid = Convert.ToInt32(txtSalesId.Text);
                Customerid = Convert.ToInt32(txtCustomerid.Text);
                quantity1 = Convert.ToInt32(txtQuantity.Text);
                //price = quantity1 * Convert.ToInt32(txtPrice.Text);
                daytime = DateTime.Today.ToString("dd-MM-yyyy");
                int total = (quantity1 * Convert.ToInt32(txtTotalPrice.Text)) - price;
                txtTotalPrice.Text = Convert.ToString(total);

                string sql = @"delete from Purchase  where productname = '" + txtProduct.Text + "' and daytime = '" + daytime + "' and  salesid = '" + Salesid + "' and customerid = '" + Customerid + "' ;";
                DataAccess.ExecuteQuery(sql);

                string sql1 = @"delete from Show  where productname = '" + txtProduct.Text + "' and daytime = '" + daytime + "' and  salesid = '" + Salesid + "' and customerid = '" + Customerid + "' ;";
                DataAccess.ExecuteQuery(sql1);

                //Grid View
                string sql3 = @"select * from Show where salesid= '" + Salesid + "' and customerid ='" + Customerid + "'";
                PopulateGridView(sql3);

                txtProduct.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
