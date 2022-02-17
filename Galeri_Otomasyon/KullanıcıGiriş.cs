using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri_Otomasyon
{
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }

        GaleriEntities1 baglanti = new GaleriEntities1();
        private bool GirisYap(string ad,string sifre)
        {
           
            var sorgu = from p in baglanti.Kullanicilars
                        where p.KullaniciAdi == ad && p.Sifre == sifre
                        select p;

            if (sorgu.Any())
            {
                return true;
                
            }
            else
            {
                return false;
            }

            txtKulAdi.Clear();
            txtSifre.Clear();



        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (GirisYap(txtKulAdi.Text,txtSifre.Text))
            {
                AnaSayfa anasayfagit = new AnaSayfa();
                anasayfagit.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kullanicilar ekle = new Kullanicilar();

            ekle.KullaniciAdi = txtkullaniciad.Text;
            ekle.Sifre = txtKulSifre.Text;

            baglanti.Kullanicilars.Add(ekle);
            baglanti.SaveChanges();
            MessageBox.Show("Kayıt Oluşturuldu...");

            txtkullaniciad.Clear();
            txtKulSifre.Clear();

            
        }

        private void KullanıcıGiriş_Load(object sender, EventArgs e)
        {
            groupkaydol.Visible = false;

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            groupkaydol.Visible = true;
        }
    }
}
