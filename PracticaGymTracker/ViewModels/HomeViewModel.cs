using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PracticaGymTracker.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    [ObservableProperty] private string _workoutsThisWeek = "3";
    [ObservableProperty] private string _lastRecord = "80 кг";
    [ObservableProperty] private string _favoriteExercise = "Присід";
}