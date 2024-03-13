using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    internal class Personeller
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Telefon;
        private string _Adres;
        private string _Email;
        private int _DepartmanID;
        private decimal _Maasi;
        private DateTime _GirisTarihi;
        private string _Aciklama;
        private DateTime _Tarih;
        private DateTime _CikisTarihi;

        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public decimal Maasi { get => _Maasi; set => _Maasi = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public DateTime CikisTarihi { get => _CikisTarihi; set => _CikisTarihi = value; }


        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tablo = new DataTable();
            Veritabani.baglanti.Open();
            // Departmanları A'dan Z'ye doğru sıralamak için order by Departman ASC kullanırız
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Departmanlar order by Departman ASC", Veritabani.baglanti);
            adtr.Fill(tablo);
            combo.DataSource = tablo;
            combo.ValueMember = "DepartmanID"; // Arka planda tuttuğu değer
            combo.DisplayMember = "Departman"; // Görünecek değer
            Veritabani.baglanti.Close();
            return tablo;
        }

        public static DataTable TariheGoreAra(DateTimePicker tarih, DataGridView gridView)
        {
            DataTable tablo = new DataTable();
            Veritabani.baglanti.Open();
            // Departmanları A'dan Z'ye doğru sıralamak için order by Departman ASC kullanırız
            SqlDataAdapter adtr = new SqlDataAdapter("select p.PersonelID, p.Adi, p.Soyadi, p.Telefonu, p.Adres, p.Email, d.Departman, " +
                "p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and" +
                " GirisTarihi = @P1", Veritabani.baglanti);
            adtr.SelectCommand.Parameters.Add("@P1", SqlDbType.Date).Value = tarih.Value;
            adtr.Fill(tablo);
            gridView.DataSource = tablo;
            Veritabani.baglanti.Close();
            return tablo;
        }
    }
}
