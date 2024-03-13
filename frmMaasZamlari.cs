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
    public partial class frmMaasZamlari : Form
    {
        public frmMaasZamlari()
        {
            InitializeComponent();
        }

        private void radioYuzde_CheckedChanged(object sender, EventArgs e)
        {
            txtYuzde.Enabled = true;
            txtFiyat.Enabled = false;
        }

        private void radioFiyat_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = true;
            txtYuzde.Enabled = false;
        }

        private void frmMaasZamlari_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil-5); i--)
            {
                comboYil.Items.Add(i);
            }

            YapilanZamlar.ComboyaPersonelGetir(comboPersoneller);

            // comboBox'ların enter olaylarına işleyici ataması yapılıyor
            comboAy.Enter += ComboBoxOtomatikAcilsin;
            comboYil.Enter += ComboBoxOtomatikAcilsin;
            comboPersoneller.Enter += ComboBoxOtomatikAcilsin;
        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPersoneller.SelectedIndex == 0) 
            {
                lblPersonelID.Text = "0";
                return;
            } 
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersoneller, lblPersonelID);

            int personelID = Convert.ToInt32(lblPersonelID.Text); // comboPersoneller'de bir personel seçildiğinde mevcut maaşı gösterir
            decimal mevcutMaas = YapilanZamlar.PersonelinMevcutMaasi(personelID);
            labelMevcutMaasi.Text = "MEVCUT MAASİ = " + mevcutMaas.ToString("C2");
        }

        void Temizle()
        {
            comboAy.Text = "";
            comboPersoneller.Text = "";
            comboYil.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" && txtFiyat.Text == "" && txtYuzde.Text == "" && comboAy.Text == "" && comboPersoneller.Text == "" &&
                comboYil.Text == "") // eğer bu TextBox ve ComboBox'lar boşsa mesaj versin yoksa maaş zammı yapsın
            {
                MessageBox.Show("LÜTFEN ÖNCE GEREKLİ BİLGİLERİ GİRİNİZ.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Kullanicilar kull = new Kullanicilar();
                YapilanZamlar yz = new YapilanZamlar();
                yz.Donem = comboAy.Text + "/" + comboYil.Text;
                yz.Personel = comboPersoneller.Text;
                yz.Aciklama = txtAciklama.Text;
                kull.KullaniciID = Kullanicilar.kullID;
                yz.Tarih = DateTime.Now;

                if (radioYuzde.Checked)
                {
                    decimal yuzde = decimal.Parse(txtYuzde.Text);

                    if (comboPersoneller.SelectedIndex == 0) // eğer tüm personeller seçiliyse bu işlem uygulanacak
                    {
                        string sql = "update Personeller set Maasi = Maasi + (Maasi* '" + yuzde + "') / 100 ";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        Temizle();
                        labelMevcutMaasi.Text = "";
                        MessageBox.Show("TÜM PERSONELLERİN MAAŞINA YÜZDE "+yuzde+" ZAM YAPILDI.", "BAŞARILI İŞEM.", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
                    }
                    else // eğer tek bir personel seçiliyse bu işlem uygulancak
                    {
                        string sql = "update Personeller set Maasi=Maasi+(Maasi*'"+yuzde+"') / 100 where PersonelID= '"+lblPersonelID.Text+"'";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("" + comboPersoneller.Text + " Personelinin Maaşına Yüzde " + yuzde + " Zam Yapıldı.", "Başarılı İşlem.",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                    string sql2 = "insert into YapilanZamlar(KullaniciID, Donem, Personeller, Yuzde, Fiyat, Aciklama, Tarih) " +
                        "values (@KullaniciID, @Donem, @Personeller, @Yuzde, @Fiyat, @Aciklama, @Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kull.KullaniciID;
                    komut2.Parameters.Add("@Donem", SqlDbType.VarChar, 50).Value = yz.Donem;
                    komut2.Parameters.Add("@Personeller", SqlDbType.VarChar, 250).Value = yz.Personel;
                    komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = yz.Yuzde;
                    komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = yz.Fiyat;
                    komut2.Parameters.Add("@Aciklama", SqlDbType.VarChar, 250).Value = yz.Aciklama;
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = yz.Tarih;
                    Veritabani.ESG(komut2, sql2);
                }

                if (radioFiyat.Checked)
                {
                    decimal fiyat = decimal.Parse(txtFiyat.Text.Replace(",", "."));

                    if (comboPersoneller.SelectedIndex == 0) // comboPersoneller combsunda Tüm Personller seçiliyse bu işlemi yap 
                    {
                        string sql = "update Personeller set Maasi = Maasi + '" + fiyat + "'";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("TÜM PERSONELLERİN MAAŞINA " + fiyat + " TL ZAM YAPILDI.", "BAŞARILI İŞEM.", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
                        Temizle();
                        labelMevcutMaasi.Text = "MEVCUT MAAŞ = 0 TL";
                    }
                    else
                    {
                        string sql = "update Personeller set Maasi = Maasi + '" + fiyat + "' where PersonelID = '" + lblPersonelID.Text + "'";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("'"+comboPersoneller.Text+"' Personelinin Maaşına '" + fiyat + "' TL Zam Yapıldı.", "Başarılı İşlem.",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        Temizle();
                        labelMevcutMaasi.Text = "MEVCUT MAAŞ = 0 TL";
                    }
                    yz.Fiyat = fiyat; // YapilanZamlar sınıfına "Fiyat" değerini atadık

                    string sql2 = "insert into YapilanZamlar(KullaniciID, Donem, Personeller, Yuzde, Fiyat, Aciklama, Tarih) " +
                        "values (@KullaniciID, @Donem, @Personeller, @Yuzde, @Fiyat, @Aciklama, @Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kull.KullaniciID;
                    komut2.Parameters.Add("@Donem", SqlDbType.VarChar, 50).Value = yz.Donem;
                    komut2.Parameters.Add("@Personeller", SqlDbType.VarChar, 250).Value = yz.Personel;
                    komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = yz.Yuzde;
                    komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = yz.Fiyat;
                    komut2.Parameters.Add("@Aciklama", SqlDbType.VarChar, 250).Value = yz.Aciklama;
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = yz.Tarih;
                    Veritabani.ESG(komut2, sql2);
                }
            }
        }

        private void ComboBoxOtomatikAcilsin(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            combo.DroppedDown = true;
        }

        private void frmMaasZamlari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
