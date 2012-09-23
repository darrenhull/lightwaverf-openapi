using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightwaveRF
{
    class House
    {
        private State hotWaterState = State.On;
        private State centralHeatingState = State.On;
        public List<Room> rooms;
        public State CentralHeating
        {
            get
            {
                return centralHeatingState;
            }
            set
            {
                LightwaveRF.API.CentralHeatOnOff(value);
                centralHeatingState = value;
            }
        }
        public State HotWater
        {
            get
            {
                return hotWaterState   ;
            }
            set
            {
                LightwaveRF.API.HotWaterOnOff(value);
                hotWaterState = value;
            }
        }
    }
}
