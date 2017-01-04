using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedIndex.Equals(0)) //student
            {
                StudentForm frm = new StudentForm();
                frm.ShowDialog();

            }
            else if (comboBoxChoose.SelectedIndex.Equals(1)) //instructor
            {
                InstructorForm frm = new InstructorForm();
                frm.ShowDialog();
            }
        }
    }
}
