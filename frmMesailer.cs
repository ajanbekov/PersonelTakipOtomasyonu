using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            Veritabani.ListeleAra(dataGridView1, "select * from Mesailer");

            comboAy.Enter += ComboBoxOtomatikAcilsin;
            comboYil.Enter += ComboBoxOtomatikAcilsin;

            int yil = DateTime.Now.Year;
            for (int i = 0; i >= yil - 5 ; i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
            txtSaatUcreti.Text = dataGridView1.CurrentRow.Cells["SaatUcreti"].Value.ToString();
            txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

            string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
            string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
            string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();
            dateBaslangic.Text = baslangic.Substring(0, 10);
            mskdBaslangic.Text = baslangic.Substring(11);
            dateBitis.Text = bitis.Substring(0, 10);
            mskdBitis.Text = bitis.Substring(11);

            int say = donem.IndexOf("/");
            comboAy.Text = donem.Substring(0, say);
            comboYil.Text = donem.Substring(say+1);

            // PesonelID'ye göre personel ad soyad getirme
            string adSoyad = Primler.PersonelAdSoyadGetir(txtPersonelID.Text);
            txtAdiSoyadi.Text = adSoyad;
        }

        private void txtSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Başlangıç ve bitiş saati ve saatlik ücrete göre tutar hesaplama
                string baslangic = dateBaslangic.Text + " " + mskdBaslangic.Text;
                string bitis = dateBitis.Text + " " + mskdBitis.Text;
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double saatUcreti = double.Parse(txtSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * saatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch 
            {

            }
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // eğer dataGridView1'de bir satır seçilirse bu işlem yapılacak
            {
                if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    Kullanicilar k = new Kullanicilar();
                    k.KullaniciID = Kullanicilar.kullID;
                    Mesailer m = new Mesailer();
                    Personeller p = new Personeller();
                    m.MesaiID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    m.OdenmeDurumu = "Ödendi";

                    string sql = "update Mesailer set OdenmeDurumu = '" + m.OdenmeDurumu + "' where MesaiID = '" + m.MesaiID + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    Veritabani.ListeleAra(dataGridView1, "select * from Mesailer");
                    MessageBox.Show("İLGİLİ PERSONELİN MESAİ ÜCRETİ ÖDENDİ.", "BİLGİ.", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("LÜTFEN ÖDENMEMİŞ OLAN BİR MESAİ SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, 
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN ÖNCE ÖDENECEK OLAN MESAİ SEÇİMİ YAPINIZ.", "UYARI.", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
            bool allPaid = true; // başta tüm primler ödendi olarak alıcaz

            foreach (DataGridViewRow satir in dataGridView1.Rows)
            {
                if (satir.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    int mesaiID = int.Parse(satir.Cells["MesaiID"].Value.ToString());
                    Mesailer m = new Mesailer();
                    m.MesaiID = mesaiID;
                    m.OdenmeDurumu = "Ödendi";
                    
                    string sql = "update Mesailer set OdenmeDurumu = '"+m.OdenmeDurumu+"' where MesaiID = '"+m.MesaiID+"'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    allPaid = false;
                }
            }
            Veritabani.ListeleAra(dataGridView1, "select * from Mesailer");

            if (allPaid == true) // eğer tüm primler ödenmişse
            {
                MessageBox.Show("ÖDENCEK MESAİ ÜCRETİ BULUNAMADI.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (allPaid == false)
            {
                MessageBox.Show("ÖDENMEMİŞ OLAN MESAİ ÜCRETLERİNİN ÖDEMESİ YAPILDI.", "BİLGİ.", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtMesaiID.Text == "")
            {
                MessageBox.Show("LÜTFEN GÜNCELLEMEK İSTEDİĞİNİZ BİR MESAİYİ SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                Mesailer m = new Mesailer();
                Personeller p = new Personeller();  
                m.MesaiID = int.Parse(txtMesaiID.Text);
                p.PersonelID = int.Parse(txtPersonelID.Text);
                m.BaslangicSaati = dateBaslangic.Text + " " + mskdBaslangic.Text;
                m.BitisSaati = dateBitis.Text + " " + mskdBitis.Text;
                m.SaatUcreti = decimal.Parse(txtSaatUcreti.Text);   
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboAy.Text + "/" + comboYil.Text;
                m.Aciklama = txtAciklama.Text;

                string sql = "update Mesailer set PersonelID = '"+p.PersonelID+"', BaslangicSaati = '"+m.BaslangicSaati+"', BitisSaati = '"+
                    m.BitisSaati+ "', SaatUcreti = @SaatUcreti, Tutar = @Tutar, Donem ='"+m.Donem+"', Aciklama ='"
                    +m.Aciklama+"' where MesaiID = '"+m.MesaiID+ "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@SaatUcreti", SqlDbType.Decimal).Value = m.SaatUcreti;
                komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
                Veritabani.ESG(komut, sql);
                Veritabani.ListeleAra(dataGridView1, "select * from Mesailer");
                Temizle();
                MessageBox.Show("GÜNCELLEME İŞLEMİ YAPILDI.", "BİLGİ.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show("SEÇİLİ MESAİ BİLGİSİNİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "SİLME ONAYI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    Mesailer M = new Mesailer();
                    M.MesaiID = int.Parse(dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString());
                    string sorgu = "delete from Mesailer where MesaiID = '" + M.MesaiID + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sorgu);
                    Veritabani.ListeleAra(dataGridView1, "select * from Mesailer");
                    MessageBox.Show("MESAİ BİLGİLERİ SİLİNDİ.", "BAŞARILI İŞLEM.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Temizle();
                }

                else if (sonuc == DialogResult.No)
                {
                    Veritabani.ListeleAra(dataGridView1, "select * from Mesailer");
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLİNECEK OLAN MESAİYİ SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxOtomatikAcilsin (object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            combo.DroppedDown = true;
        }

        void Temizle()
        {
            comboAy.Text = "";
            comboYil.Text = "";
            mskdBaslangic.Text = "";
            mskdBitis.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void frmMesailer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMesaiOde.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                btnTumMesaileriOde.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                btnGuncelle.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnSil.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCikis.PerformClick();
            }
        }
    }
}
