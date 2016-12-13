using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakePaint_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        ColorDialog colorDialog = new ColorDialog();
        int startX, startY;
        int width = 2;
        bool draw;

       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            Pen p = new Pen(colorDialog.Color, width); //color ve width ekle

            Point point1 = new Point(startX, startY);
            Point point2 = new Point(e.X, e.Y);

            if (draw == true)
            {
                g.DrawLine(p, point1, point2);
                startX = e.X;
                startY = e.Y;
                               
            }

        }

        private void chooseWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            width = int.Parse(chooseWidth.SelectedItem.ToString());
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            startX = e.X;
            startY = e.Y;
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }


    }
}
