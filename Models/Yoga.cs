namespace Gym.Models;

public class Yoga : Activity
{
    public int NumMats { get; set; }

    public Yoga(string name, int duration, int maxNumberParticipants, int numMats)
        : base(name, duration, maxNumberParticipants)
    {
        NumMats = numMats;
    }

    public override void ShowDescription()
    {
        Console.WriteLine($"{Name} | {Duration}min | {MaxNumberParticipants} participantes | {NumMats} esterillas");
    }
}