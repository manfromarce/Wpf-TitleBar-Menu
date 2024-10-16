using System;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace AvaloniaApplication1;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void QuitMenuItem_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    public void NewWindowMenuItem_Click(object? sender, EventArgs args)
    {
        var window = new MainWindow();
        window.Show();
    }

    public void FullScreen_Click(object? sender, EventArgs args)
    {
        this.WindowState = (this.WindowState == WindowState.FullScreen ? WindowState.Maximized : WindowState.FullScreen);
    }

    public void SystemTheme_Click(object? sender, EventArgs args)
    {
        App.Current.RequestedThemeVariant = ThemeVariant.Default;       
    }

    public void LightTheme_Click(object? sender, EventArgs args)
    {
        App.Current.RequestedThemeVariant = ThemeVariant.Light;
    }

    public void DarkTheme_Click(object? sender, EventArgs args)
    {
        App.Current.RequestedThemeVariant = ThemeVariant.Dark;
    }
}