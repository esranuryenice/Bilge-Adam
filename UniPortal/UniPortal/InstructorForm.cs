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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Instructor i = new Instructor();
            i.name = textBoxName.Text;
            i.surname = textBoxSurname.Text;
            i.phoneNumber = textBoxPhoneNumber.Text;
            i.department = textBoxDepartment.Text;
            i.task = textBoxTask.Text;

            dataGridViewInstructor.Rows.Add(i.name, i.surname, i.phoneNumber, i.department, i.task);
        }
    }
}
