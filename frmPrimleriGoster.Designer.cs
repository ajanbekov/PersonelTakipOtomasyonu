namespace PersonelTakipOtomasyonu
{
    partial class frmPrimleriGoster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimleriGoster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(180, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "PRİM ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(692, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "AY / YIL :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(658, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "AÇIKLAMA :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(634, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRİM TUTARI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "PERSONEL AD SOYAD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(915, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "/";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtPrimID.Location = new System.Drawing.Point(300, 443);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(255, 34);
            this.txtPrimID.TabIndex = 21;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtPersonelID.Location = new System.Drawing.Point(300, 490);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(255, 34);
            this.txtPersonelID.TabIndex = 22;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(300, 537);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(255, 34);
            this.txtPersonelAdSoyad.TabIndex = 23;
            // 
            // comboAy
            // 
            this.comboAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
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
            this.comboAy.Location = new System.Drawing.Point(808, 443);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(97, 35);
            this.comboAy.TabIndex = 24;
            // 
            // comboYil
            // 
            this.comboYil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(942, 442);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(121, 35);
            this.comboYil.TabIndex = 25;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtPrimTutari.Location = new System.Drawing.Point(808, 490);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(255, 34);
            this.txtPrimTutari.TabIndex = 26;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtAciklama.Location = new System.Drawing.Point(808, 537);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(255, 68);
            this.txtAciklama.TabIndex = 27;
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.BackColor = System.Drawing.Color.Silver;
            this.btnTumPrimleriOde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTumPrimleriOde.FlatAppearance.BorderSize = 2;
            this.btnTumPrimleriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumPrimleriOde.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnTumPrimleriOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumPrimleriOde.ImageIndex = 4;
            this.btnTumPrimleriOde.ImageList = this.ımageList1;
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(19, 648);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(241, 78);
            this.btnTumPrimleriOde.TabIndex = 28;
            this.btnTumPrimleriOde.Text = "TÜM PRİMLERİ\r\nÖDE          ";
            this.btnTumPrimleriOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnTumPrimleriOde, "CTRL + O");
            this.btnTumPrimleriOde.UseVisualStyleBackColor = false;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
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
            // btnPrimOde
            // 
            this.btnPrimOde.BackColor = System.Drawing.Color.Silver;
            this.btnPrimOde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimOde.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPrimOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimOde.ImageIndex = 2;
            this.btnPrimOde.ImageList = this.ımageList1;
            this.btnPrimOde.Location = new System.Drawing.Point(308, 648);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(141, 78);
            this.btnPrimOde.TabIndex = 29;
            this.btnPrimOde.Text = "PRİM\r\nÖDE ";
            this.btnPrimOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPrimOde, "ENTER");
            this.btnPrimOde.UseVisualStyleBackColor = false;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnPrimGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimGuncelle.FlatAppearance.BorderSize = 2;
            this.btnPrimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPrimGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimGuncelle.ImageIndex = 1;
            this.btnPrimGuncelle.ImageList = this.ımageList1;
            this.btnPrimGuncelle.Location = new System.Drawing.Point(499, 648);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(203, 78);
            this.btnPrimGuncelle.TabIndex = 30;
            this.btnPrimGuncelle.Text = "PRİM     \r\nGÜNCELLE";
            this.btnPrimGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPrimGuncelle, "CTRL + G");
            this.btnPrimGuncelle.UseVisualStyleBackColor = false;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.BackColor = System.Drawing.Color.Silver;
            this.btnPrimSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimSil.FlatAppearance.BorderSize = 2;
            this.btnPrimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimSil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPrimSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimSil.ImageIndex = 3;
            this.btnPrimSil.ImageList = this.ımageList1;
            this.btnPrimSil.Location = new System.Drawing.Point(753, 648);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(137, 78);
            this.btnPrimSil.TabIndex = 31;
            this.btnPrimSil.Text = "PRİM\r\nSİL  ";
            this.btnPrimSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPrimSil, "DELETE");
            this.btnPrimSil.UseVisualStyleBackColor = false;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.BackColor = System.Drawing.Color.Silver;
            this.btnDonemDegistir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDonemDegistir.FlatAppearance.BorderSize = 2;
            this.btnDonemDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonemDegistir.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnDonemDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonemDegistir.ImageIndex = 0;
            this.btnDonemDegistir.ImageList = this.ımageList1;
            this.btnDonemDegistir.Location = new System.Drawing.Point(932, 648);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(185, 78);
            this.btnDonemDegistir.TabIndex = 32;
            this.btnDonemDegistir.Text = "DÖNEM  \r\nDEĞİŞTİR";
            this.btnDonemDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDonemDegistir, "CTRL + D");
            this.btnDonemDegistir.UseVisualStyleBackColor = false;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(114, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "PERSONEL ID :";
            // 
            // Cikis
            // 
            this.Cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cikis.FlatAppearance.BorderSize = 0;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.Location = new System.Drawing.Point(474, 600);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(75, 23);
            this.Cikis.TabIndex = 33;
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
            // frmPrimleriGoster
            // 
            this.AcceptButton = this.btnPrimOde;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.CancelButton = this.Cikis;
            this.ClientSize = new System.Drawing.Size(1129, 784);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.btnTumPrimleriOde);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÜM PERSONELLERİN PRİMLERİ";
            this.Load += new System.EventHandler(this.frmPrimGoster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrimleriGoster_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnTumPrimleriOde;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button Cikis;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}