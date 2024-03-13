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
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text == "" && txtKullaniciAdi.Text == "" && txtKullaniciID.Text == "" && txtSifre.Text == "" && 
                txtSifreTekrar.Text == "")
            {
                MessageBox.Show("LÜTFEN GEREKLİ BOŞLUKLARI DOLDURUNUZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    string sql = "update Kullanicilar set KullaniciAdi='" + k.KullaniciAdi + "', Sifre='" + k.Sifre + "', SifreTekrar='" + k.SifreTekrar + "', AdiSoyadi='" + k.AdiSoyadi + "'," +
                    " Soru='" + k.Soru + "', Cevap='" + k.Cevap + "', Tarih=@Tarih where KullaniciID= '" + k.KullaniciID + "'";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show("YENİ KULLANICI EKLENDİ", "YENİ KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }

                else
                {
                    MessageBox.Show("ŞİFRELER UYUŞMUYOR.", "UYARI.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
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
