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

        public string[] chosenSeatList = new string[48];  

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }


        public int seatNumber;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
          chosenSeatList[seatNumber] = textBoxNameSurname.Text;            
          
          this.Hide();       

        }

               
        
    }
}
