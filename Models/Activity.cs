namespace Gym.Models;

public abstract class Activity
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public int MaxNumberParticipants { get; set; }

    public Activity(string name, int duration, int maxNumberParticipants)
    {
        Name = name;
        Duration = duration;
        MaxNumberParticipants = maxNumberParticipants;
    }

    public abstract void ShowDescription();
}