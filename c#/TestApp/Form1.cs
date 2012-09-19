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

        public Form1()
        {
            apilistener.Raw +=new LightwaveRF.rawEventHandler(apilistener_Raw);
            apilistener.Listen();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            lblResponse.Text = x.DeviceOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), true);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            lblResponse.Text = x.DeviceOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), false);
        }

        private void HeatOn_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            lblResponse.Text = x.HeatOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), true);
        }

        private void HeatOff_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            lblResponse.Text = x.HeatOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), false);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            lblResponse.Text = x.Dim(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), int.Parse(cmbPct.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new LightwaveRF.API();
            lblResponse.Text = x.AllOff(int.Parse(cmbRoom.SelectedItem.ToString()));
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            lblResponse.Text = apilistener.FullLockDevice(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()));
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            lblResponse.Text = apilistener.UnLockDevice(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()));
        }

        private void btnSaveMood_Click(object sender, EventArgs e)
        {
            lblResponse.Text = apilistener.SaveMood(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbMood.SelectedItem.ToString()));
        }

        private void btnSetMood_Click(object sender, EventArgs e)
        {
            lblResponse.Text = apilistener.Mood(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbMood.SelectedItem.ToString()));
        }

    }
}
