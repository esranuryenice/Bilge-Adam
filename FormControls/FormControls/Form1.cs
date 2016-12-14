using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(textBox1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //textBoxAge.Text = DateTime.Now.ToString();
            //textBoxAge.Text = dateTimePicker1.Value.ToString();

            DateTime birthday = dateTimePicker1.Value;
            DateTime now = DateTime.Now;

            int age = now.Year - birthday.Year;

            //textBoxAge.Text = ((now - birthday).TotalDays).ToString();

            textBoxAge.Text = age.ToString();


        }
    }
}
