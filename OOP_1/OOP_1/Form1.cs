using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student stu1 = new Student();
        Student stu2 = new Student();
        private void Form1_Load(object sender, EventArgs e)
        {
            stu1.nameSurname = "Bengisu Gultekin";
            stu1.studentNo = 555;

            stu2.nameSurname = stu1.nameSurname;
            stu2.studentNo = 567;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stu1.nameSurname + " " + stu1.studentNo);
            MessageBox.Show(stu2.nameSurname + " " + stu2.studentNo);
        }
    }
}
