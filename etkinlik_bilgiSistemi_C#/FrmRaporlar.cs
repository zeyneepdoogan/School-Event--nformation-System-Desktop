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
    public partial class FrmRaporlar : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";

        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            Raporla();

        }
        void Raporla()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                lblToplamEtkinlik.Text = "Toplam Etkinlik: " + new MySqlCommand("SELECT COUNT(*) FROM etkinlikler", baglanti).ExecuteScalar();
                lblToplamKatilim.Text = "Toplam Katılım: " + new MySqlCommand("SELECT COUNT(*) FROM katilimlar", baglanti).ExecuteScalar();
                lblToplamGorus.Text = "Toplam Görüş: " + new MySqlCommand("SELECT COUNT(*) FROM gorusler", baglanti).ExecuteScalar();

                string sorgu = @"
                SELECT etkinlik_turu AS 'Etkinlik Türü', COUNT(*) AS 'Adet'
                FROM etkinlikler
                GROUP BY etkinlik_turu";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            Raporla();
        }
    }
}
    