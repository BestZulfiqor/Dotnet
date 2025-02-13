namespace Domain;

public class Client : Person
{
    public MembershipType MembershipType { get; set; }
    public DateTime JoinDate { get; set; }
    
    public List<Workout> WorkoutList { get; set; }
    public override string GetInfo()
    {
        return $"\nID: {Id}. Name: {Name}, Age: {Age}";
    }
    public virtual void AddWorkout(Workout workout){
        WorkoutList.Add(workout);
    }
}
