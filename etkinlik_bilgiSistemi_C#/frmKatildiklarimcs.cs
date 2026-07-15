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
    public partial class frmKatildiklarimcs : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";

        public frmKatildiklarimcs()
        {
            InitializeComponent();
            btnListele.Click += btnListele_Click;

            Listele();
        }

        private void frmKatildiklarimcs_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string sorgu = @"
                SELECT
                    e.id,
                    e.etkinlik_adi AS 'Etkinlik Adı',
                    e.etkinlik_turu AS 'Tür',
                    e.kategori AS 'Kategori',
                    e.etkinlik_tarihi AS 'Tarih',
                    e.etkinlik_saati AS 'Saat',
                    e.etkinlik_konumu AS 'Konum',
                    k.katilim_tarihi AS 'Katılım Tarihi'
                FROM katilimlar k
                INNER JOIN etkinlikler e
                    ON k.etkinlik_id = e.id
                WHERE k.kullanici_id = @kullanici_id
                ORDER BY e.etkinlik_tarihi DESC";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullanici_id", Oturum.KullaniciId);

                MySqlDataAdapter da = new MySqlDataAdapter(komut);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


