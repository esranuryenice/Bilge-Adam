﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int width, height;
        int counter = 2;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Spaceship.Left -= 10;
                    break;
                case Keys.Right:
                    Spaceship.Left += 10;
                    break;
                case Keys.Up:
                    Spaceship.Top -= 10;
                    break;
                case Keys.Down:
                    Spaceship.Top += 10;
                    break;
                case Keys.S:
                    Spaceship.Top += 10;
                    break;
                case Keys.Space:
                    int x = Spaceship.Location.X + Spaceship.Width / 2;
                    int y = Spaceship.Location.Y + Spaceship.Height / 2;
                    rocket.Location = new Point(x, y);
                    rocket.Visible = true;
                    timer1.Start();
                    break;
                default:
                    break;
            }

            if (Spaceship.Location.X > wallRight.Location.X - Spaceship.Width)
            {
                if (counter < 0)
                {
                    MessageBox.Show("GAME OVER!");
                    Application.Exit();
                }

                MessageBox.Show("You have " + counter + " life left. Be careful !!!");
                counter--;
                Spaceship.Location = new Point(238, 106);
            }

            else if (Spaceship.Location.X < wallLeft.Location.X)
            {
                if (counter < 0)
                {
                    MessageBox.Show("GAME OVER!");
                    Application.Exit();
                }
                MessageBox.Show("You have " + counter + " life left. Be careful !!!");
                counter--;
                Spaceship.Location = new Point(238, 106);
            }


            else if (Spaceship.Location.Y < wallUp.Location.Y)
            {
                if (counter < 0)
                {
                    MessageBox.Show("GAME OVER!");
                    Application.Exit();
                }
                MessageBox.Show("You have " + counter + " life left. Be careful !!!");
                counter--;
                Spaceship.Location = new Point(238, 106);

            }


            else if (Spaceship.Location.Y > wallDown.Location.Y - Spaceship.Height)
            {
                if (counter < 0)
                {
                    MessageBox.Show("GAME OVER!");
                    Application.Exit();
                }
                MessageBox.Show("You have " + counter + " life left. Be careful !!!");
                counter--;
                Spaceship.Location = new Point(238, 106);

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            width = Form1.ActiveForm.Width;
            height = Form1.ActiveForm.Height;

            if (rocket.Location.X < width - rocket.Width)
            {
                rocket.Left += 10;
            }
            else
                //timer1.Stop();
                rocket.Visible = false;

        }
    }
}
//TO DO:
//bir bomba attın ardından bir bomba daha atabil
