using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LightwaveRF;

namespace TestApp
{
    public partial class Form1 : Form
    {
        string lastcommand = "";
        private void apilistener_Raw(object sender, string rawData)
        {
            txtcommands.Invoke(new MethodInvoker(delegate { txtcommands.Text = DateTime.Now.ToString() + "     " + rawData + Environment.NewLine + txtcommands.Text; }));
            lastcommand = rawData;
        }

        public Form1()
        {
            LightwaveRF.API.Raw += new LightwaveRF.rawEventHandler(apilistener_Raw);
            LightwaveRF.API.Listen();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkRadiatorState.Checked = TestApp.Properties.Settings.Default.MaintainRadiatorState;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.DeviceOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), State.On);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.DeviceOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), State.Off);
        }

        private void HeatOn_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.HeatOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), State.On);
        }

        private void HeatOff_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.HeatOnOff(int.Parse(cmbRoom.SelectedItem.ToString()), State.Off);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.Dim(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()), int.Parse(cmbPct.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.AllOff(int.Parse(cmbRoom.SelectedItem.ToString()));
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.ManualLockDevice(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()));
        }
        
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.UnLockDevice(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()));
        }

        private void btnSaveMood_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.SaveMood(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbMood.SelectedItem.ToString()));
        }

        private void btnSetMood_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.Mood(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbMood.SelectedItem.ToString()));
        }

        private void btnFullLock_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.FullLockDevice(int.Parse(cmbRoom.SelectedItem.ToString()), int.Parse(cmbDevice.SelectedItem.ToString()));
        }

        private void btnRecordSequence_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.RecordSequence(txtSequence.Text);
        }

        private void btnRunSequence_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.startSequence(txtSequence.Text);
        }

        private void btnAllHeatOff_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.AllHeat(State.Off);                
        }
        
        private void btnAllHeatOn_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.AllHeat(State.On);
        }

        private void btnSendRaw_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.sendRaw(txtSendRaw.Text);
        }

        private void btnHWon_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.HotWaterOnOff(State.On);
        }

        private void btnHWoff_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.HotWaterOnOff(State.Off);
        }

        private void btnCHon_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.CentralHeatOnOff(State.On);
        }

        private void btnCHoff_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.CentralHeatOnOff(State.Off);
        }

        private void btnDeleteSequence_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.deleteSequence(txtSequence.Text);
        }

        private void btnGetReading_Click(object sender, EventArgs e)
        {
            var x = LightwaveRF.API.GetMeterReading();
            lblMeterReading.Text = "Current:" + x.WattsCurrent.ToString() + " Max Today:" + x.WattsMax + " Total today:" + x.WattsTotalToday + " Total Yesterday:" + x.WattsTotalYesterday; 
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.OpenDevice(int.Parse(cmbRoom.Text), int.Parse(cmbDevice.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.StopDevice(int.Parse(cmbRoom.Text), int.Parse(cmbDevice.Text));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.CloseDevice(int.Parse(cmbRoom.Text), int.Parse(cmbDevice.Text));
        }

        private void btnHeatControl_Click(object sender, EventArgs e)
        {
            Program.HeatingForm.Show();
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            lblResponse.Text = LightwaveRF.API.saveTimer(txtTimername.Text, txtSequenceNameTimer.Text, dateTimeTimer.Value);
        }

        private void chkRadiatorState_CheckedChanged(object sender, EventArgs e)
        {
            LightwaveRF.API.MaintainRadiatorState = chkRadiatorState.Checked;
            TestApp.Properties.Settings.Default.MaintainRadiatorState = chkRadiatorState.Checked;
            TestApp.Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void chkHeatDemandControl_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHeatDemandControl.Checked)
            {
                LightwaveRF.API.HeatingControlFromValveTemp();
            }
        }
    }
}
