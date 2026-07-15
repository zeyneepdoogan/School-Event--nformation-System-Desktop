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
    public partial class FrmGoruslercs : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public FrmGoruslercs()
        {
            InitializeComponent();
            btnListele.Click += btnListele_Click;
            button1.Click += button1_Click;

            Listele();
        }

        private void FrmGoruslercs_Load(object sender, EventArgs e)
        {
           
        }
        void Listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string sorgu = @"
                SELECT 
                    g.id,
                    ku.kullanici_adi AS 'Öğrenci',
                    e.etkinlik_adi AS 'Etkinlik',
                    g.puan AS 'Puan',
                    g.gorus AS 'Görüş',
                    g.tarih AS 'Tarih'
                FROM gorusler g
                INNER JOIN kullanicilar ku ON g.kullanici_id = ku.id
                INNER JOIN etkinlikler e ON g.etkinlik_id = e.id
                ORDER BY g.tarih DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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