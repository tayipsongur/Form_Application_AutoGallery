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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GaleriEntities1 baglanti = new GaleriEntities1();

        public void VeriGoster()
        {
            dataGridView1.DataSource = baglanti.Müşteriler.ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Müşteriler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Müşteriler müsteriekle = new Müşteriler();

            müsteriekle.AdSoyad = txtAdSoyad.Text;
            müsteriekle.Telefon = maskedTelefon.Text;
            müsteriekle.Yas = Convert.ToInt32(txtYas.Text);
            müsteriekle.MusteriBakiye = Convert.ToInt32(txtBakiye.Text);

            baglanti.Müşteriler.Add(müsteriekle);
            
            MessageBox.Show("Müşteri Başarıyla Eklendi");
          
            baglanti.SaveChanges();
            VeriGoster();


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int MusteriId = Convert.ToInt32(txtNo.Text);
            var guncelle = baglanti.Müşteriler.Where(x => x.MusteriNo == MusteriId).FirstOrDefault();

            guncelle.AdSoyad = txtAdSoyad.Text;
            guncelle.Telefon = maskedTelefon.Text;
            guncelle.Yas = Convert.ToInt32(txtYas.Text);
            guncelle.MusteriBakiye = Convert.ToDecimal(txtBakiye.Text);

            MessageBox.Show("Güncelleme İşlemi Başarılı");
            baglanti.SaveChanges();
          
            VeriGoster();


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtNo.Text = satir.Cells["MusteriNo"].Value.ToString();
            txtAdSoyad.Text = satir.Cells["AdSoyad"].Value.ToString();
            maskedTelefon.Text = satir.Cells["Telefon"].Value.ToString();
            txtYas.Text = satir.Cells["Yas"].Value.ToString();
            txtBakiye.Text = satir.Cells["MusteriBakiye"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int MusteriId = Convert.ToInt32(txtNo.Text);
            var sil = baglanti.Müşteriler.Where(x => x.MusteriNo == MusteriId).FirstOrDefault();
            baglanti.Müşteriler.Remove(sil);
            baglanti.SaveChanges();

            MessageBox.Show("Başarıyla Silindi.");
            VeriGoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Müşteriler.Where(x => x.AdSoyad.ToLower().Contains(txtAdSoyad.Text) || x.AdSoyad.ToUpper().Contains(txtAdSoyad.Text)).ToList();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfagit = new AnaSayfa();
            anasayfagit.Show();
            this.Hide();

               
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
