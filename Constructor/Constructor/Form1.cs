using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string newPosition = comboBoxPosition.SelectedItem.ToString();

            Player _player1 = new Player();

            MessageBox.Show(_player1.name + " " + _player1.uniformNo);

            Player _player2 = new Player("bengisu");

            MessageBox.Show(_player2.name + " " + _player2.team + " " +_player2.uniformNo);

            Player _player3 = new Player("bengisu");


        }
    }
}
