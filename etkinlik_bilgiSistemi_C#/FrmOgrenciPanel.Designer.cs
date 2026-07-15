namespace etkinlik_bilgiSistemi_C_
{
    partial class FrmOgrenciPanel
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
            this.tsmEtkinliklerOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmEtkinliklerOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmKatildiklarim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmGorusYaz = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikisOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblToplamEtkinlik = new System.Windows.Forms.Label();
            this.lblKatildigim = new System.Windows.Forms.Label();
            this.lblGorus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEtkinliklerOgrenci,
            this.toolStripMenuItem1,
            this.menuCikisOgrenci});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmEtkinliklerOgrenci
            // 
            this.tsmEtkinliklerOgrenci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrmEtkinliklerOgrenci,
            this.FrmKatildiklarim});
            this.tsmEtkinliklerOgrenci.Name = "tsmEtkinliklerOgrenci";
            this.tsmEtkinliklerOgrenci.Size = new System.Drawing.Size(70, 20);
            this.tsmEtkinliklerOgrenci.Text = "Etkinlikler";
            // 
            // FrmEtkinliklerOgrenci
            // 
            this.FrmEtkinliklerOgrenci.Name = "FrmEtkinliklerOgrenci";
            this.FrmEtkinliklerOgrenci.Size = new System.Drawing.Size(152, 22);
            this.FrmEtkinliklerOgrenci.Text = "Tüm Etkinlikler";
            this.FrmEtkinliklerOgrenci.Click += new System.EventHandler(this.FrmEtkinliklerOgrenci_Click);
            // 
            // FrmKatildiklarim
            // 
            this.FrmKatildiklarim.Name = "FrmKatildiklarim";
            this.FrmKatildiklarim.Size = new System.Drawing.Size(152, 22);
            this.FrmKatildiklarim.Text = "Katıldıklarım";
            this.FrmKatildiklarim.Click += new System.EventHandler(this.FrmKatildiklarim_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrmGorusYaz});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Görüşler";
            // 
            // FrmGorusYaz
            // 
            this.FrmGorusYaz.Name = "FrmGorusYaz";
            this.FrmGorusYaz.Size = new System.Drawing.Size(125, 22);
            this.FrmGorusYaz.Text = "Görüş Yaz";
            this.FrmGorusYaz.Click += new System.EventHandler(this.FrmGorusYaz_Click);
            // 
            // menuCikisOgrenci
            // 
            this.menuCikisOgrenci.Name = "menuCikisOgrenci";
            this.menuCikisOgrenci.Size = new System.Drawing.Size(44, 20);
            this.menuCikisOgrenci.Text = "Çıkış";
            this.menuCikisOgrenci.Click += new System.EventHandler(this.menuCikisOgrenci_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.manifestKonser;
            this.pictureBox1.Location = new System.Drawing.Point(9, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.konferans;
            this.pictureBox2.Location = new System.Drawing.Point(164, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 212);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(310, 131);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 212);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::etkinlik_bilgiSistemi_C_.Properties.Resources.setabErenerKonser;
            this.pictureBox4.Location = new System.Drawing.Point(452, 131);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 212);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lblToplamEtkinlik
            // 
            this.lblToplamEtkinlik.AutoSize = true;
            this.lblToplamEtkinlik.Location = new System.Drawing.Point(85, 48);
            this.lblToplamEtkinlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamEtkinlik.Name = "lblToplamEtkinlik";
            this.lblToplamEtkinlik.Size = new System.Drawing.Size(35, 13);
            this.lblToplamEtkinlik.TabIndex = 2;
            this.lblToplamEtkinlik.Text = "label1";
            // 
            // lblKatildigim
            // 
            this.lblKatildigim.AutoSize = true;
            this.lblKatildigim.Location = new System.Drawing.Point(263, 48);
            this.lblKatildigim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKatildigim.Name = "lblKatildigim";
            this.lblKatildigim.Size = new System.Drawing.Size(35, 13);
            this.lblKatildigim.TabIndex = 2;
            this.lblKatildigim.Text = "label1";
            // 
            // lblGorus
            // 
            this.lblGorus.AutoSize = true;
            this.lblGorus.Location = new System.Drawing.Point(433, 48);
            this.lblGorus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGorus.Name = "lblGorus";
            this.lblGorus.Size = new System.Drawing.Size(35, 13);
            this.lblGorus.TabIndex = 2;
            this.lblGorus.Text = "label1";
            // 
            // FrmOgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblGorus);
            this.Controls.Add(this.lblKatildigim);
            this.Controls.Add(this.lblToplamEtkinlik);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOgrenciPanel";
            this.Text = "Öğrenci Panel";
            this.Load += new System.EventHandler(this.FrmOgrenciPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmEtkinliklerOgrenci;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCikisOgrenci;
        private System.Windows.Forms.ToolStripMenuItem FrmEtkinliklerOgrenci;
        private System.Windows.Forms.ToolStripMenuItem FrmKatildiklarim;
        private System.Windows.Forms.ToolStripMenuItem FrmGorusYaz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblToplamEtkinlik;
        private System.Windows.Forms.Label lblKatildigim;
        private System.Windows.Forms.Label lblGorus;
    }
}