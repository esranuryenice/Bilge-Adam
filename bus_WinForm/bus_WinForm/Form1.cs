using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TO DO: ARka 5li için cinsiyet !!
//bütün butonlar siliniyor !!

namespace bus_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 1;

        private void busType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string busTypeName = busType.SelectedItem.ToString();

            if (busTypeName == "Mercedes Travego")
            {
                this.Controls.Clear();
                counter = 1;

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (j != 2 && (i != 5 || j < 2) || (i == 11 && j == 2))
                        {
                            Button btn = new Button();
                            btn.Click += new EventHandler(btn_Click);
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Left = btn.Width * j + 20;
                            btn.Top = btn.Width * i + 80;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.ForeColor = Color.White;
                            btn.FlatStyle = FlatStyle.Flat;

                            this.Controls.Add(btn);
                            counter++;
                        }
                    }
                }
            }
            else if (busTypeName == "E403")
            {
                this.Controls.Clear();
                counter = 1;

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 && j != 3) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += new EventHandler(btn_Click);
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Left = btn.Width * j + 20;
                            btn.Top = btn.Width * i + 80;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.ForeColor = Color.White;
                            btn.FlatStyle = FlatStyle.Flat;

                            this.Controls.Add(btn);
                            counter++;
                        }
                    }
                }

            }

        }        

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (((Control)sender).BackColor == Color.FromArgb(135, 144, 180)) //mavi ise yani boş ise
            {
                
                ((Control)sender).BackColor = Color.FromArgb(175, 163, 121); //kahverengi oldu dolu yani

                form2.seatNumber = int.Parse(((Control)sender).Text);
                
                form2.Show();

            }

            else if (((Control)sender).BackColor == Color.FromArgb(175, 163, 121)) //kahve ise
            {
                form2.seatNumber = int.Parse(((Control)sender).Text);

                form2.Show();
            }
        }      
    }
}



//this.Controls.Clear();
//ototbüs tipine göre buton oluştur
