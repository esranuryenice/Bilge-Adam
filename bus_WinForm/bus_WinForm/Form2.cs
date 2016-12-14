using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }


        public int seatNumber = 100;
        
        public static string[] chosenSeatList = new string[48]; //static yaptım oldu

        private void buttonSave_Click(object sender, EventArgs e)
        {                        
            chosenSeatList[seatNumber] = textBoxNameSurname.Text;
            this.Hide();       

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxNameSurname.Text = chosenSeatList[seatNumber];
        }
    }
}
