using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public static class NativeHelpers
    {
        public const int WM_NCHITTEST = 0x0084;
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int WM_NCLBUTTONUP = 0x00A2;
        public const int WM_NCLBUTTONDBLCLK = 0x00A3;
        public const int WM_GETMINMAXINFO = 0x0024;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int HTMAXBUTTON = 9;

        public static bool IsSnapLayoutEnabled()
        {
            if (!IsWindows11())
            {
                return false;
            }

            using RegistryKey? key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
            object? registryValueObject = key?.GetValue("EnableSnapAssistFlyout");

            if (registryValueObject == null)
            {
                return true;
            }

            int registryValue = (int)registryValueObject;

            return registryValue > 0;
        }

        public static bool IsWindows11()
        {
            return Environment.OSVersion.Version.Major == 10 &&
                Environment.OSVersion.Version.Minor == 0 && 
                Environment.OSVersion.Version.Build >= 22000;
        }
    } 
}
