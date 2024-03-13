namespace PersonelTakipOtomasyonu
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 131);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(169, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(561, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(107, 252);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(384, 36);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciSifre.Location = new System.Drawing.Point(107, 369);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(384, 32);
            this.txtKullaniciSifre.TabIndex = 2;
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(102, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "KULLANICI ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(102, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "ŞİFRE";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(334, 483);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(157, 65);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "GİRİŞ";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Kullanıcı İşlemleri Sayfası Giriş Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Kullanıcı İşlemleri Sayfası Kayıt Ol Butonu.png");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(107, 429);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "BENİ HATIRLA";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(331, 429);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 21);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ŞİFREMİ UNUTTUM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Silver;
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitOl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKayitOl.FlatAppearance.BorderSize = 2;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.ForeColor = System.Drawing.Color.Black;
            this.btnKayitOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayitOl.ImageIndex = 1;
            this.btnKayitOl.ImageList = this.ımageList1;
            this.btnKayitOl.Location = new System.Drawing.Point(107, 483);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(193, 65);
            this.btnKayitOl.TabIndex = 10;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // frmKullanicilar
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(598, 621);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANİCİ İŞLEMLERİ SAYFASI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnKayitOl;
    }
}