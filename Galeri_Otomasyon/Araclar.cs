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
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }

        GaleriEntities1 baglanti = new GaleriEntities1();

        public void VeriGoruntule()
        {

            dataGridView1.DataSource = baglanti.Araçlar.ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Araçlar.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Araçlar ekle = new Araçlar();
            ekle.AracFiyat = Convert.ToDecimal(txtAracFiyat.Text);
            ekle.AracAdet = Convert.ToInt32(txtAracAdet.Text);
            ekle.AracMarka = txtAracMarka.Text;
            ekle.AracModel = txtAracModel.Text;
            ekle.AracYıl = Convert.ToInt32(txtAracYil.Text);
            ekle.AracOzellik = txtAracOzellik.Text;
            ekle.AracModel = txtAracModel.Text;
            ekle.AracMotor = txtAracMotor.Text;
            ekle.AracPaket = txtAracPaket.Text;
            ekle.AracRenk = txtAracRenk.Text;
            ekle.SubeNo = Convert.ToInt32(comboBox1.Text);

            baglanti.Araçlar.Add(ekle);
            baglanti.SaveChanges();
            VeriGoruntule();
            MessageBox.Show("Araç Başarıyla Eklendi");

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

            txtAracNo.Text = satir.Cells["AracNo"].Value.ToString();
            txtAracFiyat.Text = satir.Cells["AracFiyat"].Value.ToString();
            txtAracAdet.Text = satir.Cells["AracAdet"].Value.ToString();
            txtAracMarka.Text = satir.Cells["AracMarka"].Value.ToString();
            txtAracModel.Text = satir.Cells["AracModel"].Value.ToString();
            txtAracYil.Text = satir.Cells["AracYıl"].Value.ToString();
            txtAracOzellik.Text = satir.Cells["AracOzellik"].Value.ToString();
            txtAracMotor.Text = satir.Cells["AracMotor"].Value.ToString();
            txtAracPaket.Text = satir.Cells["AracPaket"].Value.ToString();
            txtAracRenk.Text = satir.Cells["AracRenk"].Value.ToString();
            comboBox1.Text = satir.Cells["SubeNo"].Value.ToString();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int aracno = Convert.ToInt32(txtAracNo.Text);

            var guncelle = baglanti.Araçlar.Where(x => x.AracNo == aracno).FirstOrDefault();
            guncelle.AracFiyat = Convert.ToDecimal(txtAracFiyat.Text);
            guncelle.AracAdet = Convert.ToInt32(txtAracAdet.Text);
            guncelle.AracMarka = txtAracMarka.Text;
            guncelle.AracModel = txtAracModel.Text;
            guncelle.AracYıl = Convert.ToInt32(txtAracYil.Text);
            guncelle.AracOzellik = txtAracOzellik.Text;
            guncelle.AracModel = txtAracModel.Text;
            guncelle.AracMotor = txtAracMotor.Text;
            guncelle.AracPaket = txtAracPaket.Text;
            guncelle.AracRenk = txtAracRenk.Text;
            guncelle.SubeNo = Convert.ToInt32(comboBox1.Text);

            baglanti.SaveChanges();
            VeriGoruntule();
            MessageBox.Show("Güncelleme İşlemi Başarılı");

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
            int aracno = Convert.ToInt32(txtAracNo.Text);

            var sil = baglanti.Araçlar.Where(x => x.AracNo == aracno).FirstOrDefault();

            baglanti.Araçlar.Remove(sil);

            baglanti.SaveChanges();

            MessageBox.Show("Silme İşlemi Başarılı");
            VeriGoruntule();

        }
     

        private void Araclar_Load(object sender, EventArgs e)
        {            
            comboBox1.DataSource = baglanti.Müşteriler.ToList();
            comboBox1.ValueMember = "MusteriNo";
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Araçlar.Where(x => x.AracMarka.ToLower().Contains(txtAracMarka.Text) || x.AracMarka.ToUpper().Contains(txtAracMarka.Text)).ToList();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeridön_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfagit = new AnaSayfa();
            anasayfagit.ShowDialog();
            this.Hide();
        }
    }
}
