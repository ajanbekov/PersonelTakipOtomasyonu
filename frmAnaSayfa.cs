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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDepartmanlar_Click(object sender, EventArgs e)
        {
            frmDepartmanlar departmanlar = new frmDepartmanlar();
            departmanlar.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle personelEkle = new frmPersonelEkle();
            personelEkle.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele personelListele = new frmPersonelListele();
            personelListele.ShowDialog();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmKullanicilar kullanicilar = new frmKullanicilar();
            kullanicilar.ShowDialog();
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmMaasZamlari zam = new frmMaasZamlari();
            zam.Show();
        }

        private void btnPrimler_Click(object sender, EventArgs e)
        {
            frmPrimler primler = new frmPrimler();
            primler.Show();
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            frmMesaiEkle mesaiEkle = new frmMesaiEkle();
            mesaiEkle.Show();
        }

        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer mesailer = new frmMesailer();
            mesailer.Show();
        }

        private void frmAnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                btnPersonelListele.PerformClick();
            }

            if (e.Shift && e.KeyCode == Keys.E)
            {
                btnMesaiEkle.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                btnPersonelEkle.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                btnPrimler.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                btnDepartmanlar.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.Z)
            {
                btnMaasZamlari.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.M)
            {
                btnMesailer.PerformClick();
            }
        }
    }
}
