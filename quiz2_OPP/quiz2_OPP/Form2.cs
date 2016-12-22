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
    public partial class Form2 : Form
    {
        public Form2(Abone aboneForm2)
        {
            InitializeComponent();
            textBoxAdSoyad.Text = aboneForm2.adSoyad;
            //textBoxOdeme.Text =

                //aboneForm2.OdemeHesapla(aboneForm2.oncekiIndex, aboneForm2.sonrakiIndex, aboneForm2.aboneTipi).ToString();


        }



    }
}
