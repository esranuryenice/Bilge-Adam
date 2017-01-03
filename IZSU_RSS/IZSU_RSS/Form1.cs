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
       
        XmlNodeList linkListNews;

        private void buttonComeToMeBaby_Click(object sender, EventArgs e)
        {
            #region Dam_Water_Level

            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=3");

            XmlNodeList damTitleList = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList damDescriptionList = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList damDateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            label1.Show();
            label1.Text = "Tarih: " + Convert.ToDateTime(damDateList[0].InnerText).ToString("dd/MM/yyyy");

            for (int i = 0; i < damTitleList.Count; i++)
            {
                DamWaterRatio _dam = new DamWaterRatio(damTitleList[i].InnerText, damDescriptionList[i].InnerText);
                //_dam.date = Convert.ToDateTime(damDateList[i].InnerText);

                listBox1.Items.Add(_dam);

            }

            #endregion


            #region News

            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=1");

            XmlNodeList titleListNews = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList dateListNews = xmlDoc.SelectNodes("//channel/item/pubDate");
            linkListNews = xmlDoc.SelectNodes("//channel/item/link");


            for (int i = 0; i < titleListNews.Count; i++)
            {
                News n = new News(titleListNews[i].InnerText, linkListNews[i].InnerText);
                n.date = Convert.ToDateTime(dateListNews[i].InnerText);

                listBox2.Items.Add(n);

            }

            #endregion


            #region Water_Cuts

            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=2");

            XmlNodeList titleListWater = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionListWater = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList dateListWater = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < titleListWater.Count; i++)
            {
                WaterCut w = new WaterCut(titleListWater[i].InnerText, descriptionListWater[i].InnerText);
                w.date = Convert.ToDateTime(dateListWater[i].InnerText);
               
                listBox3.Items.Add(w);
            }

            #endregion

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {                      

            webBrowser1.Visible = true;

            News n = (News)listBox2.SelectedItem;
                       
            webBrowser1.Navigate("http://www.izsu.gov.tr/" + n.link);


        }
       
        private void listBox3_DoubleClick(object sender, EventArgs e)
        {

            webBrowser1.Visible = true;

            WaterCut w = (WaterCut)listBox3.SelectedItem;

            webBrowser1.DocumentText = w.description;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            label1.Hide();
        }

    }
}
