namespace etkinlik_bilgiSistemi_C_
{
    partial class FrmGorusYaz
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
            this.lblEtkinlik = new System.Windows.Forms.Label();
            this.cmbEtkinlik = new System.Windows.Forms.ComboBox();
            this.txtGorus = new System.Windows.Forms.TextBox();
            this.cmbPuan = new System.Windows.Forms.ComboBox();
            this.btnGönder = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEtkinlik
            // 
            this.lblEtkinlik.AutoSize = true;
            this.lblEtkinlik.Location = new System.Drawing.Point(50, 40);
            this.lblEtkinlik.Name = "lblEtkinlik";
            this.lblEtkinlik.Size = new System.Drawing.Size(49, 16);
            this.lblEtkinlik.TabIndex = 0;
            this.lblEtkinlik.Text = "Etkinlik\r\n";
            // 
            // cmbEtkinlik
            // 
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(121, 37);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(121, 24);
            this.cmbEtkinlik.TabIndex = 1;
            // 
            // txtGorus
            // 
            this.txtGorus.Location = new System.Drawing.Point(121, 67);
            this.txtGorus.Name = "txtGorus";
            this.txtGorus.Size = new System.Drawing.Size(404, 22);
            this.txtGorus.TabIndex = 2;
            // 
            // cmbPuan
            // 
            this.cmbPuan.FormattingEnabled = true;
            this.cmbPuan.Items.AddRange(new object[] {
            "1",
            "",
            "2",
            "",
            "3",
            "",
            "4",
            "",
            "5"});
            this.cmbPuan.Location = new System.Drawing.Point(121, 95);
            this.cmbPuan.Name = "cmbPuan";
            this.cmbPuan.Size = new System.Drawing.Size(121, 24);
            this.cmbPuan.TabIndex = 3;
            // 
            // btnGönder
            // 
            this.btnGönder.Location = new System.Drawing.Point(121, 141);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(75, 23);
            this.btnGönder.TabIndex = 4;
            this.btnGönder.Text = "Gönder\r\n";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(220, 141);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görüşleriniz\r\n\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puan";
            // 
            // FrmGorusYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.cmbPuan);
            this.Controls.Add(this.txtGorus);
            this.Controls.Add(this.cmbEtkinlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEtkinlik);
            this.Name = "FrmGorusYaz";
            this.Text = "Görüşlerinizi Yazınız";
            this.Load += new System.EventHandler(this.FrmGorusYaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtkinlik;
        private System.Windows.Forms.ComboBox cmbEtkinlik;
        private System.Windows.Forms.TextBox txtGorus;
        private System.Windows.Forms.ComboBox cmbPuan;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}