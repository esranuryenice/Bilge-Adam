using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEkrani_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonKayet_Click(object sender, EventArgs e)
        {
            
            if (textBoxAdSoyad.Text != "")
            {
                listBox1.Items.Add(textBoxAdSoyad.Text);
            }
            textBoxAdSoyad.Clear();
            textBoxAdSoyad.Focus();
            textBoxAdSoyad.ForeColor = Color.Purple;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istiyor musun?", "Onay Ekranı", MessageBoxButtons.YesNoCancel);

            try
            {
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else if (result == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {

                //ne  yazmalı
            }
            
           
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAdSoyad.Focus();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hepsi silinecek", "Onay Ekranı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                listBox1.Items.Clear();
            }
           
        }
    }
}
