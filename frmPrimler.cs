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
    public partial class frmPrimler : Form
    {
        public frmPrimler()
        {
            InitializeComponent();
        }

        private void frmPrimler_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }

            Veritabani.ListeleAra(dataGridView1, "select PersonelID, Adi, Soyadi, Maasi, GirisTarihi from Personeller");

            comboAy.Enter += ComboBoxOtomatikAcilsin;
            comboYil.Enter += ComboBoxOtomatikAcilsin;
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

        private void btnPrimEkle_Click(object sender, EventArgs e)
        {
            if (comboAy.Text == "" && comboYil.Text == "" && txtPrimTutari.Text == "")
            {
                MessageBox.Show("LÜTFEN PERSONEL SEÇİMİ YAPINIZ.", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Primler p = new Primler();
                p.KullaniciID = Kullanicilar.kullID;
                p.Donem = comboAy.Text + "/" + comboYil.Text;
                p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
                p.Aciklama = txtAciklama.Text;
                p.Tarih = DateTime.Now;

                if (radioKisiyeOzel.Checked)
                {
                    p.PersonalID = int.Parse(txtPersonalID.Text);
                    string sql = "insert into Primler (KullaniciID, PersonalID, Donem, PrimTutari, Aciklama, Tarih) " +
                        "values ('" + p.KullaniciID + "', '" + p.PersonalID + "', '" + p.Donem + "', @PrimTutari, '"+p.Aciklama+"', @Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut, sql);
                    Temizle();
                    MessageBox.Show("PRİM EKLENDİ.", "PRİM EKLEME.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                else if (radioTumPersonellerIcin.Checked)
                {
                    p.PersonalID = 0; // Tüm personeller tek bir kayıt eklemek için sabit bir değer 
                    string sql = "insert into Primler (KullaniciID, PersonalID, Donem, PrimTutari, Aciklama, Tarih) " +
                        "values ('" + p.PersonalID + "', '" + p.PersonalID + "', '" + p.Donem + "', @PrimTutari, '" + p.Aciklama + "', @Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut, sql);
                    Temizle();
                    MessageBox.Show("PRİM EKLENDİ.", "PRİM EKLEME.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonalID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonalAdSoyad.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString()+" "+dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void ComboBoxOtomatikAcilsin (object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            combo.DroppedDown = true;
        }

        private void btnPrimleriGoster_Click(object sender, EventArgs e)
        {
            // seçilen personelin ID'sini alalım 
            int seciliPersonelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmPersoneleGorePrimler frm = new frmPersoneleGorePrimler();
            // frmPersoneleGorePrim formunda ilgili kişinin prim bilgilerini gösterme 
            frm.txtPersonelID.Text = seciliPersonelID.ToString();
            frm.txtPersonelAdSoyad.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString()+" "+dataGridView1.CurrentRow.Cells[2].Value.ToString();

            Veritabani.ListeleAra(frm.dataGridViewPGP, "select * from Primler where PersonalID= " + seciliPersonelID);
            frm.ShowDialog();
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            frmPrimleriGoster goster = new frmPrimleriGoster();
            goster.Show();
        }

        private void frmPrimler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                btnPrimleriGoster.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                btnPersonelPrimleri.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Cikis.PerformClick();
            }
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
