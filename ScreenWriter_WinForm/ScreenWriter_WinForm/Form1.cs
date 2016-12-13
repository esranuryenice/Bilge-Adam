using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenWriter_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>() { "Esranur", "Çeyiz", "Halil", "Bengisu", "Hakan", "Yunus", "Yankı", "Atakan", "OzanK", "OzanA", "Aytekin", "İrfan", "Cemal", "Merve" };

        Random rnd = new Random();
        int loop = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, 14);
            string name = names[index];

            Graphics g = CreateGraphics();

            
            int x = rnd.Next(10, this.Width - 50);
            int y = rnd.Next(10, this.Height - 50);

            int fontSize = rnd.Next(12, 28);

           

            g.DrawString(name, new Font(FontFamily.GenericSerif, fontSize, FontStyle.Italic), new SolidBrush(randomColor()), x, y);

            if (loop == 200)
            {
                this.Invalidate();                
                this.BackColor = randomColor();
                loop = 0;
            }

            loop++;
        }

        private Color randomColor()
        {
            Color color;

            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            color = Color.FromArgb(red, green, blue);

            return color;
        }
    }
}
