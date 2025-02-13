namespace Domain;

public class StrenghtWorkout : Workout
{
    public double Weight { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public override double CalculateCalories()
    {
        double caloryPerKg = 0.1;
        return Weight * Sets * Reps * caloryPerKg;
    }
}
