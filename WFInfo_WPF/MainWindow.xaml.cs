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
        public MainWindow()
        {
            InitializeComponent();
            WindowsStaticObject.MainWindow = this;
            this.titleBar.MouseDown += titleBarMouseDown;
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

            if (settingsWindow == null)
            {
                settingsWindow = new SettingsWindow();
            } else if (settingsWindow.Visibility == Visibility.Visible) {
                settingsWindow.Hide();
                return;
            }

            if(SystemParameters.PrimaryScreenWidth - (mainWindow.Left +  mainWindow.Width) < settingsWindow.Width)
            {
                settingsWindow.Left = mainWindow.Left - settingsWindow.Width - 10;
            } else
            {
                settingsWindow.Left = mainWindow.Left + mainWindow.Width + 10;
            }

            if (SystemParameters.PrimaryScreenHeight - (mainWindow.Top + mainWindow.Height) < settingsWindow.Height)
            {
                settingsWindow.Top = mainWindow.Top - (settingsWindow.Height - mainWindow.Height);
            } else
            {
                settingsWindow.Top = mainWindow.Top;
            }

            settingsWindow.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Application.Current.Shutdown();
        }

        //[DllImport("user32.dll")]
        //private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        //[DllImport("user32.dll")]
        //private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        //private const int GWL_STYLE = -16;
        //private const int WS_MAXIMIZEBOX = 0x10000;

        //private void Window_SourceInitialized(object sender, EventArgs e)
        //{
        //    var hwnd = new WindowInteropHelper((Window)sender).Handle;
        //    var value = GetWindowLong(hwnd, GWL_STYLE);
        //    SetWindowLong(hwnd, GWL_STYLE, (int)(value & ~WS_MAXIMIZEBOX));
        //}
    }
}
