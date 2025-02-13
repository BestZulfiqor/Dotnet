using Domain;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Client client1 = new Client { Id = "1", Name = "Zulfiqor Alimamatov", Age = 30 };
        Client client2 = new Client { Id = "2", Name = "Ahmad Shodiev", Age = 25 };

        Trainer trainer1 = new Trainer { Id = "1", Name = "Cristiano Ronaldo", Age = 40, Specialization = "Cardio", Clients = new List<Client>() };
        Trainer trainer2 = new Trainer { Id = "2", Name = "Leonel Messi", Age = 35, Specialization = "Strength", Clients = new List<Client>() };

        CardioWorkout cardioWorkout = new CardioWorkout { Id = "1", Name = "Run", Duration = 60, Distanse = 10, Intensity = Intensity.Medium };
        StrenghtWorkout strenghtWorkout = new StrenghtWorkout { Id = "2", Name = "Weight Lifting", Duration = 45, Weight = 50, Sets = 4, Reps = 10 };

        FitnessClub fitnessClub = new FitnessClub
        {
            Clients = new List<Client> { client1, client2 },
            Trainers = new List<Trainer> { trainer1, trainer2 },
            Workouts = new List<Workout> { cardioWorkout, strenghtWorkout }
        };

        fitnessClub.AssignTrainer(client1, trainer1);
        fitnessClub.AssignTrainer(client2, trainer2);

        fitnessClub.DisplayStats();

        Console.WriteLine(client1.GetInfo());
        Console.WriteLine(client2.GetInfo());
        Console.WriteLine(trainer1.GetInfo());
        Console.WriteLine(trainer2.GetInfo());

        Console.WriteLine($"Calories burned in {cardioWorkout.Name}: {cardioWorkout.CalculateCalories()}");
        Console.WriteLine($"\nCalories burned in {strenghtWorkout.Name}: {strenghtWorkout.CalculateCalories()}");
    }
}