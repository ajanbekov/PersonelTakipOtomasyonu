namespace PersonelTakipOtomasyonu
{
    partial class frmPrimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimler));
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersonellerIcin = new System.Windows.Forms.RadioButton();
            this.txtPersonalID = new System.Windows.Forms.TextBox();
            this.txtPersonalAdSoyad = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPersonelPrimleri = new System.Windows.Forms.Button();
            this.btnPrimleriGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioKisiyeOzel.Location = new System.Drawing.Point(225, 36);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(211, 31);
            this.radioKisiyeOzel.TabIndex = 0;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "KİŞİYE ÖZEL PRİM";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            // 
            // radioTumPersonellerIcin
            // 
            this.radioTumPersonellerIcin.AutoSize = true;
            this.radioTumPersonellerIcin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioTumPersonellerIcin.Location = new System.Drawing.Point(225, 77);
            this.radioTumPersonellerIcin.Name = "radioTumPersonellerIcin";
            this.radioTumPersonellerIcin.Size = new System.Drawing.Size(335, 31);
            this.radioTumPersonellerIcin.TabIndex = 1;
            this.radioTumPersonellerIcin.TabStop = true;
            this.radioTumPersonellerIcin.Text = "TÜM PERSONELLER İÇİN PRİM";
            this.radioTumPersonellerIcin.UseVisualStyleBackColor = true;
            // 
            // txtPersonalID
            // 
            this.txtPersonalID.Location = new System.Drawing.Point(246, 132);
            this.txtPersonalID.Name = "txtPersonalID";
            this.txtPersonalID.Size = new System.Drawing.Size(253, 34);
            this.txtPersonalID.TabIndex = 2;
            // 
            // txtPersonalAdSoyad
            // 
            this.txtPersonalAdSoyad.Location = new System.Drawing.Point(246, 182);
            this.txtPersonalAdSoyad.Name = "txtPersonalAdSoyad";
            this.txtPersonalAdSoyad.Size = new System.Drawing.Size(253, 34);
            this.txtPersonalAdSoyad.TabIndex = 3;
            // 
            // comboAy
            // 
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
            this.comboAy.Location = new System.Drawing.Point(246, 234);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(87, 35);
            this.comboAy.TabIndex = 4;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(378, 234);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(121, 35);
            this.comboYil.TabIndex = 5;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(246, 287);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(253, 34);
            this.txtPrimTutari.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(246, 342);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(253, 34);
            this.txtAciklama.TabIndex = 7;
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.BackColor = System.Drawing.Color.Silver;
            this.btnPrimEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimEkle.ImageIndex = 0;
            this.btnPrimEkle.ImageList = this.ımageList1;
            this.btnPrimEkle.Location = new System.Drawing.Point(49, 415);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(116, 73);
            this.btnPrimEkle.TabIndex = 8;
            this.btnPrimEkle.Text = "PRİM\r\nEKLE";
            this.btnPrimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimEkle.UseVisualStyleBackColor = false;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Primler Sayfası Prim Ekle Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Primler Sayfası Prim Öde Butonu.png");
            this.ımageList1.Images.SetKeyName(2, "Primler Sayfası Primleri Görüntüle Butonu.png");
            // 
            // btnPersonelPrimleri
            // 
            this.btnPersonelPrimleri.BackColor = System.Drawing.Color.Silver;
            this.btnPersonelPrimleri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPersonelPrimleri.FlatAppearance.BorderSize = 2;
            this.btnPersonelPrimleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelPrimleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelPrimleri.ImageIndex = 1;
            this.btnPersonelPrimleri.ImageList = this.ımageList1;
            this.btnPersonelPrimleri.Location = new System.Drawing.Point(364, 415);
            this.btnPersonelPrimleri.Name = "btnPersonelPrimleri";
            this.btnPersonelPrimleri.Size = new System.Drawing.Size(166, 73);
            this.btnPersonelPrimleri.TabIndex = 9;
            this.btnPersonelPrimleri.Text = "PERSONEL\r\nPRİMLERİ  ";
            this.btnPersonelPrimleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPersonelPrimleri, "CTRL + P");
            this.btnPersonelPrimleri.UseVisualStyleBackColor = false;
            this.btnPersonelPrimleri.Click += new System.EventHandler(this.btnPrimleriGoster_Click);
            // 
            // btnPrimleriGoster
            // 
            this.btnPrimleriGoster.BackColor = System.Drawing.Color.Silver;
            this.btnPrimleriGoster.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimleriGoster.FlatAppearance.BorderSize = 2;
            this.btnPrimleriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimleriGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimleriGoster.ImageIndex = 2;
            this.btnPrimleriGoster.ImageList = this.ımageList1;
            this.btnPrimleriGoster.Location = new System.Drawing.Point(191, 415);
            this.btnPrimleriGoster.Name = "btnPrimleriGoster";
            this.btnPrimleriGoster.Size = new System.Drawing.Size(149, 73);
            this.btnPrimleriGoster.TabIndex = 10;
            this.btnPrimleriGoster.Text = "PRİMLERİ\r\nGÖSTER  ";
            this.btnPrimleriGoster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPrimleriGoster, "CTRL + G");
            this.btnPrimleriGoster.UseVisualStyleBackColor = false;
            this.btnPrimleriGoster.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 519);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 213);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "PERSONEL AD SOYAD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "AY / YIL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRİM TUTARI :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "AÇIKLAMA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "PERSONAL ID :";
            // 
            // Cikis
            // 
            this.Cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.ForeColor = System.Drawing.Color.DarkCyan;
            this.Cikis.ImageList = this.ımageList1;
            this.Cikis.Location = new System.Drawing.Point(108, 47);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(48, 33);
            this.Cikis.TabIndex = 15;
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "KISAYOL";
            // 
            // frmPrimler
            // 
            this.AcceptButton = this.btnPrimEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.CancelButton = this.Cikis;
            this.ClientSize = new System.Drawing.Size(579, 744);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrimleriGoster);
            this.Controls.Add(this.btnPersonelPrimleri);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtPersonalAdSoyad);
            this.Controls.Add(this.txtPersonalID);
            this.Controls.Add(this.radioTumPersonellerIcin);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRİMLER SAYFASI";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrimler_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersonellerIcin;
        private System.Windows.Forms.TextBox txtPersonalID;
        private System.Windows.Forms.TextBox txtPersonalAdSoyad;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPersonelPrimleri;
        private System.Windows.Forms.Button btnPrimleriGoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button Cikis;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}