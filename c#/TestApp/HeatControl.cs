using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using LightwaveRF;

namespace TestApp
{
    public partial class HeatControl : Form
    {
        double temp = 0, maxtemp = 0, mintemp = 0, cloudcover = 0;
        State currentHeatState;

        public HeatControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("http://free.worldweatheronline.com/feed/weather.ashx?key=" + txtAPIKey.Text + "&q=" + txtPostcode.Text + "&num_of_days=1&format=xml");
                XmlNodeList Weatherxml = xmlDoc.GetElementsByTagName("temp_C");
                if (Weatherxml.Count > 0) temp = double.Parse(Weatherxml[0].InnerText);
                lbloutdoortemp.Text = temp.ToString("#0 Deg C");

                Weatherxml = xmlDoc.GetElementsByTagName("tempMaxC");
                if (Weatherxml.Count > 0) maxtemp = double.Parse(Weatherxml[0].InnerText);
                lblmaxtemp.Text = maxtemp.ToString("#0 Deg C");

                Weatherxml = xmlDoc.GetElementsByTagName("tempMinC");
                if (Weatherxml.Count > 0) mintemp = double.Parse(Weatherxml[0].InnerText);
                lblmintemp.Text = mintemp.ToString("#0 Deg C");

                Weatherxml = xmlDoc.GetElementsByTagName("cloudcover");
                if (Weatherxml.Count > 0) cloudcover = double.Parse(Weatherxml[0].InnerText);
                lblCloudCover.Text = cloudcover.ToString("##");
                lblLastUpdateWeather.Text = DateTime.Now.ToString() + " Weather updated";
                LightwaveRF.State newheatstate;
                if (mintemp > double.Parse(cmbDayMinTempOff.Text))
                {
                    newheatstate = LightwaveRF.State.Off;
                }
                else if (temp > double.Parse(cmbMaxTempOffHeat.Text))
                {
                    newheatstate = LightwaveRF.State.Off;
                }
                else
                {
                    newheatstate = LightwaveRF.State.On;
                }
                if (newheatstate != currentHeatState)
                {
                    string retval = LightwaveRF.API.CentralHeatOnOff(newheatstate, "AutoCentHeat");
                    lblHeatState.Text = "Heating now set to : " + newheatstate + " " + DateTime.Now.ToString() + "Response: " + retval;
                    currentHeatState = newheatstate;
                }
                else
                {
                    lblHeatState.Text = "Heating still :" + newheatstate + DateTime.Now.ToString();
                }
            }
            catch(Exception ex)
            {
                lblHeatState.Text = " Error getting temp data: " + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new Form1();
            x.Show();
        }

        private void txtAPIKey_TextChanged(object sender, EventArgs e)
        {
            timer1_Tick(this, null);
        }
    }
}
