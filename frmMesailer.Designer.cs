namespace PersonelTakipOtomasyonu
{
    partial class frmMesailer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesailer));
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.mskdBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.mskdBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtSaatUcreti = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMesaiOde = new System.Windows.Forms.Button();
            this.btnTumMesaileriOde = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtMesaiID.Location = new System.Drawing.Point(253, 360);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(251, 36);
            this.txtMesaiID.TabIndex = 0;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPersonelID.Location = new System.Drawing.Point(253, 414);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(251, 36);
            this.txtPersonelID.TabIndex = 1;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAdiSoyadi.Location = new System.Drawing.Point(253, 469);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(251, 36);
            this.txtAdiSoyadi.TabIndex = 2;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(253, 525);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(168, 36);
            this.dateBaslangic.TabIndex = 3;
            // 
            // mskdBaslangic
            // 
            this.mskdBaslangic.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.mskdBaslangic.Location = new System.Drawing.Point(451, 525);
            this.mskdBaslangic.Mask = "00:00";
            this.mskdBaslangic.Name = "mskdBaslangic";
            this.mskdBaslangic.Size = new System.Drawing.Size(67, 36);
            this.mskdBaslangic.TabIndex = 4;
            this.mskdBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(253, 581);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(168, 36);
            this.dateBitis.TabIndex = 5;
            // 
            // mskdBitis
            // 
            this.mskdBitis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.mskdBitis.Location = new System.Drawing.Point(451, 581);
            this.mskdBitis.Mask = "00:00";
            this.mskdBitis.Name = "mskdBitis";
            this.mskdBitis.Size = new System.Drawing.Size(67, 36);
            this.mskdBitis.TabIndex = 6;
            this.mskdBitis.ValidatingType = typeof(System.DateTime);
            // 
            // txtSaatUcreti
            // 
            this.txtSaatUcreti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSaatUcreti.Location = new System.Drawing.Point(773, 360);
            this.txtSaatUcreti.Name = "txtSaatUcreti";
            this.txtSaatUcreti.Size = new System.Drawing.Size(251, 36);
            this.txtSaatUcreti.TabIndex = 7;
            this.txtSaatUcreti.TextChanged += new System.EventHandler(this.txtSaatUcreti_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtTutar.Location = new System.Drawing.Point(773, 414);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(251, 36);
            this.txtTutar.TabIndex = 8;
            // 
            // comboAy
            // 
            this.comboAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboAy.Location = new System.Drawing.Point(773, 469);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(84, 36);
            this.comboAy.TabIndex = 9;
            // 
            // comboYil
            // 
            this.comboYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(903, 469);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(121, 36);
            this.comboYil.TabIndex = 10;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAciklama.Location = new System.Drawing.Point(773, 525);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(251, 92);
            this.txtAciklama.TabIndex = 11;
            // 
            // btnMesaiOde
            // 
            this.btnMesaiOde.FlatAppearance.BorderSize = 0;
            this.btnMesaiOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiOde.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnMesaiOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesaiOde.ImageIndex = 2;
            this.btnMesaiOde.ImageList = this.ımageList1;
            this.btnMesaiOde.Location = new System.Drawing.Point(1057, 380);
            this.btnMesaiOde.Name = "btnMesaiOde";
            this.btnMesaiOde.Size = new System.Drawing.Size(155, 91);
            this.btnMesaiOde.TabIndex = 13;
            this.btnMesaiOde.Text = "MESAİ\r\nÖDE  ";
            this.btnMesaiOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMesaiOde, "ENTER");
            this.btnMesaiOde.UseVisualStyleBackColor = true;
            this.btnMesaiOde.Click += new System.EventHandler(this.btnMesaiOde_Click);
            // 
            // btnTumMesaileriOde
            // 
            this.btnTumMesaileriOde.FlatAppearance.BorderSize = 0;
            this.btnTumMesaileriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumMesaileriOde.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnTumMesaileriOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumMesaileriOde.ImageIndex = 4;
            this.btnTumMesaileriOde.ImageList = this.ımageList1;
            this.btnTumMesaileriOde.Location = new System.Drawing.Point(1230, 384);
            this.btnTumMesaileriOde.Name = "btnTumMesaileriOde";
            this.btnTumMesaileriOde.Size = new System.Drawing.Size(262, 91);
            this.btnTumMesaileriOde.TabIndex = 14;
            this.btnTumMesaileriOde.Text = "TÜM            \r\nMESAİLERİ ÖDE";
            this.btnTumMesaileriOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnTumMesaileriOde, "CTRL + O");
            this.btnTumMesaileriOde.UseVisualStyleBackColor = true;
            this.btnTumMesaileriOde.Click += new System.EventHandler(this.btnTumMesaileriOde_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 1;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(1057, 500);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(206, 91);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGuncelle, "CTRL + G");
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList2;
            this.btnSil.Location = new System.Drawing.Point(1303, 496);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 91);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSil, "DELETE");
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(118, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "MESAİ ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "PERSONEL ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(93, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "ADI SOYADI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "BAŞLANGIÇ SAATİ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(89, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "BİTİŞ SAATİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(591, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "SAAT ÜCRETİ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(665, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "TUTAR :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(655, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "DÖNEM :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(619, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "AÇIKLAMA :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(870, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "/";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1464, 314);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(1416, 712);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(60, 28);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "KISAYOL";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Prim Öde Sayfası Dönem Değiştir Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Prim Öde Sayfası Prim Güncelle Butonu.png");
            this.ımageList1.Images.SetKeyName(2, "Prim Öde Sayfası Prim Öde Butonu.png");
            this.ımageList1.Images.SetKeyName(3, "Prim Öde Sayfası Sil Butonu.png");
            this.ımageList1.Images.SetKeyName(4, "Prim Öde Sayfası Tüm Primleri Öde Butonu.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Müşteri Listeleme Sayfası Sil Butonu.png");
            this.ımageList2.Images.SetKeyName(1, "Ürün Ekleme Sayfası Ekle Butonu 2.png");
            this.ımageList2.Images.SetKeyName(2, "Ürün Listeleme Sayfası Marka Güncelle Butonu.png");
            this.ımageList2.Images.SetKeyName(3, "Müşteri Ekleme Sayfası Çıkış Butonu.png");
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1488, 681);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTumMesaileriOde);
            this.Controls.Add(this.btnMesaiOde);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtSaatUcreti);
            this.Controls.Add(this.mskdBitis);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.mskdBaslangic);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtMesaiID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MESAİLER SAYFASI";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMesailer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.MaskedTextBox mskdBaslangic;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.MaskedTextBox mskdBitis;
        private System.Windows.Forms.TextBox txtSaatUcreti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnMesaiOde;
        private System.Windows.Forms.Button btnTumMesaileriOde;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}