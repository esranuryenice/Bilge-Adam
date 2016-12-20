using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_2_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Customer> customerList = new List<Customer>();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.nameSurname = textBoxName.Text;
            customer.sex = radioButtonMale.Checked == false ? true : false;
            customer.busType = comboBoxBusType.SelectedItem.ToString();

            customerList.Add(customer);
            listBoxCustomers.Items.Add(customer);

            textBoxName.Clear();
            textBoxName.Focus();
        }

        private void listBoxCustomers_DoubleClick(object sender, EventArgs e)
        {
            listBoxCustomers.Items.RemoveAt(listBoxCustomers.SelectedIndex);
        }
    }
}
