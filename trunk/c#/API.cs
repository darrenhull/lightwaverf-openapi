using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace LightwaveRF
{
    public delegate void OnOffEventHandler(object sender, int room, int device, bool state);
    public delegate void AllOffEventHandler(object sender, int room);
    public delegate void moodEventHandler(object sender, int room, int mood);
    public delegate void dimEventHandler(object sender, int room,int device, int pct);
    public delegate void heatEventHandler(object sender, int room, int state);
    public delegate void rawEventHandler(object sender, string rawData);
    public delegate void responseEventHandler(object sender, string Data);
    public class API
    {
        public API()
        {
            Random r = new Random();
            ind = r.Next(999);
        }
        int ind = 0;

        private string nextind
        {
            get
            {
                ind++;
                return(ind.ToString("000"));
            }
        }
        

        private Thread listenthread;
        private Thread responsethread;
        public event OnOffEventHandler OnOff;
        /// <summary>
        /// Regex for on/off
        /// matches :Room, Device, and State
        /// </summary>
        public Regex OnOffRegEx = new Regex("...,(!R)(?<Room>[0-9])(D)(?<Device>[0-9])(F)(?<State>[0-1])");
        public event AllOffEventHandler OnAllOff;
        /// <summary>
        /// Regex for All off
        /// Matches: Room
        /// </summary>
        public Regex allOffRegEx = new Regex("...,(!R)(?<Room>[0-9])(Fa)");
        public event moodEventHandler OnMood;
        /// <summary>
        /// Regex for Mood
        /// Matches: Room, Mood
        /// </summary>
        public Regex moodRegEx = new Regex("...,(!R)(?<Room>[0-9])(FmP)(?<mood>[0-9])");//"533,!R"+ Room + "FmP" + mood + "|"
        public event dimEventHandler OnDim;
        /// <summary>
        /// Regex for Dim
        /// Matches: Room, Device, State
        /// </summary>
        public Regex dimRegEx = new Regex("...,(!R)(?<Room>[0-9])(D)(?<Device>[0-9])(FdP)(?<State>[0-9][0-9])");//"533,!R" + Room + "D" + Device + "FdP" + pstr + "|"
        public event heatEventHandler OnHeat;
        /// <summary>
        /// Regex for Heat commands
        /// Matches: Room, State.
        /// </summary>
        public Regex heatRegEx = new Regex("...,(!R)(?<Room>[0-9])(DhF)(?<State>[0-9])");//"533,!R" + Room + "DhF" + statestr + "|";
        public event rawEventHandler Raw;

        public void Listen()
        {
            listenthread = new Thread(new ThreadStart(listenThreadWorker));
            //responsethread = new Thread(new ThreadStart(responseThreadWorker));
            listenthread.Start();
            //responsethread.Start();
        }
        private string getResponse()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork,
                SocketType.Dgram, ProtocolType.Udp);
            sock.ReceiveTimeout = 1000;
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9761);
            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;
            try
            {
                byte[] data = new byte[1024];
                int recv = sock.ReceiveFrom(data, ref ep);
                string stringData = Encoding.ASCII.GetString(data, 0, recv);
                return stringData;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                sock.Close();
            }
        }
        private void listenThreadWorker()
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
                    if(Raw !=null) Raw(this,stringData);
                    Match OnOffMatch = OnOffRegEx.Match(stringData);
                    Match AllOffMatch = allOffRegEx.Match(stringData);
                    Match MoodMatch = moodRegEx.Match(stringData);
                    Match DimMatch = dimRegEx.Match(stringData);
                    Match HeatMatch = heatRegEx.Match(stringData);
                    if (OnOffMatch.Success && OnOff!=null)
                    {
                        OnOff(this, int.Parse(OnOffMatch.Groups["Room"].Value), int.Parse(OnOffMatch.Groups["Device"].Value), int.Parse(OnOffMatch.Groups["State"].Value)==1);
                    }
                    if (AllOffMatch.Success && OnAllOff!=null)
                    {
                        OnAllOff(this, int.Parse(AllOffMatch.Groups["Room"].Value));
                    }
                    if (MoodMatch.Success && OnMood!=null)
                    {
                        OnMood(this, int.Parse(MoodMatch.Groups["Room"].Value), int.Parse(MoodMatch.Groups["Mood"].Value));
                    }
                    if (DimMatch.Success && OnDim!=null)
                    {
                        OnDim(this, int.Parse(DimMatch.Groups["Room"].Value), int.Parse(DimMatch.Groups["Device"].Value), int.Parse(DimMatch.Groups["State"].Value));
                    }
                    if (HeatMatch.Success&& OnHeat!=null)
                    {
                        OnHeat(this, int.Parse(HeatMatch.Groups["Room"].Value), int.Parse(HeatMatch.Groups["State"].Value));
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
        public string AllOff(int room)
        {
            string text = nextind + ",!R" + room + @"Fa|";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// capture commands and store them as a sequence.
        /// </summary>
        /// <param name="SequenceName"></param>
        public string recordsequence(string SequenceName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete named sequence
        /// </summary>
        /// <param name="SequenceName"></param>
        public string deleteSequence(string SequenceName)
        {
            string text = nextind + ",!FxP\"" + SequenceName +"\"";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// Start named sequence
        /// </summary>
        /// <param name="SequenceName"></param>
        public string startSequence(string SequenceName)
        {
            string text =nextind + "!FqP\"" + SequenceName +"\"|Start Sequence|\"" + SequenceName +"\"";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// sets mood in room
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="mood">mood number</param>
        public string Mood(int room, int mood)
        {
            string text = nextind + ",!R"+ room + @"FmP" + mood + @"|Room 1 Mood 1";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// Save the mood preset
        /// </summary>
        /// <param name="room">room number </param>
        /// <param name="mood">mood number</param>
        public string SaveMood(int room, int mood)
        {
            string text = nextind + ",!R"+ room + @"FsP" + mood + @"|MOOD NOW SET";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// Get reading from the wireless meter.
        /// </summary>
        public string GetMeterReading()
        {
            string text = nextind + ",@?W";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="percent">percentage level for the dim< eg. 50/param>
        public string Dim(int room, int device, int percent)
        {
            string pstr;
            pstr = Math.Round(((double)percent / 100 * 32)).ToString();
            string text = nextind + ",!R" + room + @"D" + device + @"FdP" + pstr + @"|";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }

        /// <summary>
        /// send on/off command to a room/device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="state">state (0 or 1)</param>
        public string DeviceOnOff(int room, int device, bool state)
        {
            string statestr;
            if(state) statestr = "1"; else statestr = "0";
            string text = nextind + ",!R" + room + @"D" + device + @"F" + statestr + @"|";
            sendRaw(text);
            return getResponse().Replace(ind+",","");
        }
        /// <summary>
        /// send on/off command to a room/device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="state">state (0 or 1)</param>
        public string HeatOnOff(int room, bool state)
        {
            string statestr;
            if (state) statestr = "1"; else statestr = "0";
            string text = nextind + ",!R" + room + @"DhF" + statestr + @"|";
            sendRaw(text);
            return getResponse().Replace(ind + ",", "");
        }
        /// <summary>
        /// Send raw packet containing 'text' to the wifilink
        /// </summary>
        /// <param name="text">contents of packet.</param>
        public void sendRaw(string text)
        {
            var udpClient = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 9760);
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);
            udpClient.Send(send_buffer,send_buffer.Length, endPoint);
        }


    }
}
