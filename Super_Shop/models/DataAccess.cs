﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Super_Shop.models
{
    class DataAccess
    {
        private static SqlConnection sqlcon;

        public static SqlConnection Sqlcon
        {
            get
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\SEMISTER-9\C#\FINAL-C#\project\Final_Project\Super_Shop\Super_Shop\Shop.mdf;Integrated Security=True;Connect Timeout=30");
                }
                else if (sqlcon.State != ConnectionState.Open)
                {
                    sqlcon.Open();
                }
                return sqlcon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqlcon);
            return sqcom.ExecuteNonQuery();
        }

        /// <summary>
        /// Checks if a row exists in a table
        /// </summary>
        /// <param name="query"></param>
        /// <returns>true if row exits, otherwise false</returns>
        public static bool RowExists(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqlcon);
            SqlDataReader dr = sqcom.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            dr.Close();
            return false;
        }

        public static void CloseConnection()
        {
            if (sqlcon != null)
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
                sqlcon = null;
            }
        }
    }
}
