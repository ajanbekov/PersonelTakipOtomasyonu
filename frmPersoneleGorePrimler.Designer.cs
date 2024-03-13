namespace PersonelTakipOtomasyonu
{
    partial class frmPersoneleGorePrimler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPGP = new System.Windows.Forms.DataGridView();
            this.ÇIKIŞ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPGP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtPersonelID.Location = new System.Drawing.Point(195, 42);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(105, 34);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(710, 42);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(285, 34);
            this.txtPersonelAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "PERSONEL ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(441, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "PERSONEL AD SOYAD :";
            // 
            // dataGridViewPGP
            // 
            this.dataGridViewPGP.AllowUserToDeleteRows = false;
            this.dataGridViewPGP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPGP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPGP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPGP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPGP.ColumnHeadersHeight = 29;
            this.dataGridViewPGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPGP.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewPGP.Name = "dataGridViewPGP";
            this.dataGridViewPGP.RowHeadersWidth = 51;
            this.dataGridViewPGP.RowTemplate.Height = 24;
            this.dataGridViewPGP.Size = new System.Drawing.Size(984, 325);
            this.dataGridViewPGP.TabIndex = 4;
            // 
            // ÇIKIŞ
            // 
            this.ÇIKIŞ.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ÇIKIŞ.FlatAppearance.BorderSize = 0;
            this.ÇIKIŞ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ÇIKIŞ.Location = new System.Drawing.Point(3, 1);
            this.ÇIKIŞ.Name = "ÇIKIŞ";
            this.ÇIKIŞ.Size = new System.Drawing.Size(24, 23);
            this.ÇIKIŞ.TabIndex = 5;
            this.ÇIKIŞ.UseVisualStyleBackColor = true;
            // 
            // frmPersoneleGorePrimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton = this.ÇIKIŞ;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.ÇIKIŞ);
            this.Controls.Add(this.dataGridViewPGP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "frmPersoneleGorePrimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONELE GÖRE PRİMLER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPGP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ÇIKIŞ;
        public System.Windows.Forms.TextBox txtPersonelID;
        public System.Windows.Forms.TextBox txtPersonelAdSoyad;
        public System.Windows.Forms.DataGridView dataGridViewPGP;
    }
}