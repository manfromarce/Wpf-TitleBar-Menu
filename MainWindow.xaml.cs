using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMaximizeRestoreButtonClick(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(this);
            } else
            {
                SystemCommands.MaximizeWindow(this);
            }
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void QuitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewWindowMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var w = new MainWindow();
            w.WindowState = WindowState.Normal;
            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            w.Show();
        }

        private void maximizeRestoreButton_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            maximizeRestoreButton.ToolTip = WindowState == WindowState.Normal ? "Maximize" : "Restore";
        }
    }
}
