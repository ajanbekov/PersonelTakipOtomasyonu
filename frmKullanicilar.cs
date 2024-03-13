using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtKullaniciSifre.Text);

            if (Kullanicilar.durum)
            {
                this.Close();   
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI.", "HATA MESAJI.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum sifremiUnuttum = new frmSifremiUnuttum();
            sifremiUnuttum.ShowDialog();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeniKullanici = new frmYeniKullanici();
            yeniKullanici.ShowDialog();
        }
    }
}
