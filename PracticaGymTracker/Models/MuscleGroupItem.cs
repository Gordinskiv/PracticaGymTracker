using System.Collections.ObjectModel;
using PracticaGymTracker.ViewModels;

namespace PracticaGymTracker.Models;

public class MuscleGroupItem
{
    public string GroupName { get; set; }
    public ObservableCollection<ExerciseItem> Exercises { get; set; }
}