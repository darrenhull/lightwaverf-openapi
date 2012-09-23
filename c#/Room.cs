using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightwaveRF
{
    public class Room
    {
        public List<Device> Devices;
        public Room(int roomnum)
        {
            this.RoomNum = roomnum;
        }
        public string HeatOff()
        {
            return LightwaveRF.API.HeatOnOff(RoomNum, State.Off);
        }
        public string HeatOn()
        {
            return LightwaveRF.API.HeatOnOff(RoomNum,State.On);
        }
        public string AllOff()
        {
            return LightwaveRF.API.AllOff(RoomNum);
        }
        public int RoomNum { get; set; }
        public String RoomName { get; set; }
    }
}
