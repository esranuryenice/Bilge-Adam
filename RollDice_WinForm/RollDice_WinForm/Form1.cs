using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDice_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void RollDice()
        {
            Random rnd = new Random();
            int number1, number2;

            number1 = rnd.Next(1, 7);
            number2 = rnd.Next(1, 7);
            dice1.ImageLocation = System.IO.Path.GetFullPath("Pictures/" + number1 + ".png");
            dice2.ImageLocation = System.IO.Path.GetFullPath("Pictures/" + number2 + ".png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RollDice();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                RollDice();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            RollDice();
        }


    }
}
