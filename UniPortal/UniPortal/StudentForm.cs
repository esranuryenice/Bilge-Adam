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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = textBoxName.Text;
            s.surname = textBoxSurname.Text;
            s.phoneNumber = textBoxPhoneNumber.Text;

            dataGridViewStudent.Rows.Add(s.name, s.surname, s.phoneNumber);
        }
    }
}
