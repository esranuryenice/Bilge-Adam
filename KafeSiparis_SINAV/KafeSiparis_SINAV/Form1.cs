using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparis_SINAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] yemekler = { "Kuru Fasülye", "Tavuklu Pilav", "Kaşarlı Tost", "Lazanya" };
        private string[] icecekler = { "Su", "Kola", "Limonata", "Çay", "Kahve" };

        private void Button_Click(object sender, EventArgs e)
        {

            listBoxSiparisler.Items.Clear();
            panelYemekSec.Visible = true;

            Button secilenMasa = sender as Button;
            labelMasaNo.Text = secilenMasa.Text;

            if (masalar[int.Parse(secilenMasa.Text)] != null)
            {
                foreach (var item in masalar[int.Parse(secilenMasa.Text)].siparisler)
                {
                    listBoxSiparisler.Items.Add(item);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region buttonOlusturma

            panelYemekSec.Visible = false;
            comboBoxYemek.Items.AddRange(yemekler);
            comboBoxIcecek.Items.AddRange(icecekler);

            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Click += Button_Click;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Text = counter + "";
                    btn.Left = (btn.Width * j * 2);
                    btn.Top = (btn.Height * i * 2);
                    panelMasalar.Controls.Add(btn);
                    counter++;
                }
            }

            #endregion

        }

        Masa m = new Masa();

        Masa[] masalar = new Masa[15];

        private void buttonSiparisVer_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            m = new Masa();
            m.siparisler = new List<Siparis>();

            if (comboBoxYemek.SelectedItem != null)
            {
                s.siparisAdi = comboBoxYemek.SelectedItem.ToString();
                s.adet = int.Parse(numericUpDownYemek.Value.ToString());
                s.toplamUcret = s.adet * s.ucret;
                m.siparisler.Add(s);



            }

            if (comboBoxIcecek.SelectedItem != null)
            {
                s = new Siparis();
                s.siparisAdi = comboBoxIcecek.SelectedItem.ToString();
                s.adet = int.Parse(numericUpDownIcecek.Value.ToString());
                s.toplamUcret = s.adet * s.ucret;
                m.siparisler.Add(s);

            }

            foreach (var item in m.siparisler)
            {
                listBoxSiparisler.Items.Add(item);
            }

            Masa _masa = new Masa();

            if (masalar[int.Parse(labelMasaNo.Text)] != null)
            {
                _masa = masalar[int.Parse(labelMasaNo.Text)];
                foreach (var item in m.siparisler)
                {
                    _masa.siparisler.Add(item);
                }
            }
            else
            {
                _masa = m;
                masalar[int.Parse(labelMasaNo.Text)] = _masa;
            }




        }

        private void buttonOde_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSiparisler_DoubleClick(object sender, EventArgs e)
        {
            Siparis s = (Siparis)listBoxSiparisler.SelectedItem;
            DialogResult result = MessageBox.Show("Tutar: " + s.toplamUcret + "\nÖdeme Yapmak İstiyor Musunuz?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                s.toplamUcret = 0;
                
            }
        }
    }
}
