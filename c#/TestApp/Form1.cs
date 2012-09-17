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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
