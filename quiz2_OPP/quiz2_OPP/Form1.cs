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

        List<Abone> aboneList = new List<Abone>();
        Abone abone = new Abone();
        private void buttonEkle_Click(object sender, EventArgs e)
        {

            abone.adSoyad = textBoxAdSoyad.Text;
            abone.aboneTipi = radioButtonEv.Checked == false ? true : false;
            abone.oncekiIndex = int.Parse(textBoxOnceki.Text);
            abone.sonrakiIndex = int.Parse(textBoxSonraki.Text);

            aboneList.Add(abone);
            
            
            if (abone.aboneTipi == false)
            {
                abone.ucret = 0.3 * (abone.sonrakiIndex - abone.oncekiIndex);
            }
            else if(abone.aboneTipi == true)
            {
                abone.ucret = 0.5 * (abone.sonrakiIndex - abone.oncekiIndex);
            }

            listBoxOdeme.Items.Add(abone.adSoyad + " " + abone.ucret);

            textBoxAdSoyad.Clear();
            textBoxAdSoyad.Focus();
            textBoxOnceki.Clear();
            textBoxSonraki.Clear();
        }

        private void listBoxOdeme_DoubleClick(object sender, EventArgs e)
        {          
            
            DialogResult result = MessageBox.Show("Ödeme yapacak mısınız?", "Onay Ekranı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                listBoxOdenen.Items.Add(listBoxOdeme.SelectedItem.ToString());                
                listBoxOdeme.Items.RemoveAt(listBoxOdeme.SelectedIndex);
            }
        }
    }
}
