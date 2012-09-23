using System;
using System.AddIn;
using OpenSourceAutomation;
using LightwaveRF;

namespace LightWaveRF
{
    [AddIn("LightWaveRF", Version = "1.0.2")]
    public class LightWaveRF : IOpenSourceAutomationAddInv2
    {
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
                        LightwaveRF.API.DeviceOnOff(room, device, State.On);
                        break;
                    case "off":
                        LightwaveRF.API.DeviceOnOff(room, device, State.Off);
                        break;
                    case "dim-10%":
                        LightwaveRF.API.Dim(room, device, 10);
                        break;
                    case "dim-20%":
                        LightwaveRF.API.Dim(room, device, 20);
                        break;
                    case "dim-30%":
                        LightwaveRF.API.Dim(room, device, 30);
                        break;
                    case "dim-40%":
                        LightwaveRF.API.Dim(room, device, 40);
                        break;
                    case "dim-50%":
                        LightwaveRF.API.Dim(room, device, 50);
                        break;
                    case "dim-60%":
                        LightwaveRF.API.Dim(room, device, 60);
                        break;
                    case "dim-70%":
                        LightwaveRF.API.Dim(room, device, 70);
                        break;
                    case "dim-80%":
                        LightwaveRF.API.Dim(room, device, 80);
                        break;
                    case "dim-90%":
                        LightwaveRF.API.Dim(room, device, 90);
                        break;
                    case "heat-on":
                        LightwaveRF.API.HeatOnOff(room, State.On);
                        break;
                    case "heat-off":
                        LightwaveRF.API.HeatOnOff(room, 0);
                        break;
                    case "all-off":
                        LightwaveRF.API.AllOff(room);
                        break;
                    case "mood":
                        LightwaveRF.API.Mood(room, mood);
                        break;
                    case "raw":
                        LightwaveRF.API.sendRaw(method.Parameter1);
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
        }

        public void Shutdown()
        {
        }
    }
}
