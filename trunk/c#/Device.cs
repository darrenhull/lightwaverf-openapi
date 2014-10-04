using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightwaveRF
{
        public class Device
        {
            public Device(Room room, int devicenum, string deviceName, DeviceType deviceType, State state)
            {
                this.room = room;
                this.devicenum = devicenum;
                this.deviceName = deviceName;
                this.deviceType = deviceType;
                this.state = state;
            }
            public Room room;
            public int devicenum { get; set; }
            public string deviceName { get; set; }
            public State state { get; set; }
            public int DimLevel { get; set; }
            public DeviceType deviceType { get; set; }
            public string deviceIdentifier
            {
                get
                {
                    return room.ToString() + "," + devicenum.ToString();
                }
            }
            public string Dim(int dimPercent)
            {
                this.state = State.On;
                return LightwaveRF.API.Dim(room.RoomNum, devicenum, dimPercent);
            }
            public string Off()
            {
                if (deviceType == DeviceType.Boiler) return LightwaveRF.API.CentralHeatOnOff(State.Off);
                if (deviceType == DeviceType.Radiator) return LightwaveRF.API.HeatOnOff(room.RoomNum, State.Off);
                this.state = State.Off;
                return LightwaveRF.API.DeviceOnOff(room.RoomNum, devicenum, State.Off);
            }
            public string On()
            {
                if(deviceType == DeviceType.Boiler) return LightwaveRF.API.CentralHeatOnOff(State.On);
                if(deviceType == DeviceType.Radiator) return LightwaveRF.API.HeatOnOff(room.RoomNum, State.On);
                this.state = State.On;
                return LightwaveRF.API.DeviceOnOff(room.RoomNum, devicenum,State.On);
            }
            public string Open()
            {
                this.state = State.Open;
                return LightwaveRF.API.OpenDevice(room.RoomNum, devicenum);
            }
            public string Close()
            {
                this.state = State.Close;
                return LightwaveRF.API.CloseDevice(room.RoomNum, devicenum);
            }
            public string Stop()
            {
                this.state = State.Stop;
                return LightwaveRF.API.StopDevice(room.RoomNum, devicenum);
            }

            public string FullLock()
            {
                return LightwaveRF.API.FullLockDevice(room.RoomNum, devicenum);
            }
            public string UnLock()
            {
                return LightwaveRF.API.UnLockDevice(room.RoomNum,devicenum);
            }
            public string ManualLock()
            {
                return LightwaveRF.API.ManualLockDevice(room.RoomNum,devicenum);
            }
        }
}
