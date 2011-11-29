using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace lightwaverf
{
    public class API
    {
        /// <summary>
        /// Switches off all devices in room
        /// </summary>
        /// <param name="Room">Room to switch all off in.</param>
        public void AllOff(int Room)
        {
            string text = "000,!R" + Room + "Fa";
            SendRaw(text);
        }

        /// <summary>
        /// sets mood in room
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="mood">mood number</param>
        public void SendMood(int Room, int mood)
        {
            string text = "000,!R1FmP" + mood + "|";
            SendRaw(text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="percent">percentage level for the dim< eg. 50/param>
        public void SendDim(int Room, int Device, int percent)
        {
            string pstr;
            pstr = Math.Round(((double)percent / 100 * 32)).ToString();
            string text = "000,!R" + Room + "D" + Device + "FdP" + pstr + "|";
            SendRaw(text);
        }

        /// <summary>
        /// send on/off command to a room/device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="state">state (0 or 1)</param>
        public void SendOnOff(int Room, int Device, bool state)
        {
            string statestr;
            if(state) statestr = "1"; else statestr = "0";
            string text = "000,!R" + Room + "D" + Device + "F" + statestr + "|";
            SendRaw(text);
        }

        /// <summary>
        /// Send raw packet containing 'text' to the wifilink
        /// </summary>
        /// <param name="text">contents of packet.</param>
        public void SendRaw(string text)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress serverAddr = IPAddress.Parse("255.255.255.255");
            IPEndPoint endPoint = new IPEndPoint(serverAddr, 9760);
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);
            sock.SendTo(send_buffer, endPoint);
        }
    }
}
