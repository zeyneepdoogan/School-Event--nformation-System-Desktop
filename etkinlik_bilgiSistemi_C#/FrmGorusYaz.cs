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
    public partial class FrmGorusYaz : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";

        public FrmGorusYaz()
        {
            InitializeComponent();
            btnGönder.Click -= btnGonder_Click;
            btnGönder.Click += btnGonder_Click;

            btnCikis.Click -= btnCikis_Click;
            btnCikis.Click += btnCikis_Click;

            cmbPuan.Items.Clear();
            cmbPuan.Items.Add("1");
            cmbPuan.Items.Add("2");
            cmbPuan.Items.Add("3");
            cmbPuan.Items.Add("4");
            cmbPuan.Items.Add("5");

            EtkinlikleriGetir();
        }
        void EtkinlikleriGetir()
        {
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    string sorgu = @"
                    SELECT e.id, e.etkinlik_adi
                    FROM katilimlar k
                    INNER JOIN etkinlikler e ON e.id = k.etkinlik_id
                    WHERE k.kullanici_id = @kullanici_id
                    ORDER BY e.etkinlik_tarihi DESC";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kullanici_id", Oturum.KullaniciId);

                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbEtkinlik.DataSource = null;
                    cmbEtkinlik.DataSource = dt;
                    cmbEtkinlik.DisplayMember = "etkinlik_adi";
                    cmbEtkinlik.ValueMember = "id";

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Görüş yazmak için önce bir etkinliğe katılmanız gerekiyor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlikler yüklenirken hata oluştu: " + ex.Message);
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (cmbEtkinlik.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir etkinlik seçiniz.");
                    return;
                }

                if (cmbPuan.Text == "")
                {
                    MessageBox.Show("Lütfen puan seçiniz.");
                    return;
                }

                if (txtGorus.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen görüş yazınız.");
                    return;
                }

                int etkinlikId = Convert.ToInt32(cmbEtkinlik.SelectedValue);
                int puan = Convert.ToInt32(cmbPuan.Text);

                using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    string kontrolSorgu = @"
                    SELECT COUNT(*) 
                    FROM gorusler 
                    WHERE kullanici_id = @kullanici_id 
                    AND etkinlik_id = @etkinlik_id";

                    MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti);
                    kontrolKomut.Parameters.AddWithValue("@kullanici_id", Oturum.KullaniciId);
                    kontrolKomut.Parameters.AddWithValue("@etkinlik_id", etkinlikId);

                    int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu etkinlik için daha önce görüş yazdınız.");
                        return;
                    }

                    string ekleSorgu = @"
                    INSERT INTO gorusler
                    (kullanici_id, etkinlik_id, gorus, puan)
                    VALUES
                    (@kullanici_id, @etkinlik_id, @gorus, @puan)";

                    MySqlCommand ekleKomut = new MySqlCommand(ekleSorgu, baglanti);
                    ekleKomut.Parameters.AddWithValue("@kullanici_id", Oturum.KullaniciId);
                    ekleKomut.Parameters.AddWithValue("@etkinlik_id", etkinlikId);
                    ekleKomut.Parameters.AddWithValue("@gorus", txtGorus.Text.Trim());
                    ekleKomut.Parameters.AddWithValue("@puan", puan);

                    int sonuc = ekleKomut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Görüş başarıyla gönderildi. Admin panelindeki görüşler kısmında görünecek.");
                        txtGorus.Clear();
                        cmbPuan.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Görüş gönderilemedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGorusYaz_Load(object sender, EventArgs e)
        {

        }

        private void btnGönder_Click(object sender, EventArgs e)
        {

        }
    }
}
