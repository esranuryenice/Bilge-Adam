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

namespace BBC_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlNodeList linkList;

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("http://feeds.bbci.co.uk/news/rss.xml");

            XmlNodeList titleList = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList dateList = xmlDoc.SelectNodes("//channel/item/pubDate");
            linkList = xmlDoc.SelectNodes("//channel/item/link");

            for (int i = 0; i < titleList.Count; i++)
            {
                listBoxNews.Items.Add(titleList[i].InnerText + "\t" + dateList[i].InnerText);
            }
                        

        }

        private void listBoxNews_DoubleClick(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(linkList[listBoxNews.SelectedIndex].InnerText);
        }
    }
}
