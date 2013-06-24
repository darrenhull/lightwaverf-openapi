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
            txtAPIKey.Text = TestApp.Properties.Settings.Default.WorldWeatherKey;
            txtPostcode.Text = TestApp.Properties.Settings.Default.PostCode;
            cmbDayMinTempOff.Text = TestApp.Properties.Settings.Default.OutdoorMinTempLim.ToString();
            cmbMaxTempOffHeat.Text = TestApp.Properties.Settings.Default.OutdoorTempLim.ToString();
            dateTimePicker1.Value = TestApp.Properties.Settings.Default.HolidayToDate;
            checkBox1.Checked = TestApp.Properties.Settings.Default.Holiday;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("http://api.worldweatheronline.com/free/v1/weather.ashx?key=" + txtAPIKey.Text + "&q=" + txtPostcode.Text + "&num_of_days=1&format=xml");
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
                    string comment = "It's Cold Out";
                    if (newheatstate == State.Off) comment = "Warm Outside";
                    string retval = LightwaveRF.API.CentralHeatOnOff(newheatstate, comment);
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
            Program.APIForm.Show();
        }

        private void txtAPIKey_TextChanged(object sender, EventArgs e)
        {
            TestApp.Properties.Settings.Default.WorldWeatherKey = txtAPIKey.Text;
            TestApp.Properties.Settings.Default.Save();
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            TestApp.Properties.Settings.Default.PostCode = txtPostcode.Text;
            TestApp.Properties.Settings.Default.Save();
        }

        private void cmbMaxTempOffHeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestApp.Properties.Settings.Default.OutdoorTempLim = decimal.Parse(cmbMaxTempOffHeat.Text);
            TestApp.Properties.Settings.Default.Save();
        }

        private void cmbDayMinTempOff_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestApp.Properties.Settings.Default.OutdoorMinTempLim = decimal.Parse(cmbDayMinTempOff.Text);
            TestApp.Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TestApp.Properties.Settings.Default.Holiday = checkBox1.Checked;
            TestApp.Properties.Settings.Default.Save();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TestApp.Properties.Settings.Default.HolidayToDate = dateTimePicker1.Value;
            TestApp.Properties.Settings.Default.Save();
        }

        private void HeatControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            timer1_Tick(this, null);
        }
    }
}
