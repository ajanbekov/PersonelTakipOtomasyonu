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
using System.Windows.Forms.VisualStyles;

namespace PersonelTakipOtomasyonu
{
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        private void frmPrimGoster_Load(object sender, EventArgs e)
        {
            Veritabani.ListeleAra(dataGridView1, "select * from Primler");
            
            int yil = int.Parse(DateTime.Now.Year.ToString()); 
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }

            comboAy.Enter += ComboBoxOtomatikAcilsin;
            comboYil.Enter += ComboBoxOtomatikAcilsin;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ödenme Durumunda "Ödenmedi" yazıyorsa boşlukları doldur
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutari.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

                // PersonalID'ye göre personal ad soyad getirir
                string adSoyad = Primler.PersonelAdSoyadGetir(txtPersonelID.Text);
                txtPersonelAdSoyad.Text = adSoyad;
            }

            // ödenme durumu "Ödenmedi" değilse ve "PersonelID" 0 ise "Tüm Personeller" yazdır 
            if (dataGridView1.CurrentRow.Cells["PersonalID"].Value.ToString() == "0")
            {
                txtPersonelAdSoyad.Text = "Tüm Personeller";
            }
        }

        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            bool allPaid = true; // başta tüm primleri ödendi olarak alıcaz

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    int primID = int.Parse(row.Cells["PrimID"].Value.ToString());
                    Primler p = new Primler();
                    p.PrimID = primID;
                    p.OdenmeDurumu = "Ödendi";
                    string sql = "update Primler set OdenmeDurumu = '" + p.OdenmeDurumu + "' where PrimID = '" + p.PrimID + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    allPaid = false; // burada ödenmeyen orim olursa false olacak
                }
            }
                
            Veritabani.ListeleAra(dataGridView1, "select * from Primler");
            Temizle();

            if (allPaid == true) // eğer tüm primler ödendiyse aşağıdaki mesaj
            {
                MessageBox.Show("ÖDENECEK PRİM YOK.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else // ödenmeyen primeler varsa aşağıdaki mesaj
            {
                MessageBox.Show("TÜM PRİMLERİN ÖDEMESİ YAPILDI.", "PRİM ÖDEME İŞLEMİ.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" && txtPersonelAdSoyad.Text == "" && txtPersonelID.Text == "" && txtPrimID.Text == "" && 
                txtPrimTutari.Text == "")
            {
                MessageBox.Show("LÜTFEN ÖDENMEMİŞ BİR PRİM SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kullID;
                Primler p = new Primler();
                p.PersonalID = int.Parse(txtPersonelID.Text);
                p.Aciklama = txtAciklama.Text;
                p.PrimID = int.Parse(txtPrimID.Text);
                p.OdenmeDurumu = "Ödendi";

                string sql = "update Primler set OdenmeDurumu = '" + p.OdenmeDurumu + "' where PrimID = '" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                Veritabani.ListeleAra(dataGridView1, "select * from Primler");
                Temizle();
                MessageBox.Show("SEÇİLİ OLAN PRİM ÖDEMESİ YAPILDI.", "PRİM ÖDEMESİ.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" && txtPersonelAdSoyad.Text == "" && txtPersonelID.Text == "" && txtPrimID.Text == "" &&
                txtPrimTutari.Text == "")
            {
                MessageBox.Show("LÜTFEN ÖNCE GÜNCELLENECEK BİR PRİM SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Primler p = new Primler();
                p.PrimID = int.Parse(txtPrimID.Text);
                p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
                p.Aciklama = txtAciklama.Text;
                p.PersonalID = int.Parse(txtPersonelID.Text);

                string sql = "update Primler set PersonalID = '"+p.PersonalID+"', PrimTutari = '"+p.PrimTutari+"', Aciklama = '"
                    +p.Aciklama+"' where PrimID = '"+p.PrimID+"'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                Veritabani.ListeleAra(dataGridView1, "select * from Primler");
                Temizle();
                MessageBox.Show("PRİM BİLGİLERİ GÜNCELLENDİ.", "BİLGİLENDİRME.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // önce dataGridView1'den bir kayıt seçip seçmediğime bakacak
            {
                DialogResult sonuc = MessageBox.Show("SEÇİLİ PRİMİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "PRİM SİLME ONAYI.", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question); // onay vermesi halinde silecek

                if (sonuc == DialogResult.Yes) // yes tuşu tuşlanırsa prim silinecek
                {
                    Primler p = new Primler();
                    p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());
                    string sorgu = "delete from Primler where PrimID = '" + p.PrimID + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sorgu);
                    Veritabani.ListeleAra(dataGridView1, "select * from Primler");
                    MessageBox.Show("PRİM SİLİNDİ.", "BİLGİ.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Temizle();
                }

                else if (sonuc == DialogResult.No) // cevap hayırsa silme işlemi iptal edilir 
                {
                    Veritabani.ListeleAra(dataGridView1, "select * from Primler");
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ PRİMİ SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            if (txtPrimTutari.Text == "" && txtPrimID.Text == "" && txtPersonelID.Text == "" && txtPersonelAdSoyad.Text == "" &&
                txtAciklama.Text == "")
            {
                MessageBox.Show("LÜTFEN ÖNCE BİR PRİM SEÇİNİZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Primler p = new Primler();
                p.Donem = comboAy.Text + "/" + comboYil.Text;
                p.PrimID = int.Parse(txtPrimID.Text);
                string sql = "update Primler set Donem = '" + p.Donem + "' where PrimID = '" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                Veritabani.ListeleAra(dataGridView1, "select * from Primler");
                Temizle();
                MessageBox.Show("DÖNEM DEĞİŞTİRİLDİ.", "DÖNEM DEĞİŞTİRME.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxOtomatikAcilsin(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            combo.DroppedDown = true;
        }

        private void frmPrimleriGoster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                btnTumPrimleriOde.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.G)
            {
                btnPrimGuncelle.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                btnDonemDegistir.PerformClick();
            }

            if (e.KeyCode == Keys.Delete)
            {
                btnPrimSil.PerformClick();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnPrimOde.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Cikis.PerformClick();
            }
        }

        void Temizle()
        {
            comboAy.Text = "";
            comboYil.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
