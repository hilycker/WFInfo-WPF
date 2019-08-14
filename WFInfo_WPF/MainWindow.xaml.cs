using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WFInfo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskbarIcon trayIcon;
        public MainWindow()
        {
            InitializeComponent();
            WindowsStaticObject.MainWindow = this;
            this.titleBar.MouseDown += titleBarMouseDown;

            //initialize NotifyIcon
            WindowsStaticObject.TrayIcon = (TaskbarIcon)FindResource("TrayIcon");
            trayIcon = WindowsStaticObject.TrayIcon;
            trayIcon.Visibility = Visibility.Collapsed;

        }

        private void titleBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void SettingsIcon_Click(object sender, MouseEventArgs e)
        {
            Window mainWindow = WindowsStaticObject.MainWindow;
            Window settingsWindow = WindowsStaticObject.SettingsWindow;

            if (settingsWindow.Visibility == Visibility.Visible)
            {
                settingsWindow.Hide();
                return;
            }

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
        }

        private void EquipmentIcon_Click(object sender, MouseEventArgs e)
        {
            Window mainWindow = WindowsStaticObject.MainWindow;
            Window equipmentWindow = WindowsStaticObject.EquipmentWindow;

            if (equipmentWindow.Visibility == Visibility.Visible)
            {
                equipmentWindow.Hide();
                return;
            }

            if (SystemParameters.PrimaryScreenWidth - (mainWindow.Left + mainWindow.Width) < equipmentWindow.Width)
            {
                equipmentWindow.Left = mainWindow.Left - equipmentWindow.Width - 10;
            }
            else
            {
                equipmentWindow.Left = mainWindow.Left + mainWindow.Width + 10;
            }

            if (SystemParameters.PrimaryScreenHeight - (mainWindow.Top + mainWindow.Height) < equipmentWindow.Height)
            {
                equipmentWindow.Top = mainWindow.Top - (equipmentWindow.Height - mainWindow.Height);
            }
            else
            {
                equipmentWindow.Top = mainWindow.Top;
            }

            equipmentWindow.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Application.Current.Shutdown();
        }

        private void IconButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            trayIcon.Visibility = Visibility.Visible;
        }

    }
}
