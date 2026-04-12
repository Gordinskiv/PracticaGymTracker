using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using PracticaGymTracker.Models;

namespace PracticaGymTracker.ViewModels;

public partial class WorkoutsViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<WorkoutItem> _workoutsList;
    
    [ObservableProperty]
    private string _newExerciseName = string.Empty;

    [ObservableProperty]
    private string _newWeight = string.Empty;

    [ObservableProperty]
    private string _newReps = string.Empty;
    
    [RelayCommand]
    private void AddWorkout()
    {
        if (!string.IsNullOrWhiteSpace(NewExerciseName))
        {
            int.TryParse(NewReps, out int parsedReps);
            
            var newExercise = new WorkoutItem
            {
                ExerciseName = NewExerciseName,
                Weight = string.IsNullOrWhiteSpace(NewWeight) ? "0 кг" : NewWeight,
                Reps = parsedReps
            };
            
            WorkoutsList.Add(newExercise);
            
            NewExerciseName = string.Empty;
            NewWeight = string.Empty;
            NewReps = string.Empty;
        }
    }
    public WorkoutsViewModel()
    {
        WorkoutsList = new ObservableCollection<WorkoutItem>
        {
            new WorkoutItem { ExerciseName = "Жим лежачи", Weight = "80", Reps = 8 },
            new WorkoutItem { ExerciseName = "Присідання зі штангою", Weight = "100", Reps = 5 },
            new WorkoutItem { ExerciseName = "Підтягування", Weight = "Власна вага", Reps = 12 },
            new WorkoutItem { ExerciseName = "Жим гантелей сидячи", Weight = "24", Reps = 10 }
        };  
    }
    [RelayCommand]
    private void DeleteWorkout(WorkoutItem workout)
    {
        if (workout != null && WorkoutsList.Contains(workout))
        {
            WorkoutsList.Remove(workout);
        }
    }
}