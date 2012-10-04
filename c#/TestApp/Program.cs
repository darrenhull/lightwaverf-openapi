using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TestApp
{
    static class Program
    {
        static private NotifyIcon trayIcon;
        static private ContextMenu trayMenu;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("API", OnAPI);
            trayMenu.MenuItems.Add("Heating", OnHeating);
            trayMenu.MenuItems.Add("Exit", OnExit);
            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon      = new NotifyIcon();
            trayIcon.Text = "LightwaveRF API";
            trayIcon.Icon = new Icon(SystemIcons.WinLogo, 40, 40);
            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible     = true;
            Application.Run();
        }

        static private void OnAPI(object sender, EventArgs e)
        {
            var x = new Form1();
            x.Show();
        }

        static private void OnHeating(object sender, EventArgs e)
        {
            var x = new HeatControl();
            x.Show();
        }

        static private void OnExit(object sender, EventArgs e)
        {
            trayIcon.Dispose();
            Application.Exit();
        }

    }
}
