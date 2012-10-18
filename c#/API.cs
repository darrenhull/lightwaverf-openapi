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
    public delegate void OnOffEventHandler(object sender, int room, int device, State state);
    public delegate void AllOffEventHandler(object sender, int room);
    public delegate void moodEventHandler(object sender, int room, int mood);
    public delegate void dimEventHandler(object sender, int room,int device, int pct);
    public delegate void heatEventHandler(object sender, int room, State state);
    public delegate void rawEventHandler(object sender, string rawData);
    public delegate void responseEventHandler(object sender, string Data);
    public static class API
    {
        private static string RecordedSequence = "";
        private static string RecordedSequenceName = "";
        private static Thread recordsequencethread = null;
        public static int radiatorRefreshMins = 20;
        public static TimeSpan keepRadiatorStatefor = new TimeSpan(1, 0, 0, 0);

        public static bool MaintainRadiatorState
        {
            get
            {
                if(radiatorStateThread != null)
                {
                    if (radiatorStateThread.ThreadState == ThreadState.Aborted || radiatorStateThread.ThreadState == ThreadState.Stopped || radiatorStateThread.ThreadState == ThreadState.WaitSleepJoin)
                    {
                        radiatorStateThread = null;
                    }
                }
                return radiatorStateThread != null;
            }
            set
            {
                if (value)
                {
                    KeepRadiatorState(radiatorRefreshMins, DateTime.Now.Add(keepRadiatorStatefor));
                }
                else
                {
                    radiatorStateThread.Abort();
                    radiatorStateThread = null;
                }
            }
        }
        private static Thread radiatorStateThread = null;
        private static int radiatorStateRefreshMins = 10;
        private static DateTime radiatorStateUntilDate;
        private static Dictionary<string,Device> LastDeviceState = new Dictionary<string,Device>();
        public static    List<Room> Rooms;
        public static List<Device> Devices;
        public static Dictionary<string, Device> GetDevices
        {
            get
            {
                return LastDeviceState;
            }
        }

        /// <summary>
        /// index used for requests to the wifilink
        /// </summary>
        static int ind = -999;
        /// <summary>
        /// get the next index and return it.
        /// </summary>
        private static string nextind
        {
            get
            {
                if (ind == -999)//index not yet initialised. - set it to a random number.
                {
                    Random r = new Random();
                    ind = r.Next(999);
                }
                ind++;
                if (ind > 999) ind = 1;
                return(ind.ToString("000"));
            }
        }
        private static Thread listenthread;
        public static event OnOffEventHandler OnOff;
        /// <summary>
        /// Regex for on/off
        /// matches :Room, Device, and State
        /// </summary>
        public const string OnOffRegEx ="...,(!R)(?<Room>[0-9])(D)(?<Device>[0-9])(F)(?<State>[0-1])";
        public static event AllOffEventHandler OnAllOff;
        /// <summary>
        /// Regex for All off
        /// Matches: Room
        /// </summary>
        public const string allOffRegEx = "...,(!R)(?<Room>[0-9])(Fa)";
        public static event moodEventHandler OnMood;
        /// <summary>
        /// Regex for Mood
        /// Matches: Room, Mood
        /// </summary>
        public const string moodRegEx = "...,(!R)(?<Room>[0-9])(FmP)(?<mood>[0-9])";//"533,!R"+ Room + "FmP" + mood + "|"
        public static event dimEventHandler OnDim;
        /// <summary>
        /// Regex for Dim
        /// Matches: Room, Device, State
        /// </summary>
        public const string dimRegEx = "...,(!R)(?<Room>[0-9])(D)(?<Device>[0-9])(FdP)(?<State>[0-9][0-9])";//"533,!R" + Room + "D" + Device + "FdP" + pstr + "|"
        public static event heatEventHandler OnHeat;
        /// <summary>
        /// Regex for Heat commands
        /// Matches: Room, State.
        /// </summary>
        public const string heatRegEx = "...,(!R)(?<Room>[0-9])(DhF)(?<State>[0-9])";//"533,!R" + Room + "DhF" + statestr + "|";
        public static event rawEventHandler Raw;
        /// <summary>
        /// Listen for commands from other devices (and this device)
        /// </summary>
        public static void Listen()
        {
            if (listenthread == null)
            {
                listenthread = new Thread(new ThreadStart(listenThreadWorker));
                //responsethread = new Thread(new ThreadStart(responseThreadWorker));
                listenthread.Start();
                //responsethread.Start();
            }
        }

        public static void updateLastDeviceState(Device thisDevice)
        {
            lock (LastDeviceState)
            {
                if (LastDeviceState.ContainsKey(thisDevice.deviceIdentifier)) LastDeviceState.Remove(thisDevice.deviceIdentifier);
                LastDeviceState.Add(thisDevice.deviceIdentifier, thisDevice);
            }
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns>full string response from wifilink</returns>
        private static string getResponse()
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
        private static void listenThreadWorker()
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
                    if(Raw !=null) Raw(null,stringData);
                    Match OnOffMatch = new Regex(OnOffRegEx).Match(stringData);
                    Match AllOffMatch = new Regex(allOffRegEx).Match(stringData);
                    Match MoodMatch = new Regex(moodRegEx).Match(stringData);
                    Match DimMatch = new Regex(dimRegEx).Match(stringData);
                    Match HeatMatch = new Regex(heatRegEx).Match(stringData);
                    if (OnOffMatch.Success)
                    {
                        var thisDevice = new Device(new Room(int.Parse(OnOffMatch.Groups["Room"].Value)), int.Parse(OnOffMatch.Groups["Device"].Value),"Dev " + int.Parse(OnOffMatch.Groups["Device"].Value),DeviceType.OnOff, StateStrings.GetStateFromString(OnOffMatch.Groups["State"].Value));
                        updateLastDeviceState(thisDevice);
                        if (OnOff != null)
                        {
                            OnOff(null, thisDevice.room.RoomNum, thisDevice.devicenum, thisDevice.state);
                        }
                    }
                    if (AllOffMatch.Success && OnAllOff!=null)
                    {
                        OnAllOff(null, int.Parse(AllOffMatch.Groups["Room"].Value));
                    }
                    if (MoodMatch.Success && OnMood!=null)
                    {
                        OnMood(null, int.Parse(MoodMatch.Groups["Room"].Value), int.Parse(MoodMatch.Groups["Mood"].Value));
                    }
                    if (DimMatch.Success)
                    {
                        var thisDevice = new Device(new Room(int.Parse(DimMatch.Groups["Room"].Value)), int.Parse(DimMatch.Groups["Device"].Value), "Dev " + int.Parse(DimMatch.Groups["Device"].Value), DeviceType.OnOff, StateStrings.GetStateFromString(DimMatch.Groups["State"].Value));
                        updateLastDeviceState(thisDevice);
                        if (OnDim != null)
                        {
                            OnDim(null, thisDevice.room.RoomNum, thisDevice.devicenum, thisDevice.DimLevel);
                        }
                    }
                    if (HeatMatch.Success)
                    {
                        var thisDevice = new Device(new Room(int.Parse(HeatMatch.Groups["Room"].Value)), 0, "Rad " + int.Parse(HeatMatch.Groups["Room"].Value), DeviceType.Radiator, StateStrings.GetStateFromString(DimMatch.Groups["State"].Value));
                        updateLastDeviceState(thisDevice);
                        if (OnHeat != null)
                        {
                            OnHeat(null, thisDevice.room.RoomNum, thisDevice.state);
                        }
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
        /// <returns>String "OK" otherwise error message</returns>
        public static string AllOff(int room, string message = "")
        {
            string text = nextind + ",!R" + room + @"Fa|" + message;
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// capture commands and store them as a sequence. 
        /// will listen for 1 minute after it is told to do this, and record all the commands in that minute to a sequence
        /// </summary>
        /// <param name="SequenceName"></param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string RecordSequence(string SequenceName)
        {
            if (recordsequencethread == null || recordsequencethread.ThreadState==ThreadState.Stopped)
            {
                RecordedSequenceName = SequenceName;
                recordsequencethread = new Thread(new ThreadStart(recordSequenceWorker));
                recordsequencethread.Start();
                return "Recording for 20 seconds and will save as " + SequenceName;
            }
            return "All ready recording" + RecordedSequenceName + ", wait till that is finished";
        }

        /// <summary>
        /// capture commands for 20 seconds and store them in the sequence
        /// </summary>
        private static void recordSequenceWorker()
        {
            try
            {
                RecordedSequence = nextind + "!FeP\"" + RecordedSequenceName + "\"=";
                Raw += AddEventToSequence;
                Listen();
                System.Threading.Thread.Sleep(20000);
                RecordedSequence = RecordedSequence.Substring(0,RecordedSequence.Length -1);
                Raw -= AddEventToSequence;
                sendRaw(RecordedSequence);
                RecordedSequence = "";
            }
            finally
            {
            }
        }
        private static void AddEventToSequence(object sender, string rawData)
        {
            //!FeP"Test"=!R1D1F1,00:00:03,!R1Fa,00:00:03,!R1D2F0,00:00:03
            //remove any comments that would be displayed on the wifilink - they are not allowed in a sequence.
            int endchar;
            if (rawData.Contains("|"))
                endchar = rawData.IndexOf('|') - 4;
            else
                endchar = rawData.Length -4;

            string command = rawData.Substring(4,endchar);
            RecordedSequence = RecordedSequence + command +",00:00:03,";
        }

        /// <summary>
        /// Delete named sequence
        /// </summary>
        /// <param name="SequenceName"></param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string deleteSequence(string SequenceName)
        {
            string text = nextind + ",!FxP\"" + SequenceName +"\"";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// runs a sequence at the specified time
        /// </summary>
        /// <returns></returns>
        public static string saveTimer(string timername, string SequenceName, DateTime AtDateTime)
        {
            //130,!FiP"T20120920233337"=!FqP"Test",T01:20,S25/09/12
            DateTime now = DateTime.Now;
            string atdatetimeformatted = "T" + AtDateTime.Hour.ToString("00") + ":" + AtDateTime.Minute.ToString("00") + ",S" + AtDateTime.Day.ToString("00") + "/" + AtDateTime.Month.ToString("00") + "/" + AtDateTime.Day.ToString("00");
            string formattednowstring = "T" + now.Year.ToString("0000") + now.Month.ToString("00") + now.Day.ToString("00") + now.Hour.ToString("00") + now.Minute.ToString("00") + now.Second.ToString("00");
            string text = nextind + "!FiPT\"" + timername +"\"=FqP\"" + SequenceName + "\"," + atdatetimeformatted;
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timername"></param>
        /// <returns></returns>
        public static string cancelTimer(string timername)
        {
            //440,!FiP"T20120920234815"=!FqP"Test",T00:50,E20/11/12,S01/00/00
            //441,!FxP"T201209202348"
            string text = "!FxP\"" + timername + "\"";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// Start named sequence
        /// </summary>
        /// <param name="SequenceName"></param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string startSequence(string SequenceName)
        {
            string text =nextind + "!FqP\"" + SequenceName +"\"|Start Sequence|\"" + SequenceName +"\"";
            return sendRaw(text).Replace(ind + ",", "");
        }
        /// <summary>
        /// sets mood in room
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="mood">mood number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string Mood(int room, int mood)
        {
            string text = nextind + ",!R"+ room + @"FmP" + mood + @"|Room " + room.ToString() + " Mood " + mood.ToString();
            return sendRaw(text).Replace(ind + ",", "");
        }
        /// <summary>
        /// Save the mood preset
        /// </summary>
        /// <param name="room">room number </param>
        /// <param name="mood">mood number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string SaveMood(int room, int mood)
        {
            string text = nextind + ",!R"+ room + @"FsP" + mood + @"|MOOD NOW SET";
            return sendRaw(text).Replace(ind + ",", "");
        }
        /// <summary>
        /// Get reading from the wireless meter.
        /// </summary>
        public static MeterReading GetMeterReading()
        {
            string text = nextind + ",@?W";
            return new MeterReading(sendRaw(text).Substring(4)); //Replace(ind + ",", "");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="percent">percentage level for the dim< eg. 50/param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string Dim(int room, int device, int percent)
        {
            string pstr;
            if (percent == 0) percent = 1;
            pstr = Math.Round(((double)percent / 100 * 32)).ToString();
            string text = nextind + ",!R" + room + @"D" + device + @"FdP" + pstr + @"|";
            return sendRaw(text).Replace(ind + ",", "");
        }
        /// <summary>
        /// send on/off command to a room/device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <param name="state">state (0 or 1)</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static  string DeviceOnOff(int room, int device, State state)
        {
            string text = nextind + ",!R" + room + @"D" + device + @"F" + StateStrings.GetStateString(state) + @"|";
            return sendRaw(text).Replace(ind + ",", "");
        }
        /// <summary>
        /// send on/off command to a room/device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="state">state 1 = on 0 = off</param>
        /// <param name="message">message to display on wifilink</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string HeatOnOff(int room, State state, string message = "")
        {
            string text = nextind + ",!R" + room + @"DhF" + StateStrings.GetStateString(state) + @"|" + message;
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// Switch on/off the central heating
        /// </summary>
        /// <param name="state">0=off 1=on</param>
        /// <param name="message">mesage to display on wifilink</param>
        /// <returns></returns>
        public static string CentralHeatOnOff(State state, string message = "")
        {
            string text = nextind + ",!R16D1F" + StateStrings.GetStateString(state) + @"|" + message;
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// Switch on/off the hot water
        /// </summary>
        /// <param name="state">0=off 1=on</param>
        /// <param name="message">mesage to display on wifilink</param>
        /// <returns></returns>
        public static string HotWaterOnOff(State state, string message = "")
        {
            string text = nextind + ",!R16D2F" + StateStrings.GetStateString(state) + @"|" + message;
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// Switch off heat in all rooms
        /// </summary>
        /// <returns></returns>
        public static string AllHeat(State state)
        {
            string retval = "";
            for (int room = 1; room <= 8; room++)
            {
                string ret = HeatOnOff(room, state, "All Heat");
                if (ret != "OK") retval = retval + ret + ";";
                Thread.Sleep(6000);
            }
            if(retval == "") retval = "OK";//all ok so return ok
            return retval;
        }

        /// <summary>
        /// Switch off all devices in all rooms
        /// </summary>
        /// <returns></returns>
        public static string AllDevicesOff()
        {
            string retval = "";
            for (int room = 1; room <= 8; room++)
            {
                string ret = AllOff(room, "All Devices Off");
                if (ret != "OK") retval = retval + ret + ";";
                Thread.Sleep(800);
            }
            if (retval == "") retval = "OK";//all ok so return ok
            return retval;
        }

        /// <summary>
        /// lock the manual switch of a device (eg socket)
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string ManualLockDevice(int room, int device)
        {
            string text = nextind + ",!R" + room + @"D" + device + "Fk|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// full lock the device (eg socket) (wifi, and radio)
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string FullLockDevice(int room, int device)
        {
            string text = nextind + ",!R" + room + @"D" + device + "Fl|";
            return sendRaw(text).Replace(ind + ",", "");
        }
                /// <summary>
        /// unlock device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string UnLockDevice(int room, int device)
        {
            string text = nextind + ",!R" + room + @"D" + device + "Fu|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// open the device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string OpenDevice(int room, int device)
        {
            string text = nextind + ",!R" + room + @"D" + device + "F)|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// close the device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string CloseDevice(int room, int device)
        {
            string text = nextind + ",!R" + room + @"D" + device + "F(|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// stop the device
        /// </summary>
        /// <param name="Room">room number </param>
        /// <param name="Device">device number</param>
        /// <returns>String "OK" otherwise error message</returns>
        public static string StopDevice(int room, int device)
        {
            string text = nextind + ",!R" + room + @"D" + device + "F^|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// Cancels all sequences and timers in the wifilink box
        /// </summary>
        /// <returns>String "OK" otherwise error message</returns>
        public static string CancelAllSequencesAndTimers()
        {
            string text = nextind + ",!FcP\"*\"|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// Delete all sequences and timers in the wifilink box
        /// </summary>
        /// <returns>String "OK" otherwise error message</returns>
        public static string DeleteAllSequencesAndTimers()
        {
            string text = nextind + ",!FxP\"*\"|";
            return sendRaw(text).Replace(ind + ",", "");
        }

        /// <summary>
        /// 
        /// </summary>
        private static void RadiatorStateWorker()
        {
            while (radiatorStateUntilDate > DateTime.Now)
            {
                lock (LastDeviceState)
                {
                    foreach (var item in LastDeviceState)
                    {
                        if (item.Value.deviceType == DeviceType.Radiator)
                        {
                            if (item.Value.state == State.Off)
                            {
                                HeatOnOff(item.Value.room.RoomNum, item.Value.state, "API R State");
                                Thread.Sleep(7000);//Radiators take a while for the command....
                            }
                        }
                    }
                }
                Thread.Sleep(radiatorStateRefreshMins * 60000);
            }
        }

        /// <summary>
        /// listens for radiator off commands and resends them until an on command is received 
        /// (workaround for air bug in old lightwaverf valves - and pegler Itemp terriers).
        /// </summary>
        /// <param name="minutesToRefresh">number of minutes to wait before refreshing the state of the valves.</param>
        /// 
        /// <returns></returns>
        private static void KeepRadiatorState(int refreshMins, DateTime untilDate)
        {
            Listen();
            radiatorStateUntilDate = untilDate;
            radiatorStateRefreshMins = refreshMins;
            if (radiatorStateThread == null || radiatorStateThread.ThreadState == ThreadState.Stopped)
            {
                radiatorStateThread = new Thread(new ThreadStart(RadiatorStateWorker));
                radiatorStateThread.Start();
            }
        }

        /// <summary>
        /// Send raw packet containing 'text' to the wifilink
        /// </summary>
        /// <param name="text">contents of packet.</param>
        public static string sendRaw(string text)
        {
            var udpClient = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 9760);
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);
            udpClient.Send(send_buffer, send_buffer.Length, endPoint);
            return getResponse().Replace(ind + ",", "").Trim();
        }
    }
}
