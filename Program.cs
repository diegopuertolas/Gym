using Gym.Models;

var spinning = new Spinning("Spinning", 120, 30, 30);
var yoga = new Yoga("Yoga", 60, 10, 20);
var crossTraining = new CrossTraining("Entrenamiento de Cross", 90, 20, 16);

var activities = new List<Activity>
{
    spinning, 
    yoga, 
    crossTraining
};