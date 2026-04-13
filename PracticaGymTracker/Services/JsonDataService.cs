using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using PracticaGymTracker.Models;

namespace PracticaGymTracker.Services;

public class JsonDataService
{
    private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "workouts_data.json");
    
    public void SaveWorkouts(IEnumerable<WorkoutItem> workouts)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        
        string json = JsonSerializer.Serialize(workouts, options);
        File.WriteAllText(_filePath, json);
    }
    
    public List<WorkoutItem> LoadWorkouts()
    {
        if (!File.Exists(_filePath))
        {
            return new List<WorkoutItem>();
        }
        try
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<WorkoutItem>>(json) ?? new List<WorkoutItem>();
        }
        catch (Exception)
        {
            return new List<WorkoutItem>();
        }
    }
}