using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SansTopu_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<int> numbers = new List<int>(6);
        int randomNumber;
        int counter = 0;
        int loop = 1;

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();
            loop = 1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loop > 15)
            {
                timer1.Interval = 400;
            }
            else
            {
                timer1.Interval = 100;
            }
            if (loop % 20 == 0) //loop == 10
            {
                timer1.Stop();
            }
            else
            {
                numbers.Clear();
                while (counter < 6)
                {
                    randomNumber = rnd.Next(1, 50);

                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        counter++;
                    }

                }

                numbers.Sort();

                label1.Text = numbers[0].ToString();
                label2.Text = numbers[1].ToString();
                label3.Text = numbers[2].ToString();
                label4.Text = numbers[3].ToString();
                label5.Text = numbers[4].ToString();
                label6.Text = numbers[5].ToString();

                counter = 0;
                loop++;
            }
            
        }
    }
}
