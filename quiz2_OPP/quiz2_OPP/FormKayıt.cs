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
    public partial class FormKayıt : Form
    {
        public FormKayıt()
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

            listBoxAboneler.Items.Add(abone);            

            textBoxAdSoyad.Clear();
            textBoxAdSoyad.Focus();
            textBoxOnceki.Clear();
            textBoxSonraki.Clear();
        }

        

        private void listBoxAboneler_DoubleClick(object sender, EventArgs e)
        {
            Abone abone = (Abone)listBoxAboneler.SelectedItem;            

            Form1 form1 = new Form1(abone);

            form1.Show();

            
        }
        
        private void listBoxOdenen_DoubleClick(object sender, EventArgs e)
        {           

            Abone abone = (Abone)listBoxOdenen.SelectedItem;

            Form2 form2 = new Form2(abone);   
                     
            form2.Show();


        }
    }
}
