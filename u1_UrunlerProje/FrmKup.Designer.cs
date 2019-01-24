namespace u1_UrunlerProje
{
    partial class FrmKup
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
            this.listBoxKup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelListelensin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxKenar = new System.Windows.Forms.TextBox();
            this.textBoxBFiyat = new System.Windows.Forms.TextBox();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxAgirlik = new System.Windows.Forms.TextBox();
            this.textBoxHacim = new System.Windows.Forms.TextBox();
            this.textBoxFire = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.btnKupSil = new System.Windows.Forms.Button();
            this.btnKupListele = new System.Windows.Forms.Button();
            this.btnKupGuncelle = new System.Windows.Forms.Button();
            this.btnKupEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKup
            // 
            this.listBoxKup.FormattingEnabled = true;
            this.listBoxKup.ItemHeight = 16;
            this.listBoxKup.Location = new System.Drawing.Point(42, 32);
            this.listBoxKup.Name = "listBoxKup";
            this.listBoxKup.Size = new System.Drawing.Size(183, 244);
            this.listBoxKup.TabIndex = 0;
            this.listBoxKup.SelectedIndexChanged += new System.EventHandler(this.listBoxKup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ağırlık : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kenar : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birim Fiyat : ";
            // 
            // labelListelensin
            // 
            this.labelListelensin.AutoSize = true;
            this.labelListelensin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelListelensin.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelListelensin.Location = new System.Drawing.Point(411, 9);
            this.labelListelensin.Name = "labelListelensin";
            this.labelListelensin.Size = new System.Drawing.Size(30, 26);
            this.labelListelensin.TabIndex = 1;
            this.labelListelensin.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Fiyat : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fire :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(392, 45);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(155, 22);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxKenar
            // 
            this.textBoxKenar.Location = new System.Drawing.Point(392, 192);
            this.textBoxKenar.Name = "textBoxKenar";
            this.textBoxKenar.Size = new System.Drawing.Size(155, 22);
            this.textBoxKenar.TabIndex = 2;
            // 
            // textBoxBFiyat
            // 
            this.textBoxBFiyat.Location = new System.Drawing.Point(392, 240);
            this.textBoxBFiyat.Name = "textBoxBFiyat";
            this.textBoxBFiyat.Size = new System.Drawing.Size(155, 22);
            this.textBoxBFiyat.TabIndex = 2;
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(392, 88);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(155, 22);
            this.textBoxAD.TabIndex = 2;
            // 
            // textBoxAgirlik
            // 
            this.textBoxAgirlik.Location = new System.Drawing.Point(392, 136);
            this.textBoxAgirlik.Name = "textBoxAgirlik";
            this.textBoxAgirlik.Size = new System.Drawing.Size(155, 22);
            this.textBoxAgirlik.TabIndex = 2;
            // 
            // textBoxHacim
            // 
            this.textBoxHacim.Enabled = false;
            this.textBoxHacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxHacim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxHacim.Location = new System.Drawing.Point(714, 24);
            this.textBoxHacim.Name = "textBoxHacim";
            this.textBoxHacim.Size = new System.Drawing.Size(148, 26);
            this.textBoxHacim.TabIndex = 22;
            // 
            // textBoxFire
            // 
            this.textBoxFire.Enabled = false;
            this.textBoxFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFire.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxFire.Location = new System.Drawing.Point(714, 128);
            this.textBoxFire.Name = "textBoxFire";
            this.textBoxFire.Size = new System.Drawing.Size(148, 26);
            this.textBoxFire.TabIndex = 21;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Enabled = false;
            this.textBoxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFiyat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxFiyat.Location = new System.Drawing.Point(714, 76);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(148, 26);
            this.textBoxFiyat.TabIndex = 20;
            // 
            // btnKupSil
            // 
            this.btnKupSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKupSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKupSil.Location = new System.Drawing.Point(680, 334);
            this.btnKupSil.Name = "btnKupSil";
            this.btnKupSil.Size = new System.Drawing.Size(137, 32);
            this.btnKupSil.TabIndex = 28;
            this.btnKupSil.Text = "SİL";
            this.btnKupSil.UseVisualStyleBackColor = true;
            this.btnKupSil.Click += new System.EventHandler(this.btnKupSil_Click);
            // 
            // btnKupListele
            // 
            this.btnKupListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKupListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKupListele.Location = new System.Drawing.Point(488, 334);
            this.btnKupListele.Name = "btnKupListele";
            this.btnKupListele.Size = new System.Drawing.Size(137, 32);
            this.btnKupListele.TabIndex = 27;
            this.btnKupListele.Text = "LİSTELE";
            this.btnKupListele.UseVisualStyleBackColor = true;
            this.btnKupListele.Click += new System.EventHandler(this.btnKupListele_Click);
            // 
            // btnKupGuncelle
            // 
            this.btnKupGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKupGuncelle.ForeColor = System.Drawing.Color.Blue;
            this.btnKupGuncelle.Location = new System.Drawing.Point(287, 334);
            this.btnKupGuncelle.Name = "btnKupGuncelle";
            this.btnKupGuncelle.Size = new System.Drawing.Size(137, 32);
            this.btnKupGuncelle.TabIndex = 26;
            this.btnKupGuncelle.Text = "GÜNCELLE";
            this.btnKupGuncelle.UseVisualStyleBackColor = true;
            this.btnKupGuncelle.Click += new System.EventHandler(this.btnKupGuncelle_Click);
            // 
            // btnKupEkle
            // 
            this.btnKupEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKupEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKupEkle.Location = new System.Drawing.Point(95, 334);
            this.btnKupEkle.Name = "btnKupEkle";
            this.btnKupEkle.Size = new System.Drawing.Size(137, 32);
            this.btnKupEkle.TabIndex = 25;
            this.btnKupEkle.Text = "EKLE";
            this.btnKupEkle.UseVisualStyleBackColor = true;
            this.btnKupEkle.Click += new System.EventHandler(this.btnKupEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::u1_UrunlerProje.Properties.Resources.kup2;
            this.pictureBox1.Location = new System.Drawing.Point(697, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 129);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hacim :";
            // 
            // FrmKup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1005, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKupSil);
            this.Controls.Add(this.btnKupListele);
            this.Controls.Add(this.btnKupGuncelle);
            this.Controls.Add(this.btnKupEkle);
            this.Controls.Add(this.textBoxHacim);
            this.Controls.Add(this.textBoxFire);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxAgirlik);
            this.Controls.Add(this.textBoxBFiyat);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.textBoxKenar);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelListelensin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxKup);
            this.Name = "FrmKup";
            this.Text = "FrmKup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelListelensin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxKenar;
        private System.Windows.Forms.TextBox textBoxBFiyat;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.TextBox textBoxAgirlik;
        private System.Windows.Forms.TextBox textBoxHacim;
        private System.Windows.Forms.TextBox textBoxFire;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.Button btnKupSil;
        private System.Windows.Forms.Button btnKupListele;
        private System.Windows.Forms.Button btnKupGuncelle;
        private System.Windows.Forms.Button btnKupEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}