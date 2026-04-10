using System;
using CommunityToolkit.Mvvm.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PracticaGymTracker.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _currentLanguage = "ua";

    [RelayCommand]
    private void ToggleLanguage()
    {
        CurrentLanguage = CurrentLanguage == "ua" ? "en" : "ua";

        ChangeLanguageDictionaries(CurrentLanguage);
    }

    private void ChangeLanguageDictionaries(string langCode)
    {
        var app = Application.Current;
        if (app == null) return;
        
        string path = $"avares://PracticaGymTracker/Resources/Strings.{langCode}.axaml";
        
        try
        {
            var newDict = (ResourceDictionary)Avalonia.Markup.Xaml.AvaloniaXamlLoader.Load(new Uri(path));

            app.Resources.MergedDictionaries.Clear();
            app.Resources.MergedDictionaries.Add(newDict);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка завантаження мови: {ex.Message}");
        }
    }
    [ObservableProperty]
    private string _currentTheme = "DARK";

    [RelayCommand]
    private void ToggleTheme()
    {
        var app = Application.Current;
        if (app == null) return;
        
        if (app.ActualThemeVariant == ThemeVariant.Dark)
        {
            app.RequestedThemeVariant = ThemeVariant.Light;
            CurrentTheme = "LIGHT";
        }
        else
        {
            app.RequestedThemeVariant = ThemeVariant.Dark;
            CurrentTheme = "DARK";
        }
    }
}