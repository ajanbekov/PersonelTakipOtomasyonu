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
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            // comboYil içinde mevcut yili - 5 olarak alır
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5) ; i--)
            {
                comboYil.Items.Add(i);
            }

            // aşağıdaki combobox'lar otomatik şekilde açılacak
            comboAdSoyad.Enter += ComboOtomatikAcilsin;
            comboAy.Enter += ComboOtomatikAcilsin;
            comboYil.Enter += ComboOtomatikAcilsin;

            YapilanZamlar.ComboyaPersonelGetir(comboAdSoyad);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSaatUcreti.Text == "" && txtTutar.Text == "" && comboAdSoyad.Text == "" && comboAy.Text == "" && comboYil.Text == "")
            {
                MessageBox.Show("LÜTFEN GEREKLİ YERLERİ DOLDURUNUZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Personeller p = new Personeller();
                Kullanicilar k = new Kullanicilar();
                Mesailer m = new Mesailer();
                k.KullaniciID = Kullanicilar.kullID;
                p.PersonelID = int.Parse(lbl.Text);
                m.BaslangicSaati = dateBaslangic.Text + " " + maskedBaslangic.Text;
                m.BitisSaati = dateBitis.Text + " " + maskedBitis.Text;
                m.SaatUcreti = decimal.Parse(txtSaatUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboAy.Text + "/" + comboYil.Text;
                m.Aciklama = txtAciklama.Text;
                m.Tarih = DateTime.Now;

                string sql = "INSERT INTO Mesailer (KullaniciID, PersonelID, BaslangicSaati, BitisSaati, SaatUcreti, Tutar, Donem, Aciklama, Tarih) " +
                 "VALUES (@KullaniciID, @PersonelID, @BaslangicSaati, @BitisSaati, @SaatUcreti, @Tutar, @Donem, @Aciklama, @Tarih)";
                SqlCommand komut = new SqlCommand(sql, Veritabani.baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", k.KullaniciID);
                komut.Parameters.AddWithValue("@PersonelID", p.PersonelID);
                komut.Parameters.AddWithValue("@BaslangicSaati", m.BaslangicSaati);
                komut.Parameters.AddWithValue("@BitisSaati", m.BitisSaati);
                komut.Parameters.AddWithValue("@SaatUcreti", m.SaatUcreti);
                komut.Parameters.AddWithValue("@Tutar", m.Tutar);
                komut.Parameters.AddWithValue("@Donem", m.Donem);
                komut.Parameters.AddWithValue("@Aciklama", m.Aciklama);
                komut.Parameters.AddWithValue("@Tarih", m.Tarih);
                Veritabani.ESG(komut, sql);
                Veritabani.baglanti.Close();
                Temizle();
                MessageBox.Show("MESAİ KAYIDI YAPILDI.", "BAŞARILI İŞLEM.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        Label lbl;

        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer mesailer = new frmMesailer();
            mesailer.ShowDialog();
        }

        private void comboAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboAdSoyad, lbl);
        }

        private void ComboOtomatikAcilsin(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            combo.DroppedDown = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMesaiEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCikis.PerformClick();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnEkle.PerformClick();
            }
        }

        void Temizle()
        {
            maskedBaslangic.Text = "";
            maskedBitis.Text = "";
            comboAdSoyad.Text = "";
            comboYil.Text = "";
            comboAy.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateBaslangic.Text + " " + maskedBaslangic.Text;
                string bitis =  dateBitis.Text + " " + maskedBitis.Text;
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double saatUcreti = double.Parse(txtSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * saatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch 
            {

                
            }
        }
    }
}
