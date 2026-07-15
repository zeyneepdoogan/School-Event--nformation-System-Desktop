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
    public partial class Form1 : Form
    {
        string baglantiMetni = "Server=localhost;Database=etkinlik_sistemi;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        
            {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            MySqlConnection baglanti = new MySqlConnection(baglantiMetni);

            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM kullanicilar WHERE kullanici_adi=@kullaniciAdi AND sifre=@sifre";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                MySqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    Oturum.KullaniciId = Convert.ToInt32(dr["id"]);
                    Oturum.KullaniciAdi = dr["kullanici_adi"].ToString();
                    Oturum.Yetki = dr["yetki"].ToString();

                    string yetki = dr["yetki"].ToString();

                    MessageBox.Show("Giriş başarılı");

                    if (yetki == "admin")
                    {
                        FrmAdminPanel admin = new FrmAdminPanel();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmOgrenciPanel ogrenci = new FrmOgrenciPanel();
                        ogrenci.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tsmEtkinlikİslemleri_Click(object sender, EventArgs e)
        {
          
        }

        private void tsmEtkinlikListele_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmGorusler_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

