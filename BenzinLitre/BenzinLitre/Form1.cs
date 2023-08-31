using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenzinLitre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //COÖBOBOX YAKIT TİPİ
            comboBoxGYakıtTipi.Items.Add("Benzin");
            comboBoxGYakıtTipi.Items.Add("Motorin");
            comboBoxGYakıtTipi.Items.Add("Gaz");

            comboBoxCYakıtTipi.Items.Add("Benzin");
            comboBoxCYakıtTipi.Items.Add("Motorin");
            comboBoxCYakıtTipi.Items.Add("Gaz");


            //LİSTVİEW KOLONLARI

            listViewStokCikis.Columns.Add("Yakıt Tipi");
            listViewStokCikis.Columns.Add("Kategori");
            listViewStokCikis.Columns.Add("Birim Fiyat");
            listViewStokCikis.Columns.Add("Miktar");
            listViewStokCikis.Columns.Add("Tutar");


            listViewStokGiris.Columns.Add("Yakıt Tipi");
            listViewStokGiris.Columns.Add("Kategori");
            listViewStokGiris.Columns.Add("Birim Fiyat");
            listViewStokGiris.Columns.Add("Miktar");
            listViewStokGiris.Columns.Add("Tutar");

            //TEXTBOX TANIMLARI

          
            textBoxToplamBenzinMiktar.Text = Convert.ToString(benzinMiktar);
            textBoxToplamBenzinTutar.Text = Convert.ToString(benzinTutar);
            textBoxToplamMotorinMiktar.Text = Convert.ToString(motorinMiktar);
            textBoxToplamMotorinTutar.Text = Convert.ToString(motorinTutar);
            textBoxToplamGazMiktar.Text = Convert.ToString(gazMiktar);
            textBoxToplamGazTutar.Text = Convert.ToString(gazTutar);

            textBoxToplamMiktar.Text = Convert.ToString(toplamMiktar);
            textBoxToplamTutar.Text = Convert.ToString(toplamTutar);






            //COMBOBOX Kategori


            if (comboBoxGYakıtTipi.Text=="Benzin")
            {
                comboBoxGKategori.Items.Clear();
                comboBoxGKategori.Items.AddRange(benzinTipArray);

            }

            else if (comboBoxGYakıtTipi.Text=="Motorin")


            {

                comboBoxGKategori.Items.Clear();
                comboBoxGKategori.Items.AddRange(motorinTipArray);


            }

            else if (comboBoxGYakıtTipi.Text=="Gaz")
            {
                comboBoxGKategori.Items.Clear();
                comboBoxGKategori.Items.AddRange(gazTipArray);
            }

        }

        int benzinMiktar = 0;
        int benzinTutar = 0;
        int motorinMiktar = 0;
        int motorinTutar = 0;
        int gazMiktar = 0;
        int gazTutar = 0;
        int toplamMiktar = 0;
        int toplamTutar = 0;


        //katergori array

        String[] benzinTipArray = { "95", "97", "98" };
        String[] motorinTipArray = { "VNORMAL", "VPOWER" };
        String[] gazTipArray = { "LPG", "CNG" };

        private void comboBoxGYakıtTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

            //katergori array

            String[] benzinTipArray = { "95", "97", "98" };
            String[] motorinTipArray = { "VNORMAL", "VPOWER" };
            String[] gazTipArray = { "LPG", "CNG" };


            //COMBOBOX Kategori


            if (comboBoxGYakıtTipi.Text == "Benzin")
            {
                comboBoxGKategori.Items.Clear();
                comboBoxGKategori.Items.AddRange(benzinTipArray);

            }

            else if (comboBoxGYakıtTipi.Text == "Motorin")


            {

                comboBoxGKategori.Items.Clear();
                comboBoxGKategori.Items.AddRange(motorinTipArray);


            }

            else if (comboBoxGYakıtTipi.Text == "Gaz")
            {
                comboBoxGKategori.Items.Clear();
                comboBoxGKategori.Items.AddRange(gazTipArray);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //kontrol 0: Mutlaka veri girişi ve gereksiz veri oluşumunu engelleme
             if(comboBoxGYakıtTipi.Text==""||comboBoxGKategori.Text==null||textBoxGLitre.Text==""||textBoxGBirimFiyat==null)

            {
                MessageBox.Show("Geçerli veri giriniz");
            }

             else if(toplamMiktar>=50000)

            {
                MessageBox.Show("Tüm stok alanları dolmuştur");
            }
             else
            { 

            string YakıtTipi, Kategori, BirimFiyatString, LitreString, GirisTutarString;
            int girisLitre, girisbirimFiyat, girisTutar;


            YakıtTipi = ("" + comboBoxGYakıtTipi.Text);
            Kategori = ("" + comboBoxGKategori.Text);
            BirimFiyatString = ("" + textBoxGBirimFiyat.Text);
            LitreString = ("" + textBoxGLitre.Text);

            girisLitre = Convert.ToInt32(textBoxGLitre.Text);
            girisbirimFiyat = Convert.ToInt32(textBoxGBirimFiyat.Text);

                if(toplamMiktar+girisLitre>=50000)

                {
                    MessageBox.Show("Tüm stok alanları dolmuştur");
                }

                else

                { 

            girisTutar = girisLitre * girisbirimFiyat;
            GirisTutarString = Convert.ToString(girisTutar);

            toplamMiktar =toplamMiktar + girisLitre;
            toplamTutar =toplamTutar + girisTutar;

            textBoxToplamMiktar.Text = toplamMiktar.ToString();
             textBoxToplamTutar.Text = toplamTutar.ToString();

            string[] benzinLitreArrayList = { YakıtTipi, Kategori, BirimFiyatString, LitreString, GirisTutarString };
            ListViewItem listViewStokGirisView = new ListViewItem(benzinLitreArrayList);
            listViewStokGiris.Items.Add(listViewStokGirisView);


            if(YakıtTipi=="Benzin")

            {
                benzinMiktar = benzinMiktar + girisLitre;
                benzinTutar = benzinTutar + girisTutar;
                textBoxToplamBenzinMiktar.Text = Convert.ToString(benzinMiktar);
                textBoxToplamBenzinTutar.Text = Convert.ToString(benzinTutar);

            }

            else if (YakıtTipi=="Motorin")

            {
                motorinMiktar = motorinMiktar + girisLitre;
                motorinTutar = motorinTutar + girisTutar;
                textBoxToplamMotorinMiktar.Text = Convert.ToString(motorinMiktar);
                textBoxToplamMotorinTutar.Text = Convert.ToString(motorinTutar);

            }
               else if (YakıtTipi=="Gaz")

                {
                gazMiktar =gazMiktar + girisLitre;
                gazTutar = gazTutar + girisTutar;
                textBoxToplamGazMiktar.Text = Convert.ToString(gazMiktar);
                textBoxToplamGazTutar.Text = Convert.ToString(gazTutar);

                }


                    labelSonuc.Text = textBoxGLitre.Text + " lt " + comboBoxGYakıtTipi.Text + " Giriş Yapıldı ";

                }

            }


        }

        private void comboBoxCYakıtTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //katergori array

            String[] benzinTipArray = { "95", "97", "98" };
            String[] motorinTipArray = { "VNORMAL", "VPOWER" };
            String[] gazTipArray = { "LPG", "CNG" };


            //COMBOBOX Kategori


            if (comboBoxCYakıtTipi.Text == "Benzin")
            {
               
                comboBoxCKategori.Items.Clear();
                comboBoxCKategori.Items.AddRange(benzinTipArray);

            }

            else if (comboBoxCYakıtTipi.Text == "Motorin")


            {

                comboBoxCKategori.Items.Clear();
                comboBoxCKategori.Items.AddRange(motorinTipArray);


            }

            else if (comboBoxCYakıtTipi.Text == "Gaz")
            {
                comboBoxCKategori.Items.Clear();
                comboBoxCKategori.Items.AddRange(gazTipArray);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string YakıtTipi, Kategori, BirimFiyatString, LitreString, CikisTutarString;
            int cikisLitre, cikisbirimFiyat, cikisTutar;


            YakıtTipi = ("" + comboBoxCYakıtTipi.Text);
            Kategori = ("" + comboBoxCKategori.Text);
            BirimFiyatString = ("" + textBoxCBirimFiyat.Text);
            LitreString = ("" + textBoxCLitre.Text);

            cikisLitre = Convert.ToInt32(textBoxCLitre.Text);
            cikisbirimFiyat = Convert.ToInt32(textBoxCBirimFiyat.Text);

            if(toplamMiktar-cikisLitre<=0)
            {

                MessageBox.Show("Stokta olmadığı için çıkış yapamazsınız");

            }

            else
            { 


            cikisTutar = cikisLitre * cikisbirimFiyat;
            CikisTutarString = Convert.ToString(cikisTutar);

            toplamMiktar = toplamMiktar - cikisLitre;
            toplamTutar = toplamTutar - cikisTutar;

            textBoxToplamMiktar.Text = toplamMiktar.ToString();
            textBoxToplamTutar.Text = toplamTutar.ToString();

            string[] benzinLitrecikisArrayList = { YakıtTipi, Kategori, BirimFiyatString, LitreString, CikisTutarString };
            ListViewItem listViewStokCikisView = new ListViewItem(benzinLitrecikisArrayList);
            listViewStokCikis.Items.Add(listViewStokCikisView);


            if (YakıtTipi == "Benzin")

            {
                benzinMiktar = benzinMiktar -cikisLitre;
                benzinTutar = benzinTutar -cikisTutar;
                textBoxToplamBenzinMiktar.Text = Convert.ToString(benzinMiktar);
                textBoxToplamBenzinTutar.Text = Convert.ToString(benzinTutar);

            }

            else if (YakıtTipi == "Motorin")

            {
                motorinMiktar = motorinMiktar -cikisLitre;
                motorinTutar = motorinTutar - cikisTutar;
                textBoxToplamMotorinMiktar.Text = Convert.ToString(motorinMiktar);
                textBoxToplamMotorinTutar.Text = Convert.ToString(motorinTutar);

            }
            else if (YakıtTipi == "Gaz")

            {
                gazMiktar = gazMiktar -cikisLitre;
                gazTutar = gazTutar -cikisTutar;
                textBoxToplamGazMiktar.Text = Convert.ToString(gazMiktar);
                textBoxToplamGazTutar.Text = Convert.ToString(gazTutar);

            }

                labelSonuc.Text = textBoxCLitre.Text + " lt " + comboBoxCYakıtTipi.Text + " Çıkış Yapıldı ";

            }

        }

        private void textBoxGBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxGLitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxCBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxCLitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
