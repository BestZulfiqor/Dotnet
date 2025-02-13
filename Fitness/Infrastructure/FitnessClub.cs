using Domain;

namespace Infrastructure;

public class FitnessClub
{
    public List<Client> Clients { get; set; }
    public List<Trainer> Trainers { get; set; }
    public List<Workout> Workouts { get; set; }
    public void AddClient(Client client){
        Clients.Add(client);
    }
    public void AddTrainer(Trainer trainer){
        Trainers.Add(trainer);
    }
    public void AssignTrainer(Client client, Trainer trainer){
        trainer.AddClient(client);
    }
    public void DisplayStats(){
        System.Console.WriteLine("\nFitness Club статистика:");
        System.Console.WriteLine("Общее количество клиентов: " + Clients.Count);
        System.Console.WriteLine("Общее количество тренеров: " + Trainers.Count);
        System.Console.WriteLine("Общее количество тренировок: " + Workouts.Count);

        System.Console.WriteLine("\nКлиенты: ");
        foreach (var item in Clients)
        {
            System.Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
        }

        Console.WriteLine($"Тренеры");
        foreach (var item in Trainers)
        {
            System.Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, Clients: {item.Clients.Count}");
        }

        Console.WriteLine($"Тренировки");
        foreach (var item in Workouts)
        {
            System.Console.WriteLine($"ID: {item.Id}. Name: {item.Name}, Duration: {item.Duration}");
        }
    }
}
