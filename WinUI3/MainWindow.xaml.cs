using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUiApp1;

/// <summary>
/// Main window
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        this.ExtendsContentIntoTitleBar = true;
    }

    private void rootGrid_Loaded(object sender, RoutedEventArgs e)
    {
        if (AppWindowTitleBar.IsCustomizationSupported())
        {
            var titleBar = this.AppWindow.TitleBar;
            titleBar.PreferredHeightOption = TitleBarHeightOption.Tall;
            UpdateTitleBarButtonsColor(((FrameworkElement)sender).ActualTheme);
        }
    }

    private void SystemThemeMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (this.Content is FrameworkElement rootElement)
        {
            rootElement.RequestedTheme = ElementTheme.Default;
            UpdateTitleBarButtonsColor(rootElement.ActualTheme);
        }
    }

    private void LightThemeMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (this.Content is FrameworkElement rootElement)
        {
            rootElement.RequestedTheme = ElementTheme.Light;
            UpdateTitleBarButtonsColor(rootElement.ActualTheme);
        }
    }

    private void DarkThemeMenuItem_Click(object sender, RoutedEventArgs e)
    {
        if (this.Content is FrameworkElement rootElement)
        {
            rootElement.RequestedTheme = ElementTheme.Dark;
            UpdateTitleBarButtonsColor(rootElement.ActualTheme);
        }
    }

    public void UpdateTitleBarButtonsColor(ElementTheme actualTheme)
    {
        // Without this code the caption buttons foreground color is not updated,
        // making them not visible when the new theme is different from the inital theme. 
        // This issue occurs with the default system theme too if
        // "Show accent color in title bars" is enabled in Windows settings,
        // because the custom title bar doesn't follow that setting,
        // so we call this function when the window is loaded too.

        // We should update the hover and pressed colors too,
        // but since in that case both foreground and background stick to the old theme,
        // the buttons are still visible, so not a big issue.
        if (AppWindowTitleBar.IsCustomizationSupported())
        {
            var titleBar = this.AppWindow.TitleBar;
            if (actualTheme == ElementTheme.Light)
            {
                titleBar.ButtonForegroundColor = Colors.Black;
            }
            else
            {
                titleBar.ButtonForegroundColor = Colors.White;
            }
        }
    }

    private void NewWindowMenuItem_Click(object sender, RoutedEventArgs e)
    {
        var window = new MainWindow();
        window.Activate();
    }

    private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void StatusBarMenuItem_Click(object sender, RoutedEventArgs e)
    {
        statusBar.Visibility = (sender as ToggleMenuFlyoutItem)?.IsChecked == true ? 
                                    Visibility.Visible : 
                                    Visibility.Collapsed;
    }
}
