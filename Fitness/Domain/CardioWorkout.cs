namespace Domain;

public class CardioWorkout : Workout
{
    public double Distanse { get; set; }
    public Intensity Intensity { get; set; }
    public override double CalculateCalories()
    {
        double caloriesPerKm = 0;
        switch (Intensity)
        {
            case Intensity.Low:
                caloriesPerKm = 50;
                break;
            case Intensity.Medium:
                caloriesPerKm = 70;
                break;
                case Intensity.Hard:
                caloriesPerKm = 100;
                break;
        }
        return Distanse * caloriesPerKm * Duration;
    }
}
