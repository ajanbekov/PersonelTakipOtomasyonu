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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtDepartman.Text == "" && txtAciklama.Text == "") // eğer TextBox'lar boşsa departman ekleme işlemi yapmasın 
            {
                MessageBox.Show("LÜTFEN DEPARTMAN BİLGİLERİNİ GİRİNİZ.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Departmanlar d = new Departmanlar();
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "insert into Departmanlar values('" + d.Departman + "','" + d.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                MessageBox.Show("DEPARTMAN EKLENDİ.", "BAŞARILI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Departmanlar.DepartmanGetir(listView1);
                txtDepartman.Text = "";
                txtAciklama.Text = "";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // sutün seçmeden güncelleme işlemini engellemek için kod parçası
            if (string.IsNullOrEmpty(txtDepartmanID.Text) || !int.TryParse(txtDepartmanID.Text, out int departmanID))
            {
                MessageBox.Show("LÜTFEN GÜNCELLEME YAPACAĞINIZ DEPARTMANI SEÇİNİZ.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "update departmanlar set departman = '" +d.Departman+ "', aciklama = '" +d.Aciklama+ "' where departmanID " +
                "= '" +d.DepartmanID+ "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sorgu);
            MessageBox.Show("LÜTFEN ÖNCE BİR PERSONEL SEÇİNİZ.", "BAŞARILI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Departmanlar.DepartmanGetir(listView1);
            txtDepartmanID.Text = "";
            txtDepartman.Text = "";
            txtAciklama.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silme işlemini seçilen kayıda göre yapmak için
            if (listView1.SelectedItems.Count > 0) // eğer bir şey seçildiyse yani seçilen kayıt 0'dan büyükse
            {
                DialogResult sonuc = MessageBox.Show("SEÇİLEN DEPARTMANI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "DEPARTMAN SİLME ONAYI.", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Silmeden önce silme işlemini onaylama komutu

                if (sonuc == DialogResult.Yes)
                {
                    Departmanlar d = new Departmanlar();
                    d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // Her sutün altında bulunan ekstra bilgilere SubItem denir 
                    d.Departman = txtDepartman.Text;
                    d.Aciklama = txtAciklama.Text;
                    string sorgu = "delete from departmanlar where departmanID = '" + d.DepartmanID + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sorgu);
                    MessageBox.Show("DEPARTMAN SİLİNDİ.", "BİLGİ.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Departmanlar.DepartmanGetir(listView1);
                }
            }
            else
            {
                MessageBox.Show("ÖNCE KAYIT SEÇİLMELİDİR!!!", "UYARI.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void frmDepartmanlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // btnSil butonuna Del kısayolunu atadık
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
