namespace PersonelTakipOtomasyonu
{
    partial class frmYeniKullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKullanici));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.comboSoru = new System.Windows.Forms.ComboBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Yeni Kullanıcı Ekleme Ekle Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Zam Sayfası Çıkış Sayfası.png");
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Black;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 1;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(214, 481);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(142, 65);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(467, 481);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 65);
            this.btnEkle.TabIndex = 46;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(130, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "SORU :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 75;
            this.label5.Text = "CEVAP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 72;
            this.label2.Text = "ADI SOYADI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "ŞİFRE TEKRAR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 74;
            this.label4.Text = "ŞİFRE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 71;
            this.label3.Text = "KULLANICI ADI :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 70;
            this.label7.Text = "KULLANICI ID :";
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKullaniciID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciID.Location = new System.Drawing.Point(222, 45);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(383, 36);
            this.txtKullaniciID.TabIndex = 77;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(222, 109);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(383, 36);
            this.txtKullaniciAdi.TabIndex = 78;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSifreTekrar.Location = new System.Drawing.Point(222, 231);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(383, 36);
            this.txtSifreTekrar.TabIndex = 80;
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSifre.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Location = new System.Drawing.Point(222, 172);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(383, 36);
            this.txtSifre.TabIndex = 79;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAdiSoyadi.Location = new System.Drawing.Point(222, 290);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(383, 36);
            this.txtAdiSoyadi.TabIndex = 81;
            // 
            // comboSoru
            // 
            this.comboSoru.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboSoru.FormattingEnabled = true;
            this.comboSoru.Items.AddRange(new object[] {
            "1) En sevdiğiniz film nedir?",
            "2) En sevdiğiniz renk nedir?",
            "3) En sevdiğiniz yemek nedir?"});
            this.comboSoru.Location = new System.Drawing.Point(222, 346);
            this.comboSoru.Name = "comboSoru";
            this.comboSoru.Size = new System.Drawing.Size(383, 36);
            this.comboSoru.TabIndex = 82;
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtCevap.Location = new System.Drawing.Point(222, 405);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(383, 36);
            this.txtCevap.TabIndex = 83;
            // 
            // frmYeniKullanici
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(647, 574);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.comboSoru);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikis);
            this.Name = "frmYeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ KULLANICI EKLEME";
            this.Load += new System.EventHandler(this.frmYeniKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.ComboBox comboSoru;
        private System.Windows.Forms.TextBox txtCevap;
    }
}