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
    public partial class Subeler : Form
    {
        public Subeler()
        {
            InitializeComponent();
        }

        GaleriEntities1 baglanti = new GaleriEntities1();

        public void VeriGoruntule()
        {
            dataGridView1.DataSource = baglanti.Şubeler.ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Şubeler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Şubeler subeekle = new Şubeler();

            subeekle.SubeAdi = txtSubeAd.Text;
            subeekle.CalisanSayisi = Convert.ToInt32(txtCalisanSayi.Text) ;
            subeekle.SubeCiro = Convert.ToInt32(txtSubeCiro.Text);
            subeekle.MusteriNo = Convert.ToInt32(comboBox1.Text);

            baglanti.Şubeler.Add(subeekle);
            baglanti.SaveChanges();
            VeriGoruntule();

            MessageBox.Show("Müşteri Başarıyla Eklendi");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
              
            }

        }

        private void Subeler_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baglanti.Şubeler.ToList();
            comboBox1.ValueMember = "SubeNo";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int subeNo = Convert.ToInt32(txtSubeNo.Text);

            var guncelle = baglanti.Şubeler.Where(x => x.SubeNo == subeNo).FirstOrDefault();

            guncelle.SubeAdi = txtSubeAd.Text;
            guncelle.CalisanSayisi = Convert.ToInt32(txtCalisanSayi.Text);
            guncelle.SubeCiro = Convert.ToDecimal(txtSubeCiro.Text);
            guncelle.MusteriNo = Convert.ToInt32(comboBox1.Text);

            baglanti.SaveChanges();

            MessageBox.Show("Güncelleme İşlemi Başarılı");
            VeriGoruntule();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int subeNo = Convert.ToInt32(txtSubeNo.Text);

            var sil = baglanti.Şubeler.Where(x => x.SubeNo == subeNo).FirstOrDefault();
            baglanti.Şubeler.Remove(sil);

            baglanti.SaveChanges();
            MessageBox.Show("Şube Silindi");
            VeriGoruntule();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

    
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtSubeNo.Text = satir.Cells["SubeNo"].Value.ToString();
            txtSubeAd.Text = satir.Cells["SubeAdi"].Value.ToString();
            txtCalisanSayi.Text = satir.Cells["CalisanSayisi"].Value.ToString();
            txtSubeCiro.Text = satir.Cells["SubeCiro"].Value.ToString();
            comboBox1.Text = satir.Cells["MusteriNo"].Value.ToString();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Şubeler.Where(x => x.SubeAdi.ToLower().Contains(txtSubeAd.Text) || x.SubeAdi.ToUpper().Contains(txtSubeAd.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfadön = new AnaSayfa();
            anasayfadön.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
