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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboDepartman);

            // comboBox'ların enter olaylarına işleyici ataması yapılıyor
            comboDepartman.Enter += ComboBoxOtomatikAcilsin;
        }

        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboDepartman.Text = "";
            foreach  (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" && txtAdi.Text == "" && txtAdres.Text == "" && txtEmail.Text == "" && txtMaas.Text == "" && 
                txtSoyadi.Text == "" && txtTelefonu.Text == "") // şu TextBox'lar boşsa hata verecek
            {
                MessageBox.Show("LÜTFEN GEREKLİ BİLGİLERİ DOLDURUNUZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Personeller personeller = new Personeller();
                personeller.Adi = txtAdi.Text;
                personeller.Soyadi = txtSoyadi.Text;
                personeller.Telefon = txtTelefonu.Text;
                personeller.Adres = txtAdres.Text;
                personeller.Email = txtEmail.Text;
                personeller.DepartmanID = (int)comboDepartman.SelectedValue;
                personeller.Maasi = decimal.Parse(txtMaas.Text);
                personeller.GirisTarihi = dateTimePickerGirisTarihi.Value;
                personeller.Aciklama = txtAciklama.Text;

                string sorgu = "insert into Personeller(Adi, Soyadi, Telefonu, Adres, Email, DepartmanID, Maasi, GirisTarihi, Aciklama) values" +
                "('" + personeller.Adi + "', '" + personeller.Soyadi + "', '" + personeller.Telefon + "', '" + personeller.Adres + "', '" + personeller.Email + "'," +
                "'" + personeller.DepartmanID + "', @Maasi, @GirisTarihi, '" + personeller.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = personeller.Maasi;
                komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = personeller.GirisTarihi;
                Veritabani.ESG(komut, sorgu);
                Temizle();
                MessageBox.Show("PERSONEL EKLENDİ.", "EKLEME İŞLEMİ.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }        
        }

        private void ComboBoxOtomatikAcilsin(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            combo.DroppedDown = true;
        }
    }
}
