namespace etkinlik_bilgiSistemi_C_
{
    partial class FrmAdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuEtkinlikİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEtkinlikler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEtkinlikEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEtkinlikGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKatilimcilar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKatilimlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGörüsler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIstatistik = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToplamEtkinlik = new System.Windows.Forms.Label();
            this.lblToplamKatilim = new System.Windows.Forms.Label();
            this.lblToplamGorus = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEtkinlikİslemleri,
            this.menuKatilimcilar,
            this.menuRaporlar,
            this.menuCikis});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(600, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuEtkinlikİslemleri
            // 
            this.menuEtkinlikİslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEtkinlikler,
            this.tsmEtkinlikEkle,
            this.tsmEtkinlikGuncelle});
            this.menuEtkinlikİslemleri.Name = "menuEtkinlikİslemleri";
            this.menuEtkinlikİslemleri.Size = new System.Drawing.Size(104, 20);
            this.menuEtkinlikİslemleri.Text = "Etkinlik İşlemleri";
            // 
            // menuEtkinlikler
            // 
            this.menuEtkinlikler.Name = "menuEtkinlikler";
            this.menuEtkinlikler.Size = new System.Drawing.Size(161, 22);
            this.menuEtkinlikler.Text = "Tüm Etkinlikler";
            this.menuEtkinlikler.Click += new System.EventHandler(this.menuEtkinlikler_Click);
            // 
            // tsmEtkinlikEkle
            // 
            this.tsmEtkinlikEkle.Name = "tsmEtkinlikEkle";
            this.tsmEtkinlikEkle.Size = new System.Drawing.Size(161, 22);
            this.tsmEtkinlikEkle.Text = "Etkinlik Ekle";
            this.tsmEtkinlikEkle.Click += new System.EventHandler(this.tsmEtkinlikEkle_Click);
            // 
            // tsmEtkinlikGuncelle
            // 
            this.tsmEtkinlikGuncelle.Name = "tsmEtkinlikGuncelle";
            this.tsmEtkinlikGuncelle.Size = new System.Drawing.Size(161, 22);
            this.tsmEtkinlikGuncelle.Text = "Etkinlik Güncelle";
            this.tsmEtkinlikGuncelle.Click += new System.EventHandler(this.tsmEtkinlikGuncelle_Click);
            // 
            // menuKatilimcilar
            // 
            this.menuKatilimcilar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKatilimlar,
            this.tsmGörüsler});
            this.menuKatilimcilar.Name = "menuKatilimcilar";
            this.menuKatilimcilar.Size = new System.Drawing.Size(78, 20);
            this.menuKatilimcilar.Text = "Katılımcılar";
            // 
            // tsmKatilimlar
            // 
            this.tsmKatilimlar.Name = "tsmKatilimlar";
            this.tsmKatilimlar.Size = new System.Drawing.Size(124, 34);
            this.tsmKatilimlar.Text = "Katılımlar";
            this.tsmKatilimlar.Click += new System.EventHandler(this.tsmKatilimlar_Click);
            // 
            // tsmGörüsler
            // 
            this.tsmGörüsler.Name = "tsmGörüsler";
            this.tsmGörüsler.Size = new System.Drawing.Size(124, 34);
            this.tsmGörüsler.Text = "Görüşler\n";
            this.tsmGörüsler.Click += new System.EventHandler(this.tsmGörüsler_Click);
            // 
            // menuRaporlar
            // 
            this.menuRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIstatistik});
            this.menuRaporlar.Name = "menuRaporlar";
            this.menuRaporlar.Size = new System.Drawing.Size(63, 20);
            this.menuRaporlar.Text = "Raporlar";
            // 
            // tsmIstatistik
            // 
            this.tsmIstatistik.Name = "tsmIstatistik";
            this.tsmIstatistik.Size = new System.Drawing.Size(117, 22);
            this.tsmIstatistik.Text = "İstatistik";
            this.tsmIstatistik.Click += new System.EventHandler(this.tsmIstatistik_Click);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(44, 20);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // lblToplamEtkinlik
            // 
            this.lblToplamEtkinlik.AutoSize = true;
            this.lblToplamEtkinlik.Location = new System.Drawing.Point(99, 53);
            this.lblToplamEtkinlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamEtkinlik.Name = "lblToplamEtkinlik";
            this.lblToplamEtkinlik.Size = new System.Drawing.Size(27, 13);
            this.lblToplamEtkinlik.TabIndex = 3;
            this.lblToplamEtkinlik.Text = "Sayı";
            // 
            // lblToplamKatilim
            // 
            this.lblToplamKatilim.AutoSize = true;
            this.lblToplamKatilim.Location = new System.Drawing.Point(253, 53);
            this.lblToplamKatilim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamKatilim.Name = "lblToplamKatilim";
            this.lblToplamKatilim.Size = new System.Drawing.Size(25, 13);
            this.lblToplamKatilim.TabIndex = 4;
            this.lblToplamKatilim.Text = "sayı";
            // 
            // lblToplamGorus
            // 
            this.lblToplamGorus.AutoSize = true;
            this.lblToplamGorus.Location = new System.Drawing.Point(418, 53);
            this.lblToplamGorus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamGorus.Name = "lblToplamGorus";
            this.lblToplamGorus.Size = new System.Drawing.Size(25, 13);
            this.lblToplamGorus.TabIndex = 4;
            this.lblToplamGorus.Text = "sayı";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(448, 134);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 207);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.setabErenerKonser;
            this.pictureBox2.Location = new System.Drawing.Point(305, 134);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 207);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.konferans;
            this.pictureBox4.Location = new System.Drawing.Point(9, 134);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 207);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.manifestKonser;
            this.pictureBox1.Location = new System.Drawing.Point(156, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 207);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblToplamGorus);
            this.Controls.Add(this.lblToplamKatilim);
            this.Controls.Add(this.lblToplamEtkinlik);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuEtkinlikİslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuKatilimcilar;
        private System.Windows.Forms.ToolStripMenuItem menuRaporlar;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem tsmEtkinlikEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEtkinlikGuncelle;
        private System.Windows.Forms.ToolStripMenuItem tsmGörüsler;
        private System.Windows.Forms.ToolStripMenuItem tsmKatilimlar;
        private System.Windows.Forms.ToolStripMenuItem tsmIstatistik;
        private System.Windows.Forms.ToolStripMenuItem menuEtkinlikler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblToplamEtkinlik;
        private System.Windows.Forms.Label lblToplamKatilim;
        private System.Windows.Forms.Label lblToplamGorus;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}