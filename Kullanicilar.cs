using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtomasyonu
{
    internal class Kullanicilar
    {
        private int _KullaniciID;
        private string _KullaniciAdi;
        private string _Sifre;
        private string _SifreTekrar;
        private string _AdiSoyadi;
        private string _Soru;
        private string _Cevap;
        private DateTime _Tarih;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }
        public string AdiSoyadi { get => _AdiSoyadi; set => _AdiSoyadi = value; }
        public string Soru { get => _Soru; set => _Soru = value; }
        public string Cevap { get => _Cevap; set => _Cevap = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string SifreTekrar { get => _SifreTekrar; set => _SifreTekrar = value; }

        public static bool durum = false;
        public static int kullID = 0;

        public static SqlDataReader KullaniciGirisi (string kullaniciAdi, string sifre)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.KullaniciAdi = kullaniciAdi;
            kullanicilar.Sifre = sifre; 
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanicilar where kullaniciadi = '"+kullanicilar.KullaniciAdi+"' and sifre =" +
                " '"+kullanicilar.Sifre+"'", Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                kullID = int.Parse(dr[0].ToString());
            }
            else
            {
                durum = false;
            }
            dr.Close();
            Veritabani.baglanti.Close();
            return dr; // dönüşümüz SqlDataReader türünde olacak
        }
    }
}
