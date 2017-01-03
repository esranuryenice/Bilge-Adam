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

namespace IZSU_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlDocument xmlDocNews = new XmlDocument();
        XmlDocument xmlDocWater = new XmlDocument();

        XmlNodeList linkListNews;

        private void buttonComeToMeBaby_Click(object sender, EventArgs e)
        {
            #region DolulukOranı

            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=3");

            XmlNodeList titleList = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionList = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList dateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            Baraj.date = Convert.ToDateTime(dateList[0].InnerText);

            label1.Text = "Tarih: " + Baraj.date.ToString("dd/MM/yyyy");

            for (int i = 0; i < titleList.Count; i++)
            {
                Baraj b = new Baraj(titleList[i].InnerText, descriptionList[i].InnerText);

                listBox1.Items.Add(b);

            }

            #endregion


            #region Haberler

            xmlDocNews.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=1");
            XmlNodeList titleListNews = xmlDocNews.SelectNodes("//channel/item/title");
            //XmlNodeList descriptionListNews = xmlDocNews.SelectNodes("//channel/item/description");
            XmlNodeList dateListNews = xmlDoc.SelectNodes("//channel/item/pubDate");
            linkListNews = xmlDocNews.SelectNodes("//channel/item/link");


            for (int i = 0; i < titleListNews.Count; i++)
            {
                News n = new News(titleListNews[i].InnerText);

                listBox2.Items.Add(n);

            }

            #endregion


            #region SuKesintisi

            xmlDocWater.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=2");
            XmlNodeList titleListWater = xmlDocNews.SelectNodes("//channel/item/title");
            XmlNodeList descriptionListWater = xmlDocNews.SelectNodes("//channel/item/description");
            XmlNodeList dateListWater = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < titleListWater.Count; i++)
            {
                Water w = new Water(titleListWater[i].InnerText, descriptionListWater[i].InnerText);
                w.date = Convert.ToDateTime(dateListWater[i].InnerText);

                listBox3.Items.Add(w);
            }

            #endregion

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {                      

            webBrowser1.Visible = true;
                       
            webBrowser1.Url = new Uri("http://www.izsu.gov.tr/" + linkListNews[listBox2.SelectedIndex].InnerText.ToString());


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;



        }
    }
}
