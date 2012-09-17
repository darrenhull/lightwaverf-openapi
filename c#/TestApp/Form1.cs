using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public LightwaveRF.API apilistener = new LightwaveRF.API();
        private void apilistener_Raw(object sender, string rawData)
        {
            lblMessage.Invoke(new MethodInvoker(delegate { lblMessage.Text = rawData; }));
        }
        private void apilistener_OnResponse(object sender, string data)
        {
            lblResponse.Invoke(new MethodInvoker(delegate { lblResponse.Text = data; }));
        }
        public Form1()
        {
//            apilistener.OnAllOff +=new LightwaveRF.AllOffEventHandler(apilistener_OnAllOff);
//            apilistener.OnDim +=new LightwaveRF.dimEventHandler(apilistener_OnDim);
//            apilistener.OnHeat +=new LightwaveRF.heatEventHandler(apilistener_OnHeat);
//apilistener.OnMood +=new LightwaveRF.moodEventHandler(apilistener_OnMood);
//            apilistener.OnOff +=new LightwaveRF.OnOffEventHandler(apilistener_OnOff);
            apilistener.Raw +=new LightwaveRF.rawEventHandler(apilistener_Raw);
            apilistener.OnResponse +=new LightwaveRF.responseEventHandler(apilistener_OnResponse);
            apilistener.Listen();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            x.DeviceOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), true);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            x.DeviceOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), false);
        }

        private void HeatOn_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            x.HeatOnOff(int.Parse(cmbRoom.SelectedItem.ToString()),true);
        }

        private void HeatOff_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            x.HeatOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), false);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            x.Dim(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), int.Parse(cmbPct.Text));
        }

    }
}
