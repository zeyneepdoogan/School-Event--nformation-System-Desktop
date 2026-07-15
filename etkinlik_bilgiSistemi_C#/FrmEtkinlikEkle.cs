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
    public partial class FrmEtkinlikEkle : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public FrmEtkinlikEkle()
        {
            InitializeComponent();
        }

     

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int kontenjan = Convert.ToInt32(txtKontenjan.Text);

                using (MySqlConnection baglanti = new MySqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    string sorgu = @"
            INSERT INTO etkinlikler
            (etkinlik_adi, etkinlik_turu, kategori, aciklama, etkinlik_tarihi,
             etkinlik_saati, sure, etkinlik_konumu, kontenjan, durum,
             katilim_turu, sorumlu, iletisim, fakulte, one_cikan, afis)
            VALUES
            (@ad, @tur, @kategori, @aciklama, @tarih,
             @saat, @sure, @konum, @kontenjan, @durum,
             @katilimTuru, @sorumlu, @iletisim, @fakulte, 0, '')";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@ad", txtEtkinlikAdi.Text);
                    komut.Parameters.AddWithValue("@tur", cmbTur.Text);
                    komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                    komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                    komut.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToString("yyyy-MM-dd"));
                    komut.Parameters.AddWithValue("@saat", txtSaat.Text);
                    komut.Parameters.AddWithValue("@sure", txtSure.Text);
                    komut.Parameters.AddWithValue("@konum", txtKonum.Text);
                    komut.Parameters.AddWithValue("@kontenjan", kontenjan);
                    komut.Parameters.AddWithValue("@durum", cmbDurum.Text);
                    komut.Parameters.AddWithValue("@katilimTuru", cmbKatilimTuru.Text);
                    komut.Parameters.AddWithValue("@sorumlu", txtSorumlu.Text);
                    komut.Parameters.AddWithValue("@iletisim", txtIletisim.Text);
                    komut.Parameters.AddWithValue("@fakulte", txtFakulte.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Etkinlik başarıyla eklendi.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Kontenjan alanına sadece sayı giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        

        private void FrmEtkinlikEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

