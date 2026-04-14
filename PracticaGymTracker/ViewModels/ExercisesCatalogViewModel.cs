using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PracticaGymTracker.Models;

namespace PracticaGymTracker.ViewModels;

public partial class ExercisesCatalogViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<MuscleGroupItem> _catalog;

    [ObservableProperty] private string _selectedExerciseName = "Виберіть вправу";

    public ExercisesCatalogViewModel()
    {
        Catalog = new ObservableCollection<MuscleGroupItem>
        {
            new MuscleGroupItem
            {
                GroupName = "ГРУДНІ М'ЯЗИ",
                Exercises = new ObservableCollection<ExerciseItem>
                {
                    new ExerciseItem { Name = "Жим лежачи", TargetMuscle = "Chest", SecondaryTargetMuscle = "Triceps" },
                    new ExerciseItem { Name = "Жим на похилій лаві", TargetMuscle = "Chest", SecondaryTargetMuscle = "Triceps" },
                    new ExerciseItem { Name = "Віджимання на брусах", TargetMuscle = "Chest", SecondaryTargetMuscle = "Triceps" },
                }
            },
            new MuscleGroupItem
            {
                GroupName = "СПИНА",
                Exercises = new ObservableCollection<ExerciseItem>
                {
                    new ExerciseItem { Name = "Вертикальна тяга", TargetMuscle = "Back" },
                    new ExerciseItem { Name = "Горизонтальна тяга", TargetMuscle = "Back" },
                    new ExerciseItem { Name = "Підтягування", TargetMuscle = "Back" }
                }
            },
            new MuscleGroupItem
            {
                GroupName = "НОГИ",
                Exercises = new ObservableCollection<ExerciseItem>
                {
                    new ExerciseItem { Name = "Присід зі штангою", TargetMuscle = "Legs" },
                    new ExerciseItem { Name = "Випади", TargetMuscle = "Legs" },
                    new ExerciseItem { Name = "Жим ногами", TargetMuscle = "Legs" },
                    new ExerciseItem { Name = "Піднімання на носки", TargetMuscle = "Legs" }
                }
            }
        };
    }
}