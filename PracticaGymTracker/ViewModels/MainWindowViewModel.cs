using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PracticaGymTracker.ViewModels;


public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private object _currentPage;

    public MainWindowViewModel()
    {
        _currentPage = new HomeViewModel(); 
    }
    
    [RelayCommand]
    private void ShowHome()
    {
        var homeVM = new HomeViewModel();
        CurrentPage = homeVM; 
    }

    [RelayCommand]
    private void ShowWorkouts() => CurrentPage = new WorkoutsViewModel();

    [RelayCommand]
    private void ShowSettings() => CurrentPage = new SettingsViewModel();
    
}
