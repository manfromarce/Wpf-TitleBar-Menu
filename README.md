## Custom title bar with menu in WPF

This demo app shows how to create a custom Visual Studio-inspired title bar in WPF.
It provides a sample main menu which wraps in multiple lines when needed and allows to add additional buttons and content, while retaining most of the Windows title bar features.

Limitation: Windows 11 snap UI isn't displayed when hovering over the Maximize button. It should be possible to implement it using the Win32 API, see [this issue](https://github.com/dotnet/wpf/issues/4825). Users can still press Win+Z to show the snap layouts popup.

#### How to use:
- clone this repo or [download](https://github.com/manfromarce/Wpf-TitleBar-Menu/archive/refs/heads/main.zip) the source code as ZIP
- tweak the code in MainWindow.xaml and App.xaml to suit your needs. By default, the sample title bar contains an additional Settings button near the minimize button, and displays the window icon and title. You can easily remove or replace these elements, while most colors can be customized in App.xaml.

#### Screenshot
![immagine](https://user-images.githubusercontent.com/45036600/198058879-33227451-6459-4591-9ca4-87113ce9d2ef.png)


