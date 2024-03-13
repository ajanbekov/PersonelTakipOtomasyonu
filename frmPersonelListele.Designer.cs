namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dateTimePickerGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtTelefonu = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "PERSONEL ID ARA :";
            // 
            // txtIDAra
            // 
            this.txtIDAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIDAra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtIDAra.Location = new System.Drawing.Point(278, 81);
            this.txtIDAra.Name = "txtIDAra";
            this.txtIDAra.Size = new System.Drawing.Size(184, 36);
            this.txtIDAra.TabIndex = 6;
            this.txtIDAra.TextChanged += new System.EventHandler(this.txtIDAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(516, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "PERSONEL ADI ARA :";
            // 
            // txtAdAra
            // 
            this.txtAdAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAdAra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAdAra.Location = new System.Drawing.Point(773, 84);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(184, 36);
            this.txtAdAra.TabIndex = 9;
            this.txtAdAra.TextChanged += new System.EventHandler(this.txtAdAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1022, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "PERSONEL SOYADI ARA :";
            // 
            // txtSoyadAra
            // 
            this.txtSoyadAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoyadAra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSoyadAra.Location = new System.Drawing.Point(1323, 87);
            this.txtSoyadAra.Name = "txtSoyadAra";
            this.txtSoyadAra.Size = new System.Drawing.Size(184, 36);
            this.txtSoyadAra.TabIndex = 11;
            this.txtSoyadAra.TextChanged += new System.EventHandler(this.txtSoyadAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(154, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1435, 408);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1542, 812);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "AÇIKLAMA :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(1519, 741);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "GİRİŞ TARİHİ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1151, 870);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "MAAŞI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1076, 803);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "DEPARTMANI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1141, 741);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-MAİL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(575, 796);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "ADRESİ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(547, 742);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "TELEFONU :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(36, 877);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "PERSONEL SOYADI :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(79, 809);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "PERSONEL ADI :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAciklama.Location = new System.Drawing.Point(1705, 809);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(305, 103);
            this.txtAciklama.TabIndex = 21;
            // 
            // dateTimePickerGirisTarihi
            // 
            this.dateTimePickerGirisTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerGirisTarihi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGirisTarihi.Location = new System.Drawing.Point(1705, 741);
            this.dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            this.dateTimePickerGirisTarihi.Size = new System.Drawing.Size(305, 36);
            this.dateTimePickerGirisTarihi.TabIndex = 20;
            // 
            // txtMaas
            // 
            this.txtMaas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaas.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtMaas.Location = new System.Drawing.Point(1270, 870);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(200, 36);
            this.txtMaas.TabIndex = 19;
            // 
            // comboDepartman
            // 
            this.comboDepartman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDepartman.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(1270, 802);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(200, 36);
            this.comboDepartman.TabIndex = 18;
            // 
            // txtAdi
            // 
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAdi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAdi.Location = new System.Drawing.Point(290, 806);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 36);
            this.txtAdi.TabIndex = 16;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoyadi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtSoyadi.Location = new System.Drawing.Point(290, 873);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 36);
            this.txtSoyadi.TabIndex = 15;
            // 
            // txtTelefonu
            // 
            this.txtTelefonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTelefonu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtTelefonu.Location = new System.Drawing.Point(709, 739);
            this.txtTelefonu.Name = "txtTelefonu";
            this.txtTelefonu.Size = new System.Drawing.Size(305, 36);
            this.txtTelefonu.TabIndex = 14;
            // 
            // txtAdres
            // 
            this.txtAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAdres.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAdres.Location = new System.Drawing.Point(709, 790);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(305, 119);
            this.txtAdres.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(1270, 738);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 36);
            this.txtEmail.TabIndex = 13;
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblToplamMaas.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToplamMaas.Location = new System.Drawing.Point(1147, 640);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(536, 29);
            this.lblToplamMaas.TabIndex = 31;
            this.lblToplamMaas.Text = "LİSTEDE TOPLAM 500,00 TL MAAŞ HESAPLANDI.";
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblToplamKayit.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToplamKayit.Location = new System.Drawing.Point(156, 640);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(346, 29);
            this.lblToplamKayit.TabIndex = 32;
            this.lblToplamKayit.Text = "TOPLAM 85 KAYIT LİSTELENDİ.";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Silver;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatAppearance.BorderSize = 2;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(1677, 398);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(174, 65);
            this.btnCikis.TabIndex = 33;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Personel Listeleme Çıkış Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Personel Listeleme Güncelle Butonu.png");
            this.ımageList1.Images.SetKeyName(2, "Personel Listeleme Sil Butonu.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 1;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(1677, 198);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(220, 65);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGuncelle, "CTRL + G");
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 2;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 2;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(1677, 300);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 65);
            this.btnSil.TabIndex = 35;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSil, "DELETE");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(95, 742);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 29);
            this.label13.TabIndex = 37;
            this.label13.Text = "PERSONEL ID :";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPersonelID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPersonelID.Location = new System.Drawing.Point(290, 739);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(200, 36);
            this.txtPersonelID.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1573, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 29);
            this.label14.TabIndex = 38;
            this.label14.Text = "TARİHE GÖRE ARA :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1816, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 36);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "KISAYOL";
            // 
            // frmPersonelListele
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(1850, 844);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblToplamKayit);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dateTimePickerGirisTarihi);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.comboDepartman);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtTelefonu);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSoyadAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDAra);
            this.KeyPreview = true;
            this.Name = "frmPersonelListele";
            this.Text = "frmPersonelListele";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPersonelListele_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyadAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisTarihi;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtTelefonu;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}