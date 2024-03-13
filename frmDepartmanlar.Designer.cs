namespace PersonelTakipOtomasyonu
{
    partial class frmDepartmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanlar));
            this.txtDepartmanID = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DepartmanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtDepartmanID
            // 
            this.txtDepartmanID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDepartmanID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtDepartmanID.Location = new System.Drawing.Point(301, 45);
            this.txtDepartmanID.Name = "txtDepartmanID";
            this.txtDepartmanID.Size = new System.Drawing.Size(304, 36);
            this.txtDepartmanID.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtAciklama.Location = new System.Drawing.Point(301, 166);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(304, 112);
            this.txtAciklama.TabIndex = 1;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDepartman.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtDepartman.Location = new System.Drawing.Point(301, 105);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(304, 36);
            this.txtDepartman.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEPARTMAN ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(126, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "AÇIKLAMA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(103, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "DEPARTMAN:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(674, 45);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 65);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Müşteri Listeleme Sayfası Sil Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Ürün Ekleme Sayfası Ekle Butonu 2.png");
            this.ımageList1.Images.SetKeyName(2, "Ürün Listeleme Sayfası Marka Güncelle Butonu.png");
            this.ımageList1.Images.SetKeyName(3, "Müşteri Ekleme Sayfası Çıkış Butonu.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 2;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 2;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(674, 213);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(224, 65);
            this.btnGuncelle.TabIndex = 6;
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
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(674, 129);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 65);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSil, "DELETE");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnCikis.ImageIndex = 3;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(1081, 579);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(167, 65);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepartmanID,
            this.Departman,
            this.Aciklama});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(64, 309);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1184, 237);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // DepartmanID
            // 
            this.DepartmanID.Text = "DEPARTMAN ID";
            this.DepartmanID.Width = 175;
            // 
            // Departman
            // 
            this.Departman.Text = "DEPARTMAN";
            this.Departman.Width = 160;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "AÇIKLAMA";
            this.Aciklama.Width = 550;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "KISAYOL";
            // 
            // frmDepartmanlar
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(1311, 665);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtDepartmanID);
            this.KeyPreview = true;
            this.Name = "frmDepartmanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPARTMANLAR SAYFASI";
            this.Load += new System.EventHandler(this.frmDepartmanlar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDepartmanlar_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmanID;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DepartmanID;
        private System.Windows.Forms.ColumnHeader Departman;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}