using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            comboSoru.Text = "";
            foreach (Control item in Controls) 
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text =="" && txtCevap.Text =="" && txtKullaniciAdi.Text =="" && txtSifre.Text =="" && txtSifreTekrar.Text == "" &&
                comboSoru.Text == "" && txtKullaniciID.Text == "")
            {
                MessageBox.Show("LÜTFEN GEREKLİ YERLERİ DOLDURUNUZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = int.Parse(txtKullaniciID.Text);
                k.KullaniciAdi = txtKullaniciAdi.Text;
                k.Sifre = txtSifre.Text;
                k.SifreTekrar = txtSifreTekrar.Text;
                k.AdiSoyadi = txtAdiSoyadi.Text;
                k.Soru = comboSoru.Text;
                k.Cevap = txtCevap.Text;
                k.Tarih = DateTime.Now;

                if (txtSifre.Text == txtSifreTekrar.Text) // eğer girilen şifre ile şifre tekrarı uygunsa bu işlem uygulansın
                {
                    string sql = "insert into Kullanicilar values ('" + k.KullaniciAdi + "', '" + k.Sifre + "', '" + k.SifreTekrar + "', '" + k.AdiSoyadi + "', '" + k.Soru +
                    "', '" + k.Cevap + "', @Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show("YENİ KULLANICI EKLENDİ.", "EKLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("ŞİFRELER UYUŞMUYOR.", "UYARI.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmYeniKullanici_Load(object sender, EventArgs e)
        {
            // comboBox'ların enter olaylarına işleyici ataması yapılıyor
            comboSoru.Enter += ComboBoxOtomatikAcilsin;
        }

        private void ComboBoxOtomatikAcilsin(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            combo.DroppedDown = true;
        }
    }
}
