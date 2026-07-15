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
    public partial class ogrenci : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public ogrenci()
        {
            InitializeComponent();
            btnAra.Click += btnAra_Click;
            btnListele.Click += btnListele_Click;
            btnKatil.Click += btnKatil_Click;

            Listele();
        }

        private void txtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAratxtAra_Load(object sender, EventArgs e)
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
                    e.kontenjan AS 'Kontenjan',
                    COUNT(k.id) AS 'Katılımcı Sayısı',
                    CASE 
                        WHEN e.etkinlik_tarihi < CURDATE() THEN 'Geçmiş'
                        ELSE e.durum
                    END AS 'Durum'
                FROM etkinlikler e
                LEFT JOIN katilimlar k ON e.id = k.etkinlik_id
                GROUP BY 
                    e.id,
                    e.etkinlik_adi,
                    e.etkinlik_turu,
                    e.kategori,
                    e.etkinlik_tarihi,
                    e.etkinlik_saati,
                    e.etkinlik_konumu,
                    e.kontenjan,
                    e.durum
                ORDER BY e.etkinlik_tarihi ASC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
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
                    CASE 
                        WHEN e.etkinlik_tarihi < CURDATE() THEN 'Geçmiş'
                        ELSE e.durum
                    END AS 'Durum'
                FROM etkinlikler e
                LEFT JOIN katilimlar k ON e.id = k.etkinlik_id
                WHERE 
                    e.etkinlik_adi LIKE @ara
                    OR e.etkinlik_turu LIKE @ara
                    OR e.kategori LIKE @ara
                GROUP BY 
                    e.id,
                    e.etkinlik_adi,
                    e.etkinlik_turu,
                    e.kategori,
                    e.etkinlik_tarihi,
                    e.etkinlik_saati,
                    e.etkinlik_konumu,
                    e.kontenjan,
                    e.durum
                ORDER BY e.etkinlik_tarihi ASC";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ara", "%" + txtAra.Text.Trim() + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnKatil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen katılmak için bir etkinlik seçiniz.");
                return;
            }

            int etkinlikId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            int kontenjan = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kontenjan"].Value);
            int katilimciSayisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Katılımcı Sayısı"].Value);
            string durum = dataGridView1.CurrentRow.Cells["Durum"].Value.ToString();

            if (durum == "Geçmiş")
            {
                MessageBox.Show("Geçmiş etkinliğe katılım yapılamaz.");
                return;
            }

            if (katilimciSayisi >= kontenjan)
            {
                MessageBox.Show("Bu etkinliğin kontenjanı dolmuştur.");
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string kontrolSorgu = @"
                SELECT COUNT(*) 
                FROM katilimlar 
                WHERE kullanici_id=@kullanici_id 
                AND etkinlik_id=@etkinlik_id";

                MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti);
                kontrolKomut.Parameters.AddWithValue("@kullanici_id", Oturum.KullaniciId);
                kontrolKomut.Parameters.AddWithValue("@etkinlik_id", etkinlikId);

                int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (varMi > 0)
                {
                    MessageBox.Show("Bu etkinliğe zaten katıldınız.");
                    return;
                }

                string ekleSorgu = @"
                INSERT INTO katilimlar
                (kullanici_id, etkinlik_id)
                VALUES
                (@kullanici_id, @etkinlik_id)";

                MySqlCommand ekleKomut = new MySqlCommand(ekleSorgu, baglanti);
                ekleKomut.Parameters.AddWithValue("@kullanici_id", Oturum.KullaniciId);
                ekleKomut.Parameters.AddWithValue("@etkinlik_id", etkinlikId);

                ekleKomut.ExecuteNonQuery();

                MessageBox.Show("Etkinliğe başarıyla katıldınız.");
            }

            Listele();
        }
    }
}

