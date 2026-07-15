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
    public partial class frmGüncelleme : Form
    {
        int secilenId = 0;
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public frmGüncelleme()
        {
            InitializeComponent();
            btnListele.Click += btnListele_Click;
            btnGuncelle.Click += btnGuncelle_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            Listele();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmGüncelleme_Load(object sender, EventArgs e)
        {
        }

        void Listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string sorgu = @"
                SELECT 
                id,
                etkinlik_adi,
                etkinlik_turu,
                kategori,
                etkinlik_tarihi,
                etkinlik_saati,
                etkinlik_konumu,
                kontenjan,
                durum
                FROM etkinlikler
                ORDER BY etkinlik_tarihi ASC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                txtEtkinlikAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["etkinlik_adi"].Value.ToString();
                txtTur.Text = dataGridView1.Rows[e.RowIndex].Cells["etkinlik_turu"].Value.ToString();
                txtKategori.Text = dataGridView1.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
                dtpTarih.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["etkinlik_tarihi"].Value);
                txtSaat.Text = dataGridView1.Rows[e.RowIndex].Cells["etkinlik_saati"].Value.ToString();
                txtKonum.Text = dataGridView1.Rows[e.RowIndex].Cells["etkinlik_konumu"].Value.ToString();
                txtKontenjan.Text = dataGridView1.Rows[e.RowIndex].Cells["kontenjan"].Value.ToString();
                cmbDurum.Text = dataGridView1.Rows[e.RowIndex].Cells["durum"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek etkinliği tablodan seçiniz.");
                return;
            }

            int kontenjan;

            if (!int.TryParse(txtKontenjan.Text, out kontenjan))
            {
                MessageBox.Show("Kontenjan alanına sayı giriniz.");
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
            {
                baglanti.Open();

                string sorgu = @"
                UPDATE etkinlikler SET
                etkinlik_adi=@ad,
                etkinlik_turu=@tur,
                kategori=@kategori,
                etkinlik_tarihi=@tarih,
                etkinlik_saati=@saat,
                etkinlik_konumu=@konum,
                kontenjan=@kontenjan,
                durum=@durum
                WHERE id=@id";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", secilenId);
                komut.Parameters.AddWithValue("@ad", txtEtkinlikAdi.Text);
                komut.Parameters.AddWithValue("@tur", txtTur.Text);
                komut.Parameters.AddWithValue("@kategori", txtKategori.Text);
                komut.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@saat", txtSaat.Text);
                komut.Parameters.AddWithValue("@konum", txtKonum.Text);
                komut.Parameters.AddWithValue("@kontenjan", kontenjan);
                komut.Parameters.AddWithValue("@durum", cmbDurum.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Etkinlik başarıyla güncellendi.");
                Listele();
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
 
