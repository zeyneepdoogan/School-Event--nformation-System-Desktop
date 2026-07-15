using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace etkinlik_bilgiSistemi_C_
{
    public partial class FrmAdminPanel : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public FrmAdminPanel()
        {
            InitializeComponent();
            DashboardGetir();
            TasarimAyarla();
        }
        void DashboardGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                lblToplamEtkinlik.Text = "Toplam Etkinlik\n" +
                    new MySqlCommand("SELECT COUNT(*) FROM etkinlikler", baglanti).ExecuteScalar();

                lblToplamKatilim.Text = "Toplam Katılım\n" +
                    new MySqlCommand("SELECT COUNT(*) FROM katilimlar", baglanti).ExecuteScalar();

                lblToplamGorus.Text = "Toplam Görüş\n" +
                    new MySqlCommand("SELECT COUNT(*) FROM gorusler", baglanti).ExecuteScalar();
            }
        }
        void TasarimAyarla()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            lblToplamEtkinlik.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblToplamKatilim.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblToplamGorus.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void tsmGörüsler_Click(object sender, EventArgs e)
        {
            FrmGoruslercs frmGoruslercs = new FrmGoruslercs();  
            frmGoruslercs.ShowDialog();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
         "Oturumu kapatmak istiyor musunuz?",
         "Çıkış Yap",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                this.Hide();

                Form1 giris = new Form1();
                giris.Show();
            }
        }

        private void tsmEtkinlikEkle_Click(object sender, EventArgs e)
        {
            FrmEtkinlikEkle etkinlikEkle = new FrmEtkinlikEkle();
            etkinlikEkle.ShowDialog();
        }

        private void tsmEtkinlikListele_Click(object sender, EventArgs e)
        {
        }

        private void tsmEtkinlikGuncelle_Click(object sender, EventArgs e)
        {
            frmGüncelleme frmGüncelleme = new frmGüncelleme();  
            frmGüncelleme.ShowDialog();

        }

        private void tsmEtkinlikSil_Click(object sender, EventArgs e)
        {
          

        }

        private void tsmKatilimlar_Click(object sender, EventArgs e)
        {
            FrmKatilimlar frmKatilimlar = new FrmKatilimlar();
            frmKatilimlar.ShowDialog();
        }

        private void tsmIstatistik_Click(object sender, EventArgs e)
        {
            frmİstatistik frmİstatistik = new frmİstatistik();
            frmİstatistik.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuEtkinlikler_Click(object sender, EventArgs e)
        {
            FrmEtkinlikler frmEtkinlikler = new FrmEtkinlikler();
            frmEtkinlikler.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
