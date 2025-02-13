namespace Domain;

public abstract class Workout
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public abstract double CalculateCalories();
}
