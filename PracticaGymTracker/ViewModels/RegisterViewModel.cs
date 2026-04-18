using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PracticaGymTracker.ViewModels;

public partial class RegisterViewModel : ViewModelBase
{
    private readonly Action<bool> _onRegisterSuccess;
    private readonly Action _onBackToLogin;
    
    [ObservableProperty] private bool _isUserRole = true;
    [ObservableProperty] private bool _isAdminRole = false;

    public RegisterViewModel(Action<bool> onRegisterSuccess, Action onBackToLogin)
    {
        _onRegisterSuccess = onRegisterSuccess;
        _onBackToLogin = onBackToLogin;
    }
    [RelayCommand]
    private void Register()
    {
        _onRegisterSuccess?.Invoke(IsAdminRole);
    }
    [RelayCommand]
    private void GoToLogin()
    {
        _onBackToLogin?.Invoke();
    }
}