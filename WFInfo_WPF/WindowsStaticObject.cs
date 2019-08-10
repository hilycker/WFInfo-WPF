using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WFInfo_WPF
{
    public static class WindowsStaticObject
    {
        private static MainWindow mainWindow;
        public static MainWindow MainWindow
        {
            get { return mainWindow; }
            set { mainWindow = value; }
        }

        private static SettingsWindow settingsWindow = new SettingsWindow();
        public static SettingsWindow SettingsWindow
        {
            get { return settingsWindow; }
            set { settingsWindow = value; }
        }

        private static Window testWindow = null;
        public static Window TestWindow
        {
            get { return testWindow; }
            set { testWindow = value; }
        }

        private static TaskbarIcon trayIcon;
        public static TaskbarIcon TrayIcon
        {
            get { return trayIcon; }
            set { trayIcon = value; }
        }

    }
}
