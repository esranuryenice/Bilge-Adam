using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_Form
{
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent(); //F12 go to definition
        }

        private void firstForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!!!");
        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name Surname: " + NameSurnameTextBox.Text + "\nPassword: " + PasswordTextBox.Text);
        }
    }
}
