using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PracticaGymTracker.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private readonly Action _onLoginSuccess;

    public LoginViewModel(Action onLoginSuccess)
    {
        _onLoginSuccess = onLoginSuccess;
    }
    
    public LoginViewModel() { }

    [RelayCommand]
    private void Login()
    {
        _onLoginSuccess?.Invoke();
    }
}