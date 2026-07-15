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
    public partial class FrmEtkinlikler : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";

        public FrmEtkinlikler()
        {
            InitializeComponent();
            Listele();
        }
        private void FrmEtkinlikler_Load(object sender, EventArgs e)
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
                e.id,
                e.etkinlik_adi AS 'Etkinlik Adı',
                e.etkinlik_turu AS 'Tür',
                e.kategori AS 'Kategori',
                e.etkinlik_tarihi AS 'Tarih',
                e.etkinlik_saati AS 'Saat',
                e.etkinlik_konumu AS 'Konum',
                e.kontenjan AS 'Kontenjan',
                COUNT(k.id) AS 'Katılımcı Sayısı',
                e.durum AS 'Durum'
                FROM etkinlikler e
                LEFT JOIN katilimlar k ON e.id = k.etkinlik_id
                GROUP BY e.id, e.etkinlik_adi, e.etkinlik_turu, e.kategori, e.etkinlik_tarihi,
                e.etkinlik_saati, e.etkinlik_konumu, e.kontenjan, e.durum
                ORDER BY e.etkinlik_tarihi ASC";

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

        private void btnAra_Click(object sender, EventArgs e)
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
                e.kontenjan AS 'Kontenjan',
                COUNT(k.id) AS 'Katılımcı Sayısı',
                e.durum AS 'Durum'
                FROM etkinlikler e
                LEFT JOIN katilimlar k ON e.id = k.etkinlik_id
                WHERE e.etkinlik_adi LIKE @ara
                OR e.etkinlik_turu LIKE @ara
                OR e.kategori LIKE @ara
                GROUP BY e.id, e.etkinlik_adi, e.etkinlik_turu, e.kategori, e.etkinlik_tarihi,
                e.etkinlik_saati, e.etkinlik_konumu, e.kontenjan, e.durum
                ORDER BY e.etkinlik_tarihi ASC";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ara", "%" + txtAra.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir etkinlik seç.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult cevap = MessageBox.Show(
                "Seçili etkinliği silmek istiyor musun?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (cevap == DialogResult.Yes)
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    MySqlCommand komut = new MySqlCommand(
                        "DELETE FROM etkinlikler WHERE id=@id",
                        baglanti
                    );

                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Etkinlik silindi.");
                Listele();
            }
        }
    }
}