## Custom title bar with menu in WPF

This demo app shows how to create a custom title bar in WPF while staying consistent with the default Windows title bar as most as possible.

It is inspided by Visual Studio and provides a simple main menu which wraps its contents when the window is shrinked, a custom Settings button, and the standard Minimize, Maximize/Restore and Close buttons.

Windows 11 snap layouts are now also supported when hovering on the Maximize button.

#### How to use:
- Clone this repo or [download](https://github.com/manfromarce/Wpf-TitleBar-Menu/archive/refs/heads/main.zip) the source code as ZIP
- Tweak the code to suit your needs. Most colors are defined in App.xaml, while the title bar can be customized in MainWindow
- Just remember to set `WindowChrome.IsHitTestVisible="True"` on any custom control added to the title bar, and don't change the WindowChrome or native code unless you know what you're doing

#### Screenshot
![immagine](https://user-images.githubusercontent.com/45036600/198058879-33227451-6459-4591-9ca4-87113ce9d2ef.png)


