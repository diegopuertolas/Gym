namespace Gym.Models;

public class CrossTraining : Activity
{
    public int MinAge { get; set; }

    public CrossTraining(string name, int duration, int maxNumberParticipants, int minAge)
        : base(name, duration, maxNumberParticipants)
    {
        MinAge = minAge;
    }

    public override void ShowDescription()
    {
        Console.WriteLine($"{Name} | {Duration}min | {MaxNumberParticipants} participantes | Edad mínima: {MinAge}");
    }
}