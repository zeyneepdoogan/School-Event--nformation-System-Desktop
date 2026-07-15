namespace etkinlik_bilgiSistemi_C_
{
    partial class frmİstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelEtkinlikv = new System.Windows.Forms.Panel();
            this.lblToplamEtkinlik = new System.Windows.Forms.Label();
            this.panelKatilim = new System.Windows.Forms.Panel();
            this.lblToplamKatilim = new System.Windows.Forms.Label();
            this.panelAktif = new System.Windows.Forms.Panel();
            this.lblAktif = new System.Windows.Forms.Label();
            this.panelYaklasan = new System.Windows.Forms.Panel();
            this.lblYaklasan = new System.Windows.Forms.Label();
            this.panelGorus = new System.Windows.Forms.Panel();
            this.lblToplamGorus = new System.Windows.Forms.Label();
            this.chartEtkinlikTurleri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEtkinlikv.SuspendLayout();
            this.panelKatilim.SuspendLayout();
            this.panelAktif.SuspendLayout();
            this.panelYaklasan.SuspendLayout();
            this.panelGorus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEtkinlikTurleri)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEtkinlikv
            // 
            this.panelEtkinlikv.Controls.Add(this.lblToplamEtkinlik);
            this.panelEtkinlikv.Location = new System.Drawing.Point(20, 24);
            this.panelEtkinlikv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEtkinlikv.Name = "panelEtkinlikv";
            this.panelEtkinlikv.Size = new System.Drawing.Size(150, 81);
            this.panelEtkinlikv.TabIndex = 0;
            // 
            // lblToplamEtkinlik
            // 
            this.lblToplamEtkinlik.AutoSize = true;
            this.lblToplamEtkinlik.Location = new System.Drawing.Point(56, 33);
            this.lblToplamEtkinlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamEtkinlik.Name = "lblToplamEtkinlik";
            this.lblToplamEtkinlik.Size = new System.Drawing.Size(27, 13);
            this.lblToplamEtkinlik.TabIndex = 0;
            this.lblToplamEtkinlik.Text = "Sayı\r\n";
            // 
            // panelKatilim
            // 
            this.panelKatilim.Controls.Add(this.lblToplamKatilim);
            this.panelKatilim.Location = new System.Drawing.Point(20, 120);
            this.panelKatilim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelKatilim.Name = "panelKatilim";
            this.panelKatilim.Size = new System.Drawing.Size(150, 81);
            this.panelKatilim.TabIndex = 0;
            // 
            // lblToplamKatilim
            // 
            this.lblToplamKatilim.AutoSize = true;
            this.lblToplamKatilim.Location = new System.Drawing.Point(56, 32);
            this.lblToplamKatilim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamKatilim.Name = "lblToplamKatilim";
            this.lblToplamKatilim.Size = new System.Drawing.Size(27, 13);
            this.lblToplamKatilim.TabIndex = 0;
            this.lblToplamKatilim.Text = "Sayı";
            // 
            // panelAktif
            // 
            this.panelAktif.Controls.Add(this.lblAktif);
            this.panelAktif.Location = new System.Drawing.Point(210, 24);
            this.panelAktif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAktif.Name = "panelAktif";
            this.panelAktif.Size = new System.Drawing.Size(150, 81);
            this.panelAktif.TabIndex = 0;
            // 
            // lblAktif
            // 
            this.lblAktif.AutoSize = true;
            this.lblAktif.Location = new System.Drawing.Point(58, 33);
            this.lblAktif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(27, 13);
            this.lblAktif.TabIndex = 0;
            this.lblAktif.Text = "Sayı";
            // 
            // panelYaklasan
            // 
            this.panelYaklasan.Controls.Add(this.lblYaklasan);
            this.panelYaklasan.Location = new System.Drawing.Point(210, 120);
            this.panelYaklasan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelYaklasan.Name = "panelYaklasan";
            this.panelYaklasan.Size = new System.Drawing.Size(150, 81);
            this.panelYaklasan.TabIndex = 0;
            // 
            // lblYaklasan
            // 
            this.lblYaklasan.AutoSize = true;
            this.lblYaklasan.Location = new System.Drawing.Point(58, 32);
            this.lblYaklasan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYaklasan.Name = "lblYaklasan";
            this.lblYaklasan.Size = new System.Drawing.Size(27, 13);
            this.lblYaklasan.TabIndex = 0;
            this.lblYaklasan.Text = "Sayı";
            // 
            // panelGorus
            // 
            this.panelGorus.Controls.Add(this.lblToplamGorus);
            this.panelGorus.Location = new System.Drawing.Point(379, 24);
            this.panelGorus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGorus.Name = "panelGorus";
            this.panelGorus.Size = new System.Drawing.Size(150, 81);
            this.panelGorus.TabIndex = 0;
            // 
            // lblToplamGorus
            // 
            this.lblToplamGorus.AutoSize = true;
            this.lblToplamGorus.Location = new System.Drawing.Point(46, 33);
            this.lblToplamGorus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamGorus.Name = "lblToplamGorus";
            this.lblToplamGorus.Size = new System.Drawing.Size(27, 13);
            this.lblToplamGorus.TabIndex = 0;
            this.lblToplamGorus.Text = "Sayı";
            // 
            // chartEtkinlikTurleri
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEtkinlikTurleri.ChartAreas.Add(chartArea1);
            this.chartEtkinlikTurleri.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartEtkinlikTurleri.Legends.Add(legend1);
            this.chartEtkinlikTurleri.Location = new System.Drawing.Point(0, 230);
            this.chartEtkinlikTurleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartEtkinlikTurleri.Name = "chartEtkinlikTurleri";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEtkinlikTurleri.Series.Add(series1);
            this.chartEtkinlikTurleri.Size = new System.Drawing.Size(600, 136);
            this.chartEtkinlikTurleri.TabIndex = 1;
            this.chartEtkinlikTurleri.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartEtkinlikTurleri);
            this.Controls.Add(this.panelGorus);
            this.Controls.Add(this.panelYaklasan);
            this.Controls.Add(this.panelAktif);
            this.Controls.Add(this.panelKatilim);
            this.Controls.Add(this.panelEtkinlikv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmİstatistik";
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.frmİstatistik_Load);
            this.panelEtkinlikv.ResumeLayout(false);
            this.panelEtkinlikv.PerformLayout();
            this.panelKatilim.ResumeLayout(false);
            this.panelKatilim.PerformLayout();
            this.panelAktif.ResumeLayout(false);
            this.panelAktif.PerformLayout();
            this.panelYaklasan.ResumeLayout(false);
            this.panelYaklasan.PerformLayout();
            this.panelGorus.ResumeLayout(false);
            this.panelGorus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEtkinlikTurleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEtkinlikv;
        private System.Windows.Forms.Panel panelKatilim;
        private System.Windows.Forms.Panel panelAktif;
        private System.Windows.Forms.Panel panelYaklasan;
        private System.Windows.Forms.Panel panelGorus;
        private System.Windows.Forms.Label lblToplamEtkinlik;
        private System.Windows.Forms.Label lblToplamKatilim;
        private System.Windows.Forms.Label lblAktif;
        private System.Windows.Forms.Label lblYaklasan;
        private System.Windows.Forms.Label lblToplamGorus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEtkinlikTurleri;
        private System.Windows.Forms.Button button1;
    }
}