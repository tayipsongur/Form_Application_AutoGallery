
namespace Galeri_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(662, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri Yaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Müşteri Bakiye:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(119, 117);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(144, 20);
            this.txtNo.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(119, 230);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(144, 20);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(119, 426);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(144, 20);
            this.txtYas.TabIndex = 9;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(119, 526);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(144, 20);
            this.txtBakiye.TabIndex = 10;
            // 
            // btnListele
            // 
            this.btnListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListele.BackgroundImage")));
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListele.Location = new System.Drawing.Point(1327, 230);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(70, 70);
            this.btnListele.TabIndex = 11;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Location = new System.Drawing.Point(21, 605);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(66, 52);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(145, 605);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(66, 52);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(21, 692);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(59, 52);
            this.btnSil.TabIndex = 14;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Location = new System.Drawing.Point(119, 333);
            this.maskedTelefon.Mask = "(999) 000-0000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(144, 20);
            this.maskedTelefon.TabIndex = 15;
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArama.BackgroundImage")));
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArama.Location = new System.Drawing.Point(145, 692);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(62, 52);
            this.btnArama.TabIndex = 16;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(0, -2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(61, 45);
            this.btnGeri.TabIndex = 17;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCıkıs.BackgroundImage")));
            this.btnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCıkıs.Location = new System.Drawing.Point(61, -2);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(61, 45);
            this.btnCıkıs.TabIndex = 18;
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1397, 836);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.maskedTelefon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

