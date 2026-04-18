namespace PracticaGymTracker.Models;

public class ClientItem
{
    public string Name { get; set; }
    public string Goal { get; set; }        
    public string LastActive { get; set; }  
    public int ProgressPercent { get; set; }
    public string StatusColor { get; set; }
}