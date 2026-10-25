namespace Gym.Models;

public class Spinning : Activity
{
    public int NumBikes { get; set; }

    public Spinning(string name, int duration, int maxNumberParticipants, int numBikes)
        : base(name, duration, maxNumberParticipants)
    {
        NumBikes = numBikes;
    }

    public override void ShowDescription()
    {
        Console.WriteLine($"{Name} | {Duration}min | {MaxNumberParticipants} participantes | {NumBikes} bicis");
    }
}