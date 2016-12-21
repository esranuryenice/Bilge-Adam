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
        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Abone abone = new Abone();
            abone.adSoyad = textBoxAdSoyad.Text;
            abone.aboneTipi = radioButtonEv.Checked == false ? true : false; //abone.aboneTipi = radioButtonEv.Checked == true ? "Ev" : "Kurum"; (string aboneTipi)
            abone.oncekiIndex = int.Parse(textBoxOnceki.Text);
            abone.sonrakiIndex = int.Parse(textBoxSonraki.Text);

            listBoxOdeme.Items.Add(abone);           
                       
            textBoxAdSoyad.Clear();
            textBoxAdSoyad.Focus();
            textBoxOnceki.Clear();
            textBoxSonraki.Clear();
        }

        private void listBoxOdeme_DoubleClick(object sender, EventArgs e)
        {
            Abone abone = (Abone)listBoxOdeme.SelectedItem;
            double odeme = abone.OdemeHesapla(abone.oncekiIndex, abone.sonrakiIndex, abone.aboneTipi);

            DialogResult result = MessageBox.Show("Borcunuz: " + odeme + "\nÖdeme yapacak mısınız?", "Onay Ekranı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                listBoxOdenen.Items.Add(listBoxOdeme.SelectedItem.ToString());                
                listBoxOdeme.Items.RemoveAt(listBoxOdeme.SelectedIndex);
            }
        }
    }
}
