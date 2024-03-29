﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    internal class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=PersonelTakip;Integrated " +
            "Security=True;Pooling=False");

        public static void ESG(SqlCommand cmd, string sql)
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public static DataTable ListeleAra(DataGridView gridView, string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }
    }
}
