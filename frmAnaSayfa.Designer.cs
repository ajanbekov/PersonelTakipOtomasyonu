namespace PersonelTakipOtomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnDepartmanlar = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnMaasZamlari = new System.Windows.Forms.Button();
            this.btnPrimler = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.Color.Silver;
            this.btnPersonelListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelListele.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPersonelListele.FlatAppearance.BorderSize = 2;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelListele.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPersonelListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelListele.ImageIndex = 3;
            this.btnPersonelListele.Location = new System.Drawing.Point(43, 81);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(304, 65);
            this.btnPersonelListele.TabIndex = 36;
            this.btnPersonelListele.Text = "PERSONEL LİSTELE";
            this.btnPersonelListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPersonelListele, "CTRL + L");
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnDepartmanlar
            // 
            this.btnDepartmanlar.BackColor = System.Drawing.Color.Silver;
            this.btnDepartmanlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartmanlar.FlatAppearance.BorderSize = 2;
            this.btnDepartmanlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanlar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnDepartmanlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmanlar.ImageIndex = 2;
            this.btnDepartmanlar.Location = new System.Drawing.Point(390, 81);
            this.btnDepartmanlar.Name = "btnDepartmanlar";
            this.btnDepartmanlar.Size = new System.Drawing.Size(304, 65);
            this.btnDepartmanlar.TabIndex = 37;
            this.btnDepartmanlar.Text = "DEPARTMANLAR";
            this.btnDepartmanlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDepartmanlar, "CTRL + D");
            this.btnDepartmanlar.UseVisualStyleBackColor = false;
            this.btnDepartmanlar.Click += new System.EventHandler(this.btnDepartmanlar_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.Silver;
            this.btnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelEkle.FlatAppearance.BorderSize = 2;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelEkle.ImageIndex = 0;
            this.btnPersonelEkle.Location = new System.Drawing.Point(43, 188);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(304, 65);
            this.btnPersonelEkle.TabIndex = 38;
            this.btnPersonelEkle.Text = "PERSONEL EKLE";
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPersonelEkle, "CTRL + E");
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnMaasZamlari
            // 
            this.btnMaasZamlari.BackColor = System.Drawing.Color.Silver;
            this.btnMaasZamlari.FlatAppearance.BorderSize = 2;
            this.btnMaasZamlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasZamlari.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnMaasZamlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaasZamlari.Location = new System.Drawing.Point(390, 188);
            this.btnMaasZamlari.Name = "btnMaasZamlari";
            this.btnMaasZamlari.Size = new System.Drawing.Size(304, 65);
            this.btnMaasZamlari.TabIndex = 39;
            this.btnMaasZamlari.Text = "MAAŞ ZAMLARI";
            this.btnMaasZamlari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMaasZamlari, "CTRL + Z");
            this.btnMaasZamlari.UseVisualStyleBackColor = false;
            this.btnMaasZamlari.Click += new System.EventHandler(this.btnMaasZamlari_Click);
            // 
            // btnPrimler
            // 
            this.btnPrimler.BackColor = System.Drawing.Color.Silver;
            this.btnPrimler.FlatAppearance.BorderSize = 2;
            this.btnPrimler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimler.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPrimler.Location = new System.Drawing.Point(43, 295);
            this.btnPrimler.Name = "btnPrimler";
            this.btnPrimler.Size = new System.Drawing.Size(304, 65);
            this.btnPrimler.TabIndex = 40;
            this.btnPrimler.Text = "PRİMLER";
            this.btnPrimler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPrimler, "CTRL + P");
            this.btnPrimler.UseVisualStyleBackColor = false;
            this.btnPrimler.Click += new System.EventHandler(this.btnPrimler_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "KISAYOL";
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.BackColor = System.Drawing.Color.Silver;
            this.btnMesaiEkle.FlatAppearance.BorderSize = 2;
            this.btnMesaiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnMesaiEkle.Location = new System.Drawing.Point(390, 295);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(304, 65);
            this.btnMesaiEkle.TabIndex = 41;
            this.btnMesaiEkle.Text = "MESAİ EKLE";
            this.btnMesaiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMesaiEkle, "SHİFT + E");
            this.btnMesaiEkle.UseVisualStyleBackColor = false;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnMesailer
            // 
            this.btnMesailer.BackColor = System.Drawing.Color.Silver;
            this.btnMesailer.FlatAppearance.BorderSize = 2;
            this.btnMesailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesailer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnMesailer.Location = new System.Drawing.Point(43, 403);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(304, 65);
            this.btnMesailer.TabIndex = 42;
            this.btnMesailer.Text = "MESAİLER";
            this.btnMesailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMesailer, "CTRL + M");
            this.btnMesailer.UseVisualStyleBackColor = false;
            this.btnMesailer.Click += new System.EventHandler(this.btnMesailer_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(733, 536);
            this.Controls.Add(this.btnMesailer);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.btnPrimler);
            this.Controls.Add(this.btnMaasZamlari);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnDepartmanlar);
            this.Controls.Add(this.btnPersonelEkle);
            this.KeyPreview = true;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAnaSayfa_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnDepartmanlar;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnMaasZamlari;
        private System.Windows.Forms.Button btnPrimler;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnMesailer;
    }
}

