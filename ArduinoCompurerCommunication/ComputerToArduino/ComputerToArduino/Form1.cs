using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;

namespace ComputerToArduino
{
    public partial class Form1 : Form

    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            } else
            {
                disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            enableControls();
        }

        

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#TEXT" + textBox1.Text + "#\n");
            }
        }

        private void enableControls()
        {
           
            button2.Enabled = true;
            textBox1.Enabled = true;
           
            groupBox3.Enabled = true;

        }

        private void disableControls()
        {
           
            button2.Enabled = false;
            textBox1.Enabled = false;
          
            groupBox3.Enabled = false;
        }

        private void resetDefaults()
        {
            textBox1.Text = "";
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
       

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                XmlReader readXml = XmlReader.Create(textBoxURL.Text);
                SyndicationFeed feed = SyndicationFeed.Load(readXml);

                TabPage tab = new TabPage(feed.Title.Text);

                tabControlRSS.TabPages.Add(tab);

                ListBox list = new ListBox();

                tab.Controls.Add(list);

                //list.Dock = DockStyle.Fill;

                list.HorizontalScrollbar = true;

                foreach (SyndicationItem item in feed.Items)
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
