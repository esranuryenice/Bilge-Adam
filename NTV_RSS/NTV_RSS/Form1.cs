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

namespace NTV_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlDoc = new XmlTextReader("http://www.ntv.com.tr/gundem.rss");

            while (xmlDoc.Read())
            {
                if (true)
                {

                }
            }
        }
    }
}
