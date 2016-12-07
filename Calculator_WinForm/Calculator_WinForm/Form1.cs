using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ilksayi, ikincisayi;
        private void ButtonClick(object sender, EventArgs e)
        {
            Button remzi = sender as Button;
            //Button ramiz = (Button)sender;

            MessageBox.Show(remzi.Text + " e bastın.");

            ilksayi = Convert.ToInt32(remzi.Text);
            ikincisayi = Convert.ToInt32(remzi.Text);

            //label1.Text = remzi.Text;
            label1.Text = ilksayi + ikincisayi + "";

            //asd.Text = 
        }
    }
}
