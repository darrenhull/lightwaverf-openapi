using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LightwaveRF;

namespace LightwaveConsole
{
    class Program
    {
        static int Main(string[] args)
        {
            string message = "";
            if (args.Length > 0)
            {
                try
                {
                    switch (args[0].ToLowerInvariant())
                    {
                        case "device":
                            System.Console.WriteLine(LightwaveRF.API.DeviceOnOff(int.Parse(args[1]), int.Parse(args[2]), StateStrings.GetStateFromString(args[3])));
                            return 0;
                        case "dim":
                            System.Console.WriteLine(LightwaveRF.API.Dim(int.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3])));
                            return 0;
                        case "heat":
                            System.Console.WriteLine(LightwaveRF.API.HeatOnOff(int.Parse(args[1]), StateStrings.GetStateFromString(args[2])));
                            return 0;
                        case "room":
                            System.Console.WriteLine(LightwaveRF.API.AllOff(int.Parse(args[1])));
                            return 0;
                        case "mood":
                            System.Console.WriteLine(LightwaveRF.API.Mood(int.Parse(args[1]), int.Parse(args[2])));
                            return 0;
                        case "storemood":
                            System.Console.WriteLine(LightwaveRF.API.SaveMood(int.Parse(args[1]), int.Parse(args[2])));
                            return 0;
                        case "raw":
                            System.Console.WriteLine(LightwaveRF.API.sendRaw(args[1]));
                            return 0;
                        case "listen":
                            LightwaveRF.API.Listen();
                           // x.OnResponse += new responseEventHandler(x_OnResponse);
                            LightwaveRF.API.Raw += new rawEventHandler(x_OnResponse);
                            while( Console.ReadLine() == "")
                            {

                            }
                            return 0;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }

            }
            if (message == "Index was outside the bounds of the array.") message = "Not enough arguments.";
            if (message != "") System.Console.WriteLine(message); System.Console.WriteLine();
            System.Console.WriteLine("Usage:");
            System.Console.WriteLine("switch device on or off   : LightwaveConsole Device    <room> <device> <state>");
            System.Console.WriteLine("dim device                : LightwaveConsole Dim       <room)> <device> <state>");
            System.Console.WriteLine("heating device            : LightwaveConsole Heat      <room> <state>");
            System.Console.WriteLine("All in room off           : LightwaveConsole Room      <room>");
            System.Console.WriteLine("Set mood in room          : LightwaveConsole Mood      <room> <mood>");
            System.Console.WriteLine("Store mood in room        : LightwaveConsole StoreMood <room> <mood>");
            System.Console.WriteLine("Send Raw data to wifi     : LightwaveConsole Raw       <Datatosend>");
            System.Console.WriteLine("listen for other commands : LightwaveConsole Listen");
            System.Console.WriteLine();
            System.Console.WriteLine("eg:");
            System.Console.WriteLine("LightwaveConsole Device 1 1 1");
            System.Console.WriteLine("LightwaveConsole Dim 1 1 100");
            System.Console.WriteLine("LightwaveConsole Heat 1 0");
            System.Console.WriteLine("LightwaveConsole Room 1 ");
            System.Console.WriteLine("LightwaveConsole Mood 1 1");
            System.Console.WriteLine("LightwaveConsole StoreMood 1 1");
            System.Console.WriteLine("LightwaveConsole Raw 533!R1D1F1");
            return 1;
        }

        static void x_OnResponse(object sender, string Data)
        {
            System.Console.WriteLine(Data);
        }
    }
}
