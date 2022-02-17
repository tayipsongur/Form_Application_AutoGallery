
namespace Galeri_Otomasyon
{
    partial class KullanıcıGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGiriş));
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.groupgiris = new System.Windows.Forms.GroupBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.groupkaydol = new System.Windows.Forms.GroupBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKulSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupgiris.SuspendLayout();
            this.groupkaydol.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAdi.Location = new System.Drawing.Point(123, 54);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(133, 26);
            this.txtKulAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(123, 132);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(133, 26);
            this.txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiriş.BackgroundImage")));
            this.btnGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.Location = new System.Drawing.Point(176, 166);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(67, 52);
            this.btnGiriş.TabIndex = 4;
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // groupgiris
            // 
            this.groupgiris.BackColor = System.Drawing.Color.Transparent;
            this.groupgiris.Controls.Add(this.label6);
            this.groupgiris.Controls.Add(this.label5);
            this.groupgiris.Controls.Add(this.btnUyeOl);
            this.groupgiris.Controls.Add(this.btnGiriş);
            this.groupgiris.Controls.Add(this.txtKulAdi);
            this.groupgiris.Controls.Add(this.label2);
            this.groupgiris.Controls.Add(this.txtSifre);
            this.groupgiris.Controls.Add(this.label1);
            this.groupgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupgiris.Location = new System.Drawing.Point(1, 0);
            this.groupgiris.Name = "groupgiris";
            this.groupgiris.Size = new System.Drawing.Size(262, 361);
            this.groupgiris.TabIndex = 5;
            this.groupgiris.TabStop = false;
            this.groupgiris.Text = "Giriş Yap";
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.BackgroundImage")));
            this.btnUyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.Location = new System.Drawing.Point(176, 258);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(67, 51);
            this.btnUyeOl.TabIndex = 5;
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // groupkaydol
            // 
            this.groupkaydol.Controls.Add(this.label7);
            this.groupkaydol.Controls.Add(this.btnKaydol);
            this.groupkaydol.Controls.Add(this.txtkullaniciad);
            this.groupkaydol.Controls.Add(this.label3);
            this.groupkaydol.Controls.Add(this.txtKulSifre);
            this.groupkaydol.Controls.Add(this.label4);
            this.groupkaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupkaydol.Location = new System.Drawing.Point(1121, 0);
            this.groupkaydol.Name = "groupkaydol";
            this.groupkaydol.Size = new System.Drawing.Size(281, 299);
            this.groupkaydol.TabIndex = 6;
            this.groupkaydol.TabStop = false;
            this.groupkaydol.Text = "Kaydol";
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydol.BackgroundImage")));
            this.btnKaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydol.Location = new System.Drawing.Point(191, 203);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(73, 51);
            this.btnKaydol.TabIndex = 4;
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciad.Location = new System.Drawing.Point(134, 69);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(133, 26);
            this.txtkullaniciad.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre:";
            // 
            // txtKulSifre
            // 
            this.txtKulSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulSifre.Location = new System.Drawing.Point(134, 151);
            this.txtKulSifre.Name = "txtKulSifre";
            this.txtKulSifre.PasswordChar = '*';
            this.txtKulSifre.Size = new System.Drawing.Size(133, 26);
            this.txtKulSifre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(169, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giriş Yap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(183, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kaydol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(204, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kaydol:";
            // 
            // KullanıcıGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1397, 836);
            this.Controls.Add(this.groupkaydol);
            this.Controls.Add(this.groupgiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullanıcıGiriş";
            this.Text = "KullanıcıGiriş";
            this.Load += new System.EventHandler(this.KullanıcıGiriş_Load);
            this.groupgiris.ResumeLayout(false);
            this.groupgiris.PerformLayout();
            this.groupkaydol.ResumeLayout(false);
            this.groupkaydol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.GroupBox groupgiris;
        private System.Windows.Forms.GroupBox groupkaydol;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKulSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}