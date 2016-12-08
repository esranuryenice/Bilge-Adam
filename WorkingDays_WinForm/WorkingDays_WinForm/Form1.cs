using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingDays_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            float hours = Convert.ToSingle(inputHourTextBox.Text);
            float age = Convert.ToSingle(ageTextBox.Text);
            float oran;

            if (hours <= 24)
            {

                oran = hours / 24;

                float years;

                years = oran * age;

                resultLabel.Text = "kaç yıl uyudun : " + years;
            }
            else
            {
                resultLabel.Text = "wrong entry !";
                inputHourTextBox.Clear();
            }
           

            

           

           

                                   
            
            //float hours = Convert.ToSingle(inputTextBox.Text);

            //if (hours <= 24)
            //{
            //    float days = 10000 / hours;
            //    float months = days / 30;
            //    float years = days / 365;

            //    //MessageBox.Show("Day : " + days + "\nMonth : " + months + "\nYear : " + years);

            //    resultLabel.Text = "Day : " + days + "\nMonth : " + months + "\nYear : " + years;
            //}
            //else
            //{
            //    resultLabel.Text = "Don't be ridiculous !";
            //    inputTextBox.Clear();
            //}
           

            
        }
    }
}
