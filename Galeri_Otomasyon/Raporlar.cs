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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        GaleriEntities1 baglanti = new GaleriEntities1();
        private void button1_Click(object sender, EventArgs e)
        {

            var sonuc = from arac in baglanti.Araçlar
                        orderby arac.AracModel descending
                        select arac;
          
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc = from arac in baglanti.Araçlar
                        group arac by arac.AracMarka
                     into grup
                        select new
                        {
                            ToplamFiyat = grup.Sum(x => x.AracFiyat * x.AracAdet),
                            Marka = grup.Key
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sonuc = from arac in baglanti.Araçlar
                        orderby arac.AracYıl ascending
                        select arac;
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = from arac in baglanti.Araçlar
                        join sube in baglanti.Şubeler on arac.SubeNo
                        equals sube.SubeNo
                        select new
                        {
                            arac.AracMarka,
                            arac.AracModel,
                            arac.AracFiyat,
                            sube.SubeAdi
                        };
            dataGridView1.DataSource = sonuc.ToList();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sonuc = from arac in baglanti.Araçlar
                        join sube in baglanti.Şubeler on arac.SubeNo equals
                        sube.SubeNo
                        join müsteri in baglanti.Müşteriler on sube.MusteriNo equals
            müsteri.MusteriNo
                        select new
                        {
                            arac.AracMarka,
                            arac.AracFiyat,
                            sube.SubeAdi,
                            müsteri.AdSoyad
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sonuc = from müsteri in baglanti.Müşteriler
                        group müsteri by müsteri.Yas into grup
                        

                        select new
                        {
                            Bakiye = grup.Max(x => x.MusteriBakiye),
                            Yas = grup.Key
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
    }
}
