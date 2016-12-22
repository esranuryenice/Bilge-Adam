using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2_OPP
{
    public partial class Form1 : Form
    {
        public Form1(Abone aboneForm1)
        {
            InitializeComponent();
            textBoxIsimSoyisim.Text = aboneForm1.adSoyad;
            textBoxAboneTipi.Text = aboneForm1.aboneTipi == false ? "Ev" : "Kurum";
            textBoxOncekiSayac.Text = aboneForm1.oncekiIndex.ToString();
            textBoxSonrakiSayac.Text = aboneForm1.sonrakiIndex.ToString();
            textBoxGuncelBorc.Text = aboneForm1.OdemeHesapla(aboneForm1.oncekiIndex, aboneForm1.sonrakiIndex, textBoxAboneTipi.Text).ToString();
        }
        Abone abone = new Abone();

       

        public double guncelBorc;
        private void button1_Click(object sender, EventArgs e)
        {
            Abone abone = new Abone();

            abone.adSoyad = textBoxIsimSoyisim.Text;
            abone.aboneTipi = textBoxAboneTipi.Text == "Ev" ? false : true;
           

            double odeme = abone.OdemeHesapla(double.Parse(textBoxOncekiSayac.Text), double.Parse(textBoxSonrakiSayac.Text), textBoxAboneTipi.Text);

            guncelBorc = odeme;

            DialogResult result = MessageBox.Show("Borcunuz: " + odeme + "\nÖdeme yapacak mısınız?", "Onay Ekranı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                guncelBorc -= odeme;
                textBoxGuncelBorc.Text = guncelBorc.ToString();

                FormKayıt formKayıt = new FormKayıt();
                formKayıt.listBoxOdenen.Items.Add(abone);
            }
        }
    }
}
