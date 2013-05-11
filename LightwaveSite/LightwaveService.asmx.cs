using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LightwaveRF;
using System.Web.Services;

namespace LightwaveSite
{
    /// <summary>
    /// Summary description for LightwaveService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class LightwaveService : System.Web.Services.WebService
    {

        [WebMethod]
        public string DeviceOnOff(int room, int device, State state)
        {
            return LightwaveRF.API.DeviceOnOff(room,device,state);
        }

        [WebMethod]
        public string HeatOnOff(int room, State state, string message = "")
        {
            return LightwaveRF.API.HeatOnOff(room,state,message);
        }

        [WebMethod] 
        public string CentralHeatOnOff(State state, string message = "")
        {
            return LightwaveRF.API.CentralHeatOnOff(state,message);
        }

        [WebMethod]
        public string HotWaterOnOff(State state, string message = "")
        {
            return LightwaveRF.API.HotWaterOnOff(state,message);
        }

        [WebMethod]
        public string AllDevicesOff()
        {
            return LightwaveRF.API.AllDevicesOff();
        }

        [WebMethod]
        public string Dim(int room, int device, int percent)
        {
            return LightwaveRF.API.Dim(room,device,percent);
        }

        [WebMethod]
        public string SendRaw(string rawtext)
        {
            return LightwaveRF.API.sendRaw(rawtext);
        }
    }
}
