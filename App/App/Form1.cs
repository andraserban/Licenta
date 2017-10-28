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
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;




namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader readXml = XmlReader.Create(textBoxURL.Text);
                SyndicationFeed feed = SyndicationFeed.Load(readXml);

                TabPage tab = new TabPage(feed.Title.Text);

                tabControlRSS.TabPages.Add(tab);

                ListBox list = new ListBox();

                tab.Controls.Add(list);

                list.Dock = DockStyle.Fill;

                list.HorizontalScrollbar = true;

                foreach(SyndicationItem item in feed.Items) 
                {
                    list.Items.Add(item.Title.Text);
                    list.Items.Add(item.Summary.Text);
                    list.Items.Add("------------------");
                }                

            }
            catch { }
        }
    }
}
