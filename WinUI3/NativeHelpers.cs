using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;

namespace WinUiApp1;

public static class NativeHelpers
{
    public static IntPtr GetWindowHandle(Window window)
    {
        return WinRT.Interop.WindowNative.GetWindowHandle(window);
    }
}
