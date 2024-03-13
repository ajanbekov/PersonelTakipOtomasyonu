using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    internal class Primler
    {
        #region Kapsulleme
        private int _PrimID;
        private int _PersonalID;
        private int _KullaniciID;
        private string _Donem;
        private string _OdenmeDurumu;
        private decimal _PrimTutari;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Islem;

        public int PrimID { get => _PrimID; set => _PrimID = value; }
        public int PersonalID { get => _PersonalID; set => _PersonalID = value; }
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public decimal PrimTutari { get => _PrimTutari; set => _PrimTutari = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        #endregion

        // PersonelID'ye göre PersonelAdSoyad getirme
        public static string PersonelAdSoyadGetir(string personelID)
        {
            string adSoyad = string.Empty;
            using (SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9LLNTJQM\\SQLEXPRESS;Initial Catalog=PersonelTakip;Integrated Security=True"))
            {
                baglanti.Open();
                string sorgu = "SELECT Adi, Soyadi FROM Personeller WHERE PersonelID = @PersonelID";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@PersonelID", personelID);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        adSoyad = dr["Adi"].ToString() + " " + dr["Soyadi"].ToString();
                    }
                }
            }
            return adSoyad;
        }
    }
}
