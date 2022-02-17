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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 müsterigit = new Form1();
            müsterigit.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araclar aracgit = new Araclar();
            aracgit.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subeler subegit = new Subeler();
            subegit.ShowDialog();
            this.Hide();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlar raporagit = new Raporlar();
            raporagit.Show();
            this.Hide();
        }
    }
}
