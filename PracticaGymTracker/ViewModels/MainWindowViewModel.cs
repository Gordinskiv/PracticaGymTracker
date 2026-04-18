using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PracticaGymTracker.ViewModels;


public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private object _currentPage;
    
    [ObservableProperty] 
    private bool _isMenuVisible = false; 
    [ObservableProperty] private bool _isAdminPanelVisible = false;

    public MainWindowViewModel()
    {
        ShowLogin();
    }
    
    [RelayCommand]
    private void ShowHome()
    {
        var homeVM = new HomeViewModel();
        CurrentPage = homeVM; 
    }
    public void ShowLogin()
    {
        IsMenuVisible = false;
        CurrentPage = new LoginViewModel(PerformLogin); 
    }
    private void PerformLogin(bool isAdmin = false)
    {
        IsAdminPanelVisible = isAdmin;
        IsMenuVisible = true;
        ShowHome();
    }
    [RelayCommand]
    private void Logout()
    {
        ShowLogin();
    }
    [RelayCommand]
    private void Exit()
    {
        ShowLogin();
    }
    [RelayCommand]
    public void ShowRegister()
    {
        IsMenuVisible = false;
        CurrentPage = new RegisterViewModel(PerformLogin, ShowLogin);
    }
    [RelayCommand]
    private void ShowWorkouts() => CurrentPage = new WorkoutsViewModel();

    [RelayCommand]
    private void ShowSettings() => CurrentPage = new SettingsViewModel();
    
    [RelayCommand]
    private void ShowAnalytics() => CurrentPage = new AnalyticsViewModel();
    
    [RelayCommand]
    private void ShowAchievements() => CurrentPage = new AchievementsViewModel();
    
    [RelayCommand]
    private void ShowExercisesCatalog() => CurrentPage = new ExercisesCatalogViewModel();
    
    [RelayCommand]
    private void ShowAdminPanel() => CurrentPage = new AdminPanelViewModel();
}
