using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WFInfo_WPF.ResourceDictionaries
{
    public partial class TrayIconDictionary : ResourceDictionary
    {
        private void SettingsTray_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = WindowsStaticObject.MainWindow;
            Window settingsWindow = WindowsStaticObject.SettingsWindow;

            if (settingsWindow.Visibility == Visibility.Visible)
            {
                settingsWindow.Hide();
                return;
            } else if (mainWindow.Visibility == Visibility.Visible)
            {
                if (SystemParameters.PrimaryScreenWidth - (mainWindow.Left + mainWindow.Width) < settingsWindow.Width)
                {
                    settingsWindow.Left = mainWindow.Left - settingsWindow.Width - 10;
                }
                else
                {
                    settingsWindow.Left = mainWindow.Left + mainWindow.Width + 10;
                }

                if (SystemParameters.PrimaryScreenHeight - (mainWindow.Top + mainWindow.Height) < settingsWindow.Height)
                {
                    settingsWindow.Top = mainWindow.Top - (settingsWindow.Height - mainWindow.Height);
                }
                else
                {
                    settingsWindow.Top = mainWindow.Top;
                }

                settingsWindow.Show();
            } else
            {
                settingsWindow.Left = (SystemParameters.PrimaryScreenWidth / 2) - (settingsWindow.Width / 2);
                settingsWindow.Top = (SystemParameters.PrimaryScreenHeight / 2) - (settingsWindow.Height / 2);
                settingsWindow.Show();
            }
        }

        private void ShowTray_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = WindowsStaticObject.MainWindow;
            Window settingsWindow = WindowsStaticObject.SettingsWindow;

            if (mainWindow.Visibility == Visibility.Visible)
            {

            } else
            {
                mainWindow.Show();
                WindowsStaticObject.TrayIcon.Visibility = Visibility.Collapsed;
            }
        }

        }
}
