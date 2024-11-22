## Custom title bar with menu in C# frameworks (WPF, AvaloniaUI, WinUI 3)

These demo apps show how to create a custom title bar in WPF, Avalonia and WinUI 3 while staying consistent with the default system title bar as most as possible.

It is inspided by Visual Studio and provides a simple main menu which wraps its contents when the window is shrinked, a custom button, and the standard Minimize, Maximize/Restore and Close buttons.

Windows 11 snap layouts are also supported when hovering on the Maximize button, except in the Avalonia project (see below).

#### How to use:

- Clone this repo or [download](https://github.com/manfromarce/Wpf-TitleBar-Menu/archive/refs/heads/main.zip) the source code as ZIP.

- Different project (and solution files) are provided for WPF, Avalonia and WinUI 3, use the one you prefer or need.

- Tweak the code based on your needs.
  
  - WPF: the system chrome is used so that moving / resizing the window didn't need to be reimplemented, but the title bar (including minimize/maximize/close buttons) is completely replaced. Most colors are defined in App.xaml, while the layout can be customized from MainWindow. Just remember to set `WindowChrome.IsHitTestVisible="True"` on any custom control added to the title bar, and don't change the WindowChrome or native code unless you know what you're doing.
  
  - WinUI 3: the framework allows to add custom controls to the native title bar, so all system features are supported out-of-the-box and don't need to be reimplemented. However, if you want to change the app theme at runtime, the non-client area foreground color needs to be manually updated using the AppWindowTitleBar APIs (sample code for this is included).
  
  - AvaloniaUI:
    
    - **Windows**: title bar buttons which emulate the Windows style are provided by Avalonia itself when using ExtendClientAreaToDecorationsHint, so we don't need to manually implement them, but Windows 11 snap layout are not supported (will be solved in Avalonia 11.3).
    
    - **MacOS**: the menu bar is hidden, as the native global menu is used. For this reason, I have disabled the title bar customization. On MacOS most applications stick to the system title bar. If you prefer to customize the title bar anyway, you can change the OnPlatform markup extensions to set ExtendClientAreaToDecorationsHint = true on MacOS too, but keep in mind that the system title bar is smaller and the blank area used for caption buttons should be on the left rather than on the right.
    
    - **Linux**: The menu bar is displayed below the native title bar, because Avalonia doesn't support client decorations on Linux yet. It will probably be implemented in the future for Wayland GNOME which does not support server decorations, but for other desktop environments it would break a lot of native stuff.

##### Possible improvements

- WPF: Add fluent light / dark theme via .NET 9

- WinUI 3: Enforce minimum window size; add title TextBlock

- Avalonia: Implement native context menu for the Windows title bar; add title TextBlock; implement keyboard shortcuts (only displayed at the moment)

#### Screenshot

WPF:
![image](https://github.com/manfromarce/Wpf-TitleBar-Menu/assets/45036600/245562ea-d7de-4b31-97e2-3d5dfe52f89e)

WinUI 3:
![Immagine 2024-10-16 020339](https://github.com/user-attachments/assets/014b2e2d-8eab-40ec-aeba-bae39873acac)

Avalonia:
![2024-11-10 133309](https://github.com/user-attachments/assets/6c7a3f23-578d-4366-86ba-6a074877735b)

