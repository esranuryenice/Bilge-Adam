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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size;
        private void busType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string busTypeName = busType.SelectedItem.ToString();

            if (busTypeName == "Travego")
            {
                size = 45;
            }
            else if (busTypeName == "E403")
            {
                size = 55;
            }
        }
        int counter = 1;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {                   

                    if (j != 2 && (i != 5 || j < 2) ) //ekle arka 5 koltuk
                    {
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Width * i;
                        btn.Text = counter.ToString();
                        this.Controls.Add(btn);
                        counter++;
                    }

                    //else if ((i != 5 && j != 3) || (i != 5 && j != 4))
                    //{
                    //    Button btn = new Button();
                    //    btn.Width = 30;
                    //    btn.Height = 30;
                    //    btn.Left = btn.Width * j;
                    //    btn.Top = btn.Width * i;
                    //    btn.Text = counter.ToString();
                    //    this.Controls.Add(btn);
                    //    counter++;
                        
                    //}

                }

            }
        }
    }

}

//this.Controls.Clear();
//ototbüs tipine göre buton oluştur
