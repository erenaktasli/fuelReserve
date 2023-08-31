
namespace BenzinLitre
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxGBirimFiyat = new System.Windows.Forms.TextBox();
            this.textBoxGLitre = new System.Windows.Forms.TextBox();
            this.comboBoxGYakıtTipi = new System.Windows.Forms.ComboBox();
            this.comboBoxGKategori = new System.Windows.Forms.ComboBox();
            this.listViewStokGiris = new System.Windows.Forms.ListView();
            this.listViewStokCikis = new System.Windows.Forms.ListView();
            this.comboBoxCKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxCYakıtTipi = new System.Windows.Forms.ComboBox();
            this.textBoxCLitre = new System.Windows.Forms.TextBox();
            this.textBoxCBirimFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxToplamMotorinMiktar = new System.Windows.Forms.TextBox();
            this.textBoxToplamBenzinMiktar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxToplamMiktar = new System.Windows.Forms.TextBox();
            this.textBoxToplamGazMiktar = new System.Windows.Forms.TextBox();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.textBoxToplamGazTutar = new System.Windows.Forms.TextBox();
            this.textBoxToplamMotorinTutar = new System.Windows.Forms.TextBox();
            this.textBoxToplamBenzinTutar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGBirimFiyat
            // 
            this.textBoxGBirimFiyat.Location = new System.Drawing.Point(424, 33);
            this.textBoxGBirimFiyat.Name = "textBoxGBirimFiyat";
            this.textBoxGBirimFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBoxGBirimFiyat.TabIndex = 0;
            this.textBoxGBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGBirimFiyat_KeyPress);
            // 
            // textBoxGLitre
            // 
            this.textBoxGLitre.Location = new System.Drawing.Point(424, 60);
            this.textBoxGLitre.Name = "textBoxGLitre";
            this.textBoxGLitre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGLitre.TabIndex = 1;
            this.textBoxGLitre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGLitre_KeyPress);
            // 
            // comboBoxGYakıtTipi
            // 
            this.comboBoxGYakıtTipi.FormattingEnabled = true;
            this.comboBoxGYakıtTipi.Location = new System.Drawing.Point(158, 32);
            this.comboBoxGYakıtTipi.Name = "comboBoxGYakıtTipi";
            this.comboBoxGYakıtTipi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGYakıtTipi.TabIndex = 2;
            this.comboBoxGYakıtTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxGYakıtTipi_SelectedIndexChanged);
            // 
            // comboBoxGKategori
            // 
            this.comboBoxGKategori.FormattingEnabled = true;
            this.comboBoxGKategori.Location = new System.Drawing.Point(158, 59);
            this.comboBoxGKategori.Name = "comboBoxGKategori";
            this.comboBoxGKategori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGKategori.TabIndex = 3;
            // 
            // listViewStokGiris
            // 
            this.listViewStokGiris.HideSelection = false;
            this.listViewStokGiris.Location = new System.Drawing.Point(158, 96);
            this.listViewStokGiris.Name = "listViewStokGiris";
            this.listViewStokGiris.Size = new System.Drawing.Size(458, 68);
            this.listViewStokGiris.TabIndex = 4;
            this.listViewStokGiris.UseCompatibleStateImageBehavior = false;
            this.listViewStokGiris.View = System.Windows.Forms.View.Details;
            // 
            // listViewStokCikis
            // 
            this.listViewStokCikis.HideSelection = false;
            this.listViewStokCikis.Location = new System.Drawing.Point(158, 248);
            this.listViewStokCikis.Name = "listViewStokCikis";
            this.listViewStokCikis.Size = new System.Drawing.Size(458, 68);
            this.listViewStokCikis.TabIndex = 9;
            this.listViewStokCikis.UseCompatibleStateImageBehavior = false;
            this.listViewStokCikis.View = System.Windows.Forms.View.Details;
            // 
            // comboBoxCKategori
            // 
            this.comboBoxCKategori.FormattingEnabled = true;
            this.comboBoxCKategori.Location = new System.Drawing.Point(158, 211);
            this.comboBoxCKategori.Name = "comboBoxCKategori";
            this.comboBoxCKategori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCKategori.TabIndex = 8;
            // 
            // comboBoxCYakıtTipi
            // 
            this.comboBoxCYakıtTipi.FormattingEnabled = true;
            this.comboBoxCYakıtTipi.Location = new System.Drawing.Point(158, 184);
            this.comboBoxCYakıtTipi.Name = "comboBoxCYakıtTipi";
            this.comboBoxCYakıtTipi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCYakıtTipi.TabIndex = 7;
            this.comboBoxCYakıtTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxCYakıtTipi_SelectedIndexChanged);
            // 
            // textBoxCLitre
            // 
            this.textBoxCLitre.Location = new System.Drawing.Point(428, 212);
            this.textBoxCLitre.Name = "textBoxCLitre";
            this.textBoxCLitre.Size = new System.Drawing.Size(100, 20);
            this.textBoxCLitre.TabIndex = 6;
            this.textBoxCLitre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCLitre_KeyPress);
            // 
            // textBoxCBirimFiyat
            // 
            this.textBoxCBirimFiyat.Location = new System.Drawing.Point(428, 185);
            this.textBoxCBirimFiyat.Name = "textBoxCBirimFiyat";
            this.textBoxCBirimFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBoxCBirimFiyat.TabIndex = 5;
            this.textBoxCBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCBirimFiyat_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "YAKIT TİPİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "KATEGORİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "MİKTAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "BİRİM FİYAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(777, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "MOTORIN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(777, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "BENZIN";
            // 
            // textBoxToplamMotorinMiktar
            // 
            this.textBoxToplamMotorinMiktar.Location = new System.Drawing.Point(840, 86);
            this.textBoxToplamMotorinMiktar.Name = "textBoxToplamMotorinMiktar";
            this.textBoxToplamMotorinMiktar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamMotorinMiktar.TabIndex = 19;
            // 
            // textBoxToplamBenzinMiktar
            // 
            this.textBoxToplamBenzinMiktar.Location = new System.Drawing.Point(840, 59);
            this.textBoxToplamBenzinMiktar.Name = "textBoxToplamBenzinMiktar";
            this.textBoxToplamBenzinMiktar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamBenzinMiktar.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(777, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "TOPLAM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(777, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "GAZ";
            // 
            // textBoxToplamMiktar
            // 
            this.textBoxToplamMiktar.Location = new System.Drawing.Point(840, 152);
            this.textBoxToplamMiktar.Name = "textBoxToplamMiktar";
            this.textBoxToplamMiktar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamMiktar.TabIndex = 23;
            // 
            // textBoxToplamGazMiktar
            // 
            this.textBoxToplamGazMiktar.Location = new System.Drawing.Point(840, 125);
            this.textBoxToplamGazMiktar.Name = "textBoxToplamGazMiktar";
            this.textBoxToplamGazMiktar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamGazMiktar.TabIndex = 22;
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Location = new System.Drawing.Point(963, 151);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamTutar.TabIndex = 29;
            // 
            // textBoxToplamGazTutar
            // 
            this.textBoxToplamGazTutar.Location = new System.Drawing.Point(963, 124);
            this.textBoxToplamGazTutar.Name = "textBoxToplamGazTutar";
            this.textBoxToplamGazTutar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamGazTutar.TabIndex = 28;
            // 
            // textBoxToplamMotorinTutar
            // 
            this.textBoxToplamMotorinTutar.Location = new System.Drawing.Point(963, 85);
            this.textBoxToplamMotorinTutar.Name = "textBoxToplamMotorinTutar";
            this.textBoxToplamMotorinTutar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamMotorinTutar.TabIndex = 27;
            // 
            // textBoxToplamBenzinTutar
            // 
            this.textBoxToplamBenzinTutar.Location = new System.Drawing.Point(963, 58);
            this.textBoxToplamBenzinTutar.Name = "textBoxToplamBenzinTutar";
            this.textBoxToplamBenzinTutar.Size = new System.Drawing.Size(100, 20);
            this.textBoxToplamBenzinTutar.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(882, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "MIKTAR (LT)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(997, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "TUTAR (TL)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "KATEGORİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "YAKIT TİPİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "MİKTAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "BİRİM FİYAT";
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(818, 248);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(41, 13);
            this.labelSonuc.TabIndex = 38;
            this.labelSonuc.Text = "Sonuc:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxToplamTutar);
            this.Controls.Add(this.textBoxToplamGazTutar);
            this.Controls.Add(this.textBoxToplamMotorinTutar);
            this.Controls.Add(this.textBoxToplamBenzinTutar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxToplamMiktar);
            this.Controls.Add(this.textBoxToplamGazMiktar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxToplamMotorinMiktar);
            this.Controls.Add(this.textBoxToplamBenzinMiktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStokCikis);
            this.Controls.Add(this.comboBoxCKategori);
            this.Controls.Add(this.comboBoxCYakıtTipi);
            this.Controls.Add(this.textBoxCLitre);
            this.Controls.Add(this.textBoxCBirimFiyat);
            this.Controls.Add(this.listViewStokGiris);
            this.Controls.Add(this.comboBoxGKategori);
            this.Controls.Add(this.comboBoxGYakıtTipi);
            this.Controls.Add(this.textBoxGLitre);
            this.Controls.Add(this.textBoxGBirimFiyat);
            this.Name = "Form1";
            this.Text = "BenzinLitre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGBirimFiyat;
        private System.Windows.Forms.TextBox textBoxGLitre;
        private System.Windows.Forms.ComboBox comboBoxGYakıtTipi;
        private System.Windows.Forms.ComboBox comboBoxGKategori;
        private System.Windows.Forms.ListView listViewStokGiris;
        private System.Windows.Forms.ListView listViewStokCikis;
        private System.Windows.Forms.ComboBox comboBoxCKategori;
        private System.Windows.Forms.ComboBox comboBoxCYakıtTipi;
        private System.Windows.Forms.TextBox textBoxCLitre;
        private System.Windows.Forms.TextBox textBoxCBirimFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxToplamMotorinMiktar;
        private System.Windows.Forms.TextBox textBoxToplamBenzinMiktar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxToplamMiktar;
        private System.Windows.Forms.TextBox textBoxToplamGazMiktar;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.TextBox textBoxToplamGazTutar;
        private System.Windows.Forms.TextBox textBoxToplamMotorinTutar;
        private System.Windows.Forms.TextBox textBoxToplamBenzinTutar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSonuc;
    }
}

