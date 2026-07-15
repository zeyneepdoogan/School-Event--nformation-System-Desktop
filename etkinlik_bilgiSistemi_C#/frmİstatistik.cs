using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace etkinlik_bilgiSistemi_C_
{
    public partial class frmİstatistik : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public frmİstatistik()
        {
            InitializeComponent();
        }

        private void frmİstatistik_Load(object sender, EventArgs e)
        {
            IstatistikGetir();
            GrafikGetir();
        }
        void IstatistikGetir()
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

                lblAktif.Text = "Toplam Aktif\n" +
                    new MySqlCommand("SELECT COUNT(*) FROM etkinlikler WHERE durum='Aktif'", baglanti).ExecuteScalar();

                lblYaklasan.Text = "Toplam Yaklaşan\n" +
                    new MySqlCommand("SELECT COUNT(*) FROM etkinlikler WHERE durum='Yaklaşıyor'", baglanti).ExecuteScalar();
            }
        }

        void GrafikGetir()
        {
            chartEtkinlikTurleri.Series.Clear();
            chartEtkinlikTurleri.Titles.Clear();

            Series seri = new Series("Etkinlik Türleri");
            seri.ChartType = SeriesChartType.Column;
            seri.IsValueShownAsLabel = true;

            chartEtkinlikTurleri.Series.Add(seri);

            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string sorgu = @"
                SELECT etkinlik_turu, COUNT(*) AS adet
                FROM etkinlikler
                GROUP BY etkinlik_turu";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    seri.Points.AddXY(
                        dr["etkinlik_turu"].ToString(),
                        Convert.ToInt32(dr["adet"])
                    );
                }
            }

            chartEtkinlikTurleri.Titles.Add("Etkinlik Türü Dağılımı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

