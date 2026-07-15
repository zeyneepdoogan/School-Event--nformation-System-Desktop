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
    public partial class FrmKatilimlar : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public FrmKatilimlar()
        {
            InitializeComponent();
        }

        private void FrmKatilimlar_Load(object sender, EventArgs e)
        {
           Listele();
        }
        void Listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string sorgu = @"
                SELECT 
                k.id,
                ku.kullanici_adi AS 'Öğrenci',
                e.etkinlik_adi AS 'Etkinlik',
                e.etkinlik_turu AS 'Tür',
                e.etkinlik_tarihi AS 'Etkinlik Tarihi',
                k.katilim_tarihi AS 'Katılım Tarihi'
                FROM katilimlar k
                INNER JOIN kullanicilar ku ON k.kullanici_id = ku.id
                INNER JOIN etkinlikler e ON k.etkinlik_id = e.id
                ORDER BY k.katilim_tarihi DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}