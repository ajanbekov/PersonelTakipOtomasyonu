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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        public static SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=PersonelTakip;Integrated " +
            "Security=True;Pooling=False"); 

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboDepartman);
            YenidenListele();
        }

        private void YenidenListele()
        {
            this.WindowState = FormWindowState.Maximized;
            Veritabani.ListeleAra(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefonu, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID");
            lblToplamKayit.Text = "TOPLAM " + (dataGridView1.Rows.Count - 1) + " KAYIT LİSTELENDİ.";
            Decimal toplamMaas = 0;

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                toplamMaas += decimal.Parse(dataGridView1.Rows[i].Cells["Maasi"].Value.ToString());
            }

            lblToplamMaas.Text = "TOPLAM MAAŞ TUTARI = " + toplamMaas + " TL.";
        }

        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboDepartman.Text = "";
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
            // sutün seçmeden güncelleme işlemini engellemek için kod parçası
            if (string.IsNullOrWhiteSpace(txtPersonelID.Text) || !int.TryParse(txtPersonelID.Text, out int personelID))
            {
                MessageBox.Show("LÜTFEN ÖNCE BİR PERSONEL SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            Personeller personeller = new Personeller();
            personeller.PersonelID=int.Parse(txtPersonelID.Text); 
            personeller.Adi = txtAdi.Text;
            personeller.Soyadi = txtSoyadi.Text;
            personeller.Telefon = txtTelefonu.Text;
            personeller.Adres = txtAdres.Text;
            personeller.Email = txtEmail.Text;
            personeller.DepartmanID = (int)comboDepartman.SelectedValue;
            personeller.Maasi = decimal.Parse(txtMaas.Text);
            personeller.GirisTarihi = (dateTimePickerGirisTarihi.Value);
            personeller.Aciklama = txtAciklama.Text;

            string sorgu = "update Personeller set Adi = @Adi, Soyadi = @Soyadi, Telefonu = @Telefon, " +
            "Adres = @Adres, Email = @Email, DepartmanID = @DepartmanID, Maasi = @Maasi, " +
            "GirisTarihi = @GirisTarihi, Aciklama = @Aciklama where PersonelID = @PersonelID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Adi", personeller.Adi);
            komut.Parameters.AddWithValue("@Soyadi", personeller.Soyadi);
            komut.Parameters.AddWithValue("@Telefon", personeller.Telefon);
            komut.Parameters.AddWithValue("@Adres", personeller.Adres);
            komut.Parameters.AddWithValue("@Email", personeller.Email);
            komut.Parameters.AddWithValue("@DepartmanID", personeller.DepartmanID);
            komut.Parameters.AddWithValue("@Maasi", personeller.Maasi);
            komut.Parameters.AddWithValue("@GirisTarihi", personeller.GirisTarihi);
            komut.Parameters.AddWithValue("@Aciklama", personeller.Aciklama);
            komut.Parameters.AddWithValue("@PersonelID", personeller.PersonelID);
            Veritabani.ESG(komut, sorgu);
            Temizle();
            MessageBox.Show("GÜNCELLEME İŞLEMİ YAPILDI.", "GÜNCELLEME İŞLEMİ.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            YenidenListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("SEÇİLEN PERSONELİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "PERSONEL SİLME ONAYI.", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (sonuc == DialogResult.Yes)
            {
                Personeller personeller = new Personeller();
                personeller.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
                personeller.CikisTarihi = DateTime.Now;

                string sorgu = "delete from Personeller where PersonelID = '" + personeller.PersonelID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                Veritabani.ListeleAra(dataGridView1, "select * from Personeller");
                MessageBox.Show("SİLİNDİ");
                Temizle();

                string sorgu2 = "update Personeller set Durumu = 'Pasif', CikisTarihi = @CikisTarihi where PersonelID = '"
                    +personeller.PersonelID+"'";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@CikisTarihi", SqlDbType.Date).Value = personeller.CikisTarihi;
                Veritabani.ESG(komut2, sorgu2);
                Temizle();
                MessageBox.Show("PERSONEL SİLİNDİ.", "SİLME İŞLEMİ.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                YenidenListele();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefonu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePickerGirisTarihi.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void txtIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.ListeleAra(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefonu, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and PersonelID like" +
                " '%" + txtIDAra.Text + "%'");
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.ListeleAra(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefonu, p.Adres, p.Email, d.Departman, p.Durumu, " +
               "p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Adi like" +
               " '%" + txtAdAra.Text + "%'");
        }

        private void txtSoyadAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.ListeleAra(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefonu, p.Adres, p.Email, d.Departman, p.Durumu, " +
               "p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Soyadi like" +
               " '%" + txtSoyadAra.Text + "%'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGoreAra(dateTimePicker1, dataGridView1);
        }

        private void frmPersonelListele_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSil.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.G)
            {
                btnGuncelle.PerformClick();
            }
        }
    }
}
