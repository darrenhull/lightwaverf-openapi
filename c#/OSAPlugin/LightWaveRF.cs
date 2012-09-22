using System;
using System.AddIn;
using OpenSourceAutomation;

namespace LightWaveRF
{
    [AddIn("LightWaveRF", Version = "1.0.2")]
    public class LightWaveRF : IOpenSourceAutomationAddInv2
    {
        LightwaveRF.API APIinterface;
        static private OSAE.OSAE osae = new OSAE.OSAE("LightWaveRF");
        public void ProcessCommand(OSAE.OSAEMethod method)
        {
            try
            {
                var properties = osae.GetObjectByAddress(method.Address).Properties;
                int room = 0; int device = 0; int mood = 0;
                osae.AddToLog("LightwaveRF Command: " + method.MethodName, true);
                foreach (var prop in properties)
                {
                    switch (prop.Name.ToLowerInvariant())
                    {
                        case "room":
                            room = int.Parse(prop.Value);
                            osae.AddToLog("LightwaveRF Room: " + room, true);
                            break;
                        case "device":
                            device = int.Parse(prop.Value);
                            osae.AddToLog("LightwaveRF Device: " + device, true);
                            break;
                        case "mood":
                            mood = int.Parse(prop.Value);
                            osae.AddToLog("LightwaveRF Mood: " + mood, true);
                            break;
                    }
                }

                switch (method.MethodName.ToLowerInvariant())
                {
                    case "on":
                        APIinterface.DeviceOnOff(room, device, true);
                        break;
                    case "off":
                        APIinterface.DeviceOnOff(room, device, false);
                        break;
                    case "dim-10%":
                        APIinterface.Dim(room, device, 10);
                        break;
                    case "dim-20%":
                        APIinterface.Dim(room, device, 20);
                        break;
                    case "dim-30%":
                        APIinterface.Dim(room, device, 30);
                        break;
                    case "dim-40%":
                        APIinterface.Dim(room, device, 40);
                        break;
                    case "dim-50%":
                        APIinterface.Dim(room, device, 50);
                        break;
                    case "dim-60%":
                        APIinterface.Dim(room, device, 60);
                        break;
                    case "dim-70%":
                        APIinterface.Dim(room, device, 70);
                        break;
                    case "dim-80%":
                        APIinterface.Dim(room, device, 80);
                        break;
                    case "dim-90%":
                        APIinterface.Dim(room, device, 90);
                        break;
                    case "heat-on":
                        APIinterface.HeatOnOff(room, 1);
                        break;
                    case "heat-off":
                        APIinterface.HeatOnOff(room, 0);
                        break;
                    case "all-off":
                        APIinterface.AllOff(room);
                        break;
                    case "mood":
                        APIinterface.Mood(room, mood);
                        break;
                    case "raw":
                        APIinterface.sendRaw(method.Parameter1);
                        break;
                    default:
                        osae.AddToLog("unknown method:" + method.MethodName, false);
                        break;

                }
            }
            catch( Exception ex)
                {
                    osae.AddToLog(ex.Message + ex.StackTrace, true);
                }
        }

        public void RunInterface(string pluginName)
        {
            APIinterface = new LightwaveRF.API();
        }

        public void Shutdown()
        {
            APIinterface = null;
        }
    }
}
