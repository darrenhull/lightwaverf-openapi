using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LightwaveSite
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                updateState();
        }

        protected void rbOff_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentDevice();
            lblResponse.Text = device.Off();
            updateState();
        }

        protected void rbOn_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentDevice();
            lblResponse.Text = device.On();
            updateState();
        }

        protected void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateState();
        }

        protected void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateState();
        }

        protected void updateState()
        {
            var device = GetCurrentDevice();
            if (device != null)
            {
                rbOn.Checked = (device.state == LightwaveRF.State.On);
                rbOff.Checked = (device.state == LightwaveRF.State.Off);
                rbClose.Checked = (device.state == LightwaveRF.State.Close);
                rbOpen.Checked = (device.state == LightwaveRF.State.Open);
                rbStop.Checked = (device.state == LightwaveRF.State.Stop);
                cmbDim.Text = (Math.Round((double)device.DimLevel/10)*10).ToString();
            }
        }

        protected LightwaveRF.Device GetCurrentDevice()
        {
            if (LightwaveRF.API.Devices != null)
            {
                var device = from x in LightwaveRF.API.Devices
                             where x.room.RoomNum == int.Parse(cmbRoom.SelectedValue)
                             && x.devicenum == int.Parse(cmbDevice.SelectedValue)
                             select x;
                if (device != null && device.Count()>0) return device.FirstOrDefault();
            }
            return new LightwaveRF.Device(new LightwaveRF.Room(int.Parse(cmbRoom.SelectedValue)), int.Parse(cmbDevice.SelectedValue), "", LightwaveRF.DeviceType.OnOffDimmer, LightwaveRF.State.Off);
        }

        protected void cmbDim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var device = GetCurrentDevice();
            lblResponse.Text = device.Dim(int.Parse(cmbDim.Text));
            updateState();
        }

        protected void rbOpen_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentDevice();
            if(rbOpen.Checked) lblResponse.Text = device.Open();
            updateState();
        }

        protected void rbClose_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentDevice();
            if(rbClose.Checked) lblResponse.Text = device.Close();
            updateState();
        }

        protected void rbStop_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentDevice();
            if(rbStop.Checked) lblResponse.Text = device.Stop();
            updateState();
        }
    }
}
