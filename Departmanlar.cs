using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    internal class Departmanlar
    {
        private int departmanID;
        private string departman;
        private string aciklama;

        public int DepartmanID { get => departmanID; set => departmanID = value; }

        public string Departman { get => departman; set => departman = value; }

        public string Aciklama { get => aciklama; set => aciklama = value; }

        public static SqlDataReader DepartmanGetir(ListView lst)
        {
            lst.Items.Clear();
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Departmanlar", Veritabani.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read[0].ToString();
                ekle.SubItems.Add(read[1].ToString());
                ekle.SubItems.Add(read[2].ToString());
                lst.Items.Add(ekle); 
            }
            Veritabani.baglanti.Close();
            return read;
        }
    }
}
