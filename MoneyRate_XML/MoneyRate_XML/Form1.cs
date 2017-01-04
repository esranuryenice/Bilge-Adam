using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoneyRate_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc;
        DateTime date;

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();

            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            date = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int day = dateTimePicker1.Value.Day;
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;

            string stringDay, stringMonth;

            if (day <= 9)
            {
                stringDay = "0" + day;
            }
            else
            {
                stringDay = day.ToString();
            }

            if (month <= 9)
            {
                stringMonth = "0" + month;
            }
            else
            {
                stringMonth = month.ToString();
            }

            try
            {
                xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/" + year + stringMonth + "/" + stringDay + stringMonth + year + ".xml");
                date = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            }
            catch (Exception)
            {

                throw;
            }

        }
        bool dolarState, euroState, poundState;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }

            if (comboBox1.SelectedItem.ToString() == "USD")
            {
                #region Dolar

                if (dataGridView1.Rows.Count != 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dolar")
                        {
                            dolarState = true;
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                    if (!dolarState)
                    {
                        string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                        dataGridView1.Rows.Add("Dolar", date.ToString("dd/MM/yy"), USD);
                    }
                }
                else
                {
                    string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                    dataGridView1.Rows.Add("Dolar", date.ToString("dd/MM/yy"), USD);
                }
                #endregion

            }
            else if (comboBox1.SelectedItem.ToString() == "EUR")
            {
                #region Euro
                if (dataGridView1.Rows.Count != 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Euro")
                        {
                            euroState = true;
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                    if (!euroState)
                    {
                        string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                        dataGridView1.Rows.Add("Euro", date.ToString("dd/MM/yy"), EUR);
                    }
                }
                else
                {
                    string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                    dataGridView1.Rows.Add("Euro", date.ToString("dd/MM/yy"), EUR);
                }
                #endregion
            }
            else
            {
                #region Pound
                if (dataGridView1.Rows.Count != 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Pound")
                        {
                            poundState = true;
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                    if (!poundState)
                    {
                        string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                        dataGridView1.Rows.Add("Pound", date.ToString("dd/MM/yy"), GBP);
                    }
                }
                else
                {
                    string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                    dataGridView1.Rows.Add("Pound", date.ToString("dd/MM/yy"), GBP);
                }
                #endregion

            }
        }
    }
}
