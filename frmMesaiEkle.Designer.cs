namespace PersonelTakipOtomasyonu
{
    partial class frmMesaiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaiEkle));
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAdSoyad = new System.Windows.Forms.ComboBox();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.maskedBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtSaatUcreti = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(65, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "AÇIKLAMA :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(65, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "DÖNEM :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(65, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "TUTAR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(65, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "SAAT ÜCRETİ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(65, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "BİTİŞ SAATİ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "BAŞLANGIÇ SAATİ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "PER. ADI SOYADI :";
            // 
            // comboAdSoyad
            // 
            this.comboAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboAdSoyad.FormattingEnabled = true;
            this.comboAdSoyad.Location = new System.Drawing.Point(70, 79);
            this.comboAdSoyad.Name = "comboAdSoyad";
            this.comboAdSoyad.Size = new System.Drawing.Size(322, 36);
            this.comboAdSoyad.TabIndex = 15;
            this.comboAdSoyad.SelectedIndexChanged += new System.EventHandler(this.comboAdSoyad_SelectedIndexChanged);
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(70, 176);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(181, 36);
            this.dateBaslangic.TabIndex = 16;
            // 
            // maskedBaslangic
            // 
            this.maskedBaslangic.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.maskedBaslangic.Location = new System.Drawing.Point(286, 175);
            this.maskedBaslangic.Mask = "90:00";
            this.maskedBaslangic.Name = "maskedBaslangic";
            this.maskedBaslangic.Size = new System.Drawing.Size(100, 36);
            this.maskedBaslangic.TabIndex = 17;
            this.maskedBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(70, 269);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(181, 36);
            this.dateBitis.TabIndex = 18;
            // 
            // maskedBitis
            // 
            this.maskedBitis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.maskedBitis.Location = new System.Drawing.Point(286, 269);
            this.maskedBitis.Mask = "90:00";
            this.maskedBitis.Name = "maskedBitis";
            this.maskedBitis.Size = new System.Drawing.Size(100, 36);
            this.maskedBitis.TabIndex = 19;
            this.maskedBitis.ValidatingType = typeof(System.DateTime);
            // 
            // txtSaatUcreti
            // 
            this.txtSaatUcreti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSaatUcreti.Location = new System.Drawing.Point(70, 358);
            this.txtSaatUcreti.Name = "txtSaatUcreti";
            this.txtSaatUcreti.Size = new System.Drawing.Size(316, 36);
            this.txtSaatUcreti.TabIndex = 20;
            this.txtSaatUcreti.TextChanged += new System.EventHandler(this.txtSaatUcreti_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtTutar.Location = new System.Drawing.Point(70, 448);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(316, 36);
            this.txtTutar.TabIndex = 21;
            // 
            // comboAy
            // 
            this.comboAy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(70, 551);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(121, 36);
            this.comboAy.TabIndex = 22;
            // 
            // comboYil
            // 
            this.comboYil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(265, 551);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(121, 36);
            this.comboYil.TabIndex = 23;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAciklama.Location = new System.Drawing.Point(70, 651);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(316, 84);
            this.txtAciklama.TabIndex = 24;
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(418, -1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(38, 34);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Primler Sayfası Prim Ekle Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Mesai Ekleme Sayfası frmMesailer Butonu 2.png");
            // 
            // btnEkle
            // 
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(265, 769);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(147, 64);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(220, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "/";
            // 
            // btnMesailer
            // 
            this.btnMesailer.FlatAppearance.BorderSize = 0;
            this.btnMesailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesailer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnMesailer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMesailer.ImageIndex = 1;
            this.btnMesailer.ImageList = this.ımageList1;
            this.btnMesailer.Location = new System.Drawing.Point(34, 769);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(200, 64);
            this.btnMesailer.TabIndex = 28;
            this.btnMesailer.Text = "MESAİLER";
            this.btnMesailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesailer.UseVisualStyleBackColor = true;
            this.btnMesailer.Click += new System.EventHandler(this.btnMesailer_Click);
            // 
            // frmMesaiEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(456, 865);
            this.Controls.Add(this.btnMesailer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtSaatUcreti);
            this.Controls.Add(this.maskedBitis);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.maskedBaslangic);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.comboAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MESAİ EKLEME SAYFASI";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMesaiEkle_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAdSoyad;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedBaslangic;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.MaskedTextBox maskedBitis;
        private System.Windows.Forms.TextBox txtSaatUcreti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMesailer;
    }
}