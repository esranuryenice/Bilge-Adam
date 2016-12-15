using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ders_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                #region KoltukarTravego

                panelTravego.Visible = true;
                panelSetra.Visible = false;

                int counter = 1;
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            panelTravego.Controls.Add(btn);

                            counter++;
                        }
                    }

                }

                #endregion
            }
            else
            {
                #region KoltukarSetra

                panelSetra.Visible = true;
                panelTravego.Visible = false;                

                int counter = 1;
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 13) && (i != 7 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            panelSetra.Controls.Add(btn);

                            counter++;
                        }
                    }

                }
                #endregion
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelTravego.Visible = false;
            panelSetra.Visible = false;
        }
    }
}
