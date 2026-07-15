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
    public partial class FrmOgrenciPanel : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public FrmOgrenciPanel()
        {
            InitializeComponent();
            DashboardGetir();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }
        void DashboardGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                MySqlCommand cmd1 =
                    new MySqlCommand("SELECT COUNT(*) FROM etkinlikler", baglanti);

                lblToplamEtkinlik.Text =
                    "Toplam Etkinlik\n" +
                    cmd1.ExecuteScalar().ToString();

                MySqlCommand cmd2 =
                    new MySqlCommand(
                    "SELECT COUNT(*) FROM katilimlar WHERE kullanici_id=@id",
                    baglanti);

                cmd2.Parameters.AddWithValue("@id", Oturum.KullaniciId);

                lblKatildigim.Text =
                    "Katıldığım\n" +
                    cmd2.ExecuteScalar().ToString();

                MySqlCommand cmd3 =
                    new MySqlCommand(
                    "SELECT COUNT(*) FROM gorusler WHERE kullanici_id=@id",
                    baglanti);

                cmd3.Parameters.AddWithValue("@id", Oturum.KullaniciId);

                lblGorus.Text =
                    "Görüşlerim\n" +
                    cmd3.ExecuteScalar().ToString();
            }
        }
        private void FrmEtkinliklerOgrenci_Click(object sender, EventArgs e)
        {
            ogrenci frmEtkinliklerOgrenci = new ogrenci();
            frmEtkinliklerOgrenci.ShowDialog();
        }

        private void FrmKatildiklarim_Click(object sender, EventArgs e)
        {
           frmKatildiklarimcs frmKatildiklarimcs = new frmKatildiklarimcs();
            frmKatildiklarimcs.ShowDialog();
        }

        private void FrmGorusYaz_Click(object sender, EventArgs e)
        {
            FrmGorusYaz frmGorusYaz = new FrmGorusYaz();
            frmGorusYaz.ShowDialog();
        }

        private void menuCikisOgrenci_Click(object sender, EventArgs e)
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

        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
