using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LightwaveSite
{
    public partial class Heating : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack) UpdateState();
        }

        
        protected void UpdateState()
        {
            var device = GetCurrentRadiator();
            if (device != null)
            {
                rbOn.Checked = (device.state == LightwaveRF.State.On);
                rbOff.Checked = (device.state == LightwaveRF.State.Off);
            }
            var boiler = GetBoiler();
            if (boiler != null)
            {
                rbBoilerOn.Checked = (boiler.state == LightwaveRF.State.On);
                rbBoilerOff.Checked = (boiler.state == LightwaveRF.State.Off);
            }
            var hotWater = GetHotWater();
            if (hotWater != null)
            {
                rbHotWaterOn.Checked = (hotWater.state == LightwaveRF.State.On);
                rbHotWaterOff.Checked = (hotWater.state == LightwaveRF.State.Off);
            }
        }

        protected LightwaveRF.Device GetCurrentRadiator()
        {
            if (LightwaveRF.API.Devices != null)
            {
                var device = from x in LightwaveRF.API.Devices
                             where x.room.RoomNum == int.Parse(cmbRoom.SelectedValue)
                             && x.deviceType == LightwaveRF.DeviceType.Radiator
                             select x;
                if (device != null && device.Count() > 0) return device.FirstOrDefault();
            }
            return new LightwaveRF.Device(new LightwaveRF.Room(int.Parse(cmbRoom.SelectedValue)), 0, "", LightwaveRF.DeviceType.Radiator, LightwaveRF.State.On);
        }

        protected LightwaveRF.Device GetBoiler()
        {
            var device =GetDevice(16, 1);
            device.deviceType = LightwaveRF.DeviceType.Boiler;
            return device;
        }
        protected LightwaveRF.Device GetHotWater()
        {
            var device = GetDevice(16, 2);
            return device;
        }
        protected LightwaveRF.Device GetDevice(int roomnum, int devicenum)
        {
            if (LightwaveRF.API.Devices != null)
            {
                var device = from x in LightwaveRF.API.Devices
                             where x.room.RoomNum == roomnum
                             && x.devicenum == devicenum
                             select x;
                if (device != null && device.Count() > 0) return device.FirstOrDefault();
            }
            return new LightwaveRF.Device(new LightwaveRF.Room(roomnum), devicenum, "", LightwaveRF.DeviceType.OnOffDimmer, LightwaveRF.State.Off);
        }

        protected void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        protected void rbOn_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentRadiator();
            if (rbOn.Checked) lblResponse.Text = device.On();
            UpdateState();
        }

        protected void rbOff_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetCurrentRadiator();
            if (rbOff.Checked) lblResponse.Text = device.Off();
            UpdateState();
        }

        protected void rbBoilerOn_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetBoiler();
            if (rbBoilerOn.Checked) lblResponse.Text = device.On();
            UpdateState();
        }

        protected void rbBoilerOff_CheckedChanged(object sender, EventArgs e)
        {

            var device = GetBoiler();
            if (rbBoilerOff.Checked) lblResponse.Text = device.Off();
            UpdateState();
        }

        protected void rbHotWaterOn_CheckedChanged(object sender, EventArgs e)
        {

            var device = GetHotWater();
            if (rbHotWaterOn.Checked) lblResponse.Text =device.On();
            UpdateState();
        }

        protected void rbHotWaterOff_CheckedChanged(object sender, EventArgs e)
        {
            var device = GetHotWater();
            if (rbHotWaterOff.Checked) lblResponse.Text = device.Off();
            UpdateState();
        }
    }
}