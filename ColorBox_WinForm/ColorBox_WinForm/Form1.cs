using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorBox_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int red, green, blue;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;

                btn.BackColor = CreateRandomColor();

                
                btn.Click += ButtonClick;

                if (i == 9)
                {
                    btn.Left = 0;
                }

                if (i < 10)
                {
                    btn.Top = btn.Height;
                    btn.Left = btn.Width * i;
                    
                }
                if( i >= 10 && i < 20)
                {
                    btn.Left = btn.Width * (i - 10);
                    btn.Top = btn.Height * 2;
                }

                this.Controls.Add(btn);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button choosenButton = sender as Button;
            this.BackColor = choosenButton.BackColor;
        }

        private Color CreateRandomColor()
        {
            red = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
            green = rnd.Next(0, 256);

            Color randomColor = Color.FromArgb(red, green, blue);

            return randomColor;
        }

    }
}

//mail@yavuzgedik.com linnk paylaş