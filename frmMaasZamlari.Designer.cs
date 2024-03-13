namespace PersonelTakipOtomasyonu
{
    partial class frmMaasZamlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaasZamlari));
            this.radioYuzde = new System.Windows.Forms.RadioButton();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOnay = new System.Windows.Forms.Button();
            this.labelMevcutMaasi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioYuzde
            // 
            this.radioYuzde.AutoSize = true;
            this.radioYuzde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioYuzde.Location = new System.Drawing.Point(164, 65);
            this.radioYuzde.Name = "radioYuzde";
            this.radioYuzde.Size = new System.Drawing.Size(181, 31);
            this.radioYuzde.TabIndex = 0;
            this.radioYuzde.TabStop = true;
            this.radioYuzde.Text = "YÜZDEYE GÖRE";
            this.radioYuzde.UseVisualStyleBackColor = true;
            this.radioYuzde.CheckedChanged += new System.EventHandler(this.radioYuzde_CheckedChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioFiyat.Location = new System.Drawing.Point(371, 65);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(160, 31);
            this.radioFiyat.TabIndex = 1;
            this.radioFiyat.TabStop = true;
            this.radioFiyat.Text = "FİYATA GÖRE";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "AY :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "AÇIKLAMA :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "FİYAT (TL) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "YÜZDE (%) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "PERSONELLER :";
            // 
            // comboAy
            // 
            this.comboAy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.comboAy.Location = new System.Drawing.Point(184, 117);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(125, 35);
            this.comboAy.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(355, 117);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(142, 35);
            this.comboYil.TabIndex = 9;
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller."});
            this.comboPersoneller.Location = new System.Drawing.Point(184, 174);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(271, 35);
            this.comboPersoneller.TabIndex = 10;
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(473, 177);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(24, 27);
            this.lblPersonelID.TabIndex = 11;
            this.lblPersonelID.Text = "0";
            // 
            // txtYuzde
            // 
            this.txtYuzde.Location = new System.Drawing.Point(184, 271);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(313, 34);
            this.txtYuzde.TabIndex = 12;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(184, 328);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(313, 34);
            this.txtFiyat.TabIndex = 13;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(184, 385);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(313, 63);
            this.txtAciklama.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(182, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Zam Sayfası Çıkış Sayfası.png");
            this.ımageList1.Images.SetKeyName(1, "Zam Sayfası Onay Sayfası.png");
            // 
            // btnOnay
            // 
            this.btnOnay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOnay.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOnay.FlatAppearance.BorderSize = 0;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.ImageIndex = 1;
            this.btnOnay.ImageList = this.ımageList1;
            this.btnOnay.Location = new System.Drawing.Point(371, 486);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(126, 63);
            this.btnOnay.TabIndex = 16;
            this.btnOnay.Text = "ONAYLA";
            this.btnOnay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // labelMevcutMaasi
            // 
            this.labelMevcutMaasi.AutoSize = true;
            this.labelMevcutMaasi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelMevcutMaasi.Location = new System.Drawing.Point(177, 228);
            this.labelMevcutMaasi.Name = "labelMevcutMaasi";
            this.labelMevcutMaasi.Size = new System.Drawing.Size(223, 27);
            this.labelMevcutMaasi.TabIndex = 17;
            this.labelMevcutMaasi.Text = "MEVCUT MAAŞI : 0 TL";
            // 
            // frmMaasZamlari
            // 
            this.AcceptButton = this.btnOnay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(560, 575);
            this.Controls.Add(this.labelMevcutMaasi);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYuzde);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaasZamlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL MAAŞ ZAMLARI SAYFASI";
            this.Load += new System.EventHandler(this.frmMaasZamlari_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMaasZamlari_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioYuzde;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label labelMevcutMaasi;
    }
}