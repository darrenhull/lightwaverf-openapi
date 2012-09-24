using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightwaveRF
{
    public class MeterReading
    {
        public double WattsCurrent = -1;
        public double WattsMax= -1;
        public double WattsTotalToday= -1;
        public double WattsTotalYesterday= -1;
        public MeterReading(string responsetext)
        {
            try
            {
                var x = responsetext.Split(',');
                WattsCurrent = double.Parse(x[0]);
                WattsMax = double.Parse(x[1]);
                WattsTotalToday = double.Parse(x[2]);
                WattsTotalYesterday = double.Parse(x[3]);
            }
            catch (Exception e)
            { }
        }
    }
}
