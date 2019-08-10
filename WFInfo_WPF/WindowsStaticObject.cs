using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static SettingsWindow settingsWindow;
        public static SettingsWindow SettingsWindow
        {
            get { return settingsWindow; }
            set { settingsWindow = value; }
        }

    }
}
