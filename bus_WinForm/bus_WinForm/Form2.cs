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
        
        public string gender;
        public int seatNumber = 100;
        
        public static string[] chosenSeatList = new string[48]; //static yaptım oldu
        public static string[] genderArray = new string[48];

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (seatNumber % 2 == 0) //çift
            {
                int previous = seatNumber - 1;
                if (chosenSeatList[previous] != null)
                {
                    genderArray[seatNumber] = gender;

                    if (genderArray[previous] == genderArray[seatNumber])
                    {
                        chosenSeatList[seatNumber] = textBoxNameSurname.Text;
                    }
                    else
                    {
                        MessageBox.Show("You cannot choose this seat due to your gender. Please choose another one.");
                        ((Control)sender).BackColor = Color.FromArgb(135, 144, 180);
                    }
                }
                else
                {
                    chosenSeatList[seatNumber] = textBoxNameSurname.Text;
                    genderArray[seatNumber] = gender;

                }
            }
            else //tek 
            {
                int next = seatNumber + 1;
                if (chosenSeatList[next] != null)
                {
                    genderArray[seatNumber] = gender;

                    if (genderArray[next] == genderArray[seatNumber])
                    {
                        chosenSeatList[seatNumber] = textBoxNameSurname.Text;
                    }
                    else
                    {
                        MessageBox.Show("You cannot choose this seat due to your gender. Please choose another one.");
                        ((Control)sender).BackColor = Color.FromArgb(135, 144, 180);
                    }
                }
                else
                {
                    chosenSeatList[seatNumber] = textBoxNameSurname.Text;
                    genderArray[seatNumber] = gender;

                }
            }
            this.Hide();       

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (chosenSeatList[seatNumber] != null)
            {
                textBoxNameSurname.Text = chosenSeatList[seatNumber] + "  -> This seat is taken.";

            }
        }

        

        
    }
}
