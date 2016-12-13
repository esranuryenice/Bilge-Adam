using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passing_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); //form: Form2 tipinde nesne
            form.message = textBoxMessage.Text;
            form.Show();
            this.Hide();
        }
    }
}
