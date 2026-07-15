namespace etkinlik_bilgiSistemi_C_
{
    partial class FrmRaporlar
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
            this.lblToplamEtkinlik = new System.Windows.Forms.Label();
            this.lblToplamKatilim = new System.Windows.Forms.Label();
            this.lblToplamGorus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRaporla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamEtkinlik
            // 
            this.lblToplamEtkinlik.AutoSize = true;
            this.lblToplamEtkinlik.Location = new System.Drawing.Point(49, 26);
            this.lblToplamEtkinlik.Name = "lblToplamEtkinlik";
            this.lblToplamEtkinlik.Size = new System.Drawing.Size(99, 16);
            this.lblToplamEtkinlik.TabIndex = 0;
            this.lblToplamEtkinlik.Text = "Toplam Etkinlik";
            // 
            // lblToplamKatilim
            // 
            this.lblToplamKatilim.AutoSize = true;
            this.lblToplamKatilim.Location = new System.Drawing.Point(49, 68);
            this.lblToplamKatilim.Name = "lblToplamKatilim";
            this.lblToplamKatilim.Size = new System.Drawing.Size(96, 16);
            this.lblToplamKatilim.TabIndex = 0;
            this.lblToplamKatilim.Text = "Toplam Katılım";
            // 
            // lblToplamGorus
            // 
            this.lblToplamGorus.AutoSize = true;
            this.lblToplamGorus.Location = new System.Drawing.Point(49, 106);
            this.lblToplamGorus.Name = "lblToplamGorus";
            this.lblToplamGorus.Size = new System.Drawing.Size(93, 16);
            this.lblToplamGorus.TabIndex = 0;
            this.lblToplamGorus.Text = "Toplam Görüş";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(52, 146);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(75, 23);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "Listele";
            this.btnRaporla.UseVisualStyleBackColor = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblToplamGorus);
            this.Controls.Add(this.lblToplamKatilim);
            this.Controls.Add(this.lblToplamEtkinlik);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamEtkinlik;
        private System.Windows.Forms.Label lblToplamKatilim;
        private System.Windows.Forms.Label lblToplamGorus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRaporla;
    }
}