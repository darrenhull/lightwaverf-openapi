using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace lightwaverf
{
    public delegate void OnOffEventHandler(object sender, int Room, int Device, bool state);
    public delegate void AllOffEventHandler(object sender, int Room);
    public delegate void MoodEventHandler(object sender, int Room, int Mood);
    public delegate void DimEventHandler(object sender, int Room,int Device, int pct);
    public delegate void HeatEventHandler(object sender, int Room, int State);
    public delegate void RawEventHandler(object sender, string RawData);

    public class API
    {
        public event OnOffEventHandler OnOff;
        /// <summary>
        /// Regex for on/off
        /// matches :Room, Device, and State
        /// </summary>
        public Regex OnOffRegEx = new Regex("...,!R(?<Room>.)D(?<Device>[.^h]))F(?<State>.)|");
        public event AllOffEventHandler AllOff;
        /// <summary>
        /// Regex for All off
        /// Matches: Room
        /// </summary>
        public Regex AllOffRegEx = new Regex("...,!R(?<Room>.)Fa");
        public event MoodEventHandler Mood;
        /// <summary>
        /// Regex for Mood
        /// Matches: Room, Mood
        /// </summary>
        public Regex MoodRegEx = new Regex("...,!R(?<Room>.)FmP(?<mood>.)|");//"000,!R"+ Room + "FmP" + mood + "|"
        public event DimEventHandler Dim;
        /// <summary>
        /// Regex for Dim
        /// Matches: Room, Device, State
        /// </summary>
        public Regex DimRegEx = new Regex("...,!R(?<Room>.)D(?<Device>.))FdP(?<State>..)|");//"000,!R" + Room + "D" + Device + "FdP" + pstr + "|"
        public event HeatEventHandler Heat;
        /// <summary>
        /// Regex for Heat commands
        /// Matches: Room, State.
        /// </summary>
        public Regex HeatRegEx = new Regex("...,!R(?<Room>.)DhF(?<State>.)|");//"000,!R" + Room + "DhF" + statestr + "|";
        public event RawEventHandler Raw;

        public void listen()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork,
                            SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9760);
            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;
            Console.WriteLine("Ready to receive...");
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    int recv = sock.ReceiveFrom(data, ref ep);
                    string stringData = Encoding.ASCII.GetString(data, 0, recv);
                    Raw(this,stringData);
                    Match OnOffMatch = OnOffRegEx.Match(stringData);
                    Match AllOffMatch = AllOffRegEx.Match(stringData);
                    Match MoodMatch = MoodRegEx.Match(stringData);
                    Match DimMatch = DimRegEx.Match(stringData);
                    Match HeatMatch = HeatRegEx.Match(stringData);
                    if (OnOffMatch.Success)
                    {
                        EventArgs e = new EventArgs();
                        OnOff(this,int.Parse(OnOffMatch.Groups["Room"].Value),int.Parse(OnOffMatch.Groups["Device"].Value,)
                    }
                }
            }
            finally
            {
                sock.Close();
            }
        }

        /// <summary>
        /// Switches off all devices in room
        /// </summary>
        /// <param name="Room">Room to switch all off in.</param>
        public void AllOff(int Room)
        {
            string text = "000,!R" + Room + "Fa|";
            SendRaw(text);
        }

        /// <summary>
        /// sets mood in room
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="mood">mood number</param>
        public void Mood(int Room, int mood)
        {
            string text = "000,!R"+ Room + "FmP" + mood + "|";
            SendRaw(text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="percent">percentage level for the dim< eg. 50/param>
        public void Dim(int Room, int Device, int percent)
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
        public void DeviceOnOff(int Room, int Device, bool state)
        {
            string statestr;
            if(state) statestr = "1"; else statestr = "0";
            string text = "000,!R" + Room + "D" + Device + "F" + statestr + "|";
            SendRaw(text);
        }
        /// <summary>
        /// send on/off command to a room/device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="state">state (0 or 1)</param>
        public void HeatOnOff(int Room, bool state)
        {
            string statestr;
            if (state) statestr = "1"; else statestr = "0";
            string text = "000,!R" + Room + "DhF" + statestr + "|";
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
