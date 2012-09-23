using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightwaveRF
{
    public class House
    {
        public int Id { get; set; }
        private State hotWaterState = State.On;
        private State centralHeatingState = State.On;
        public List<Room> rooms { get; set; }
        public List<Sequence> sequences { get; set; }
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
