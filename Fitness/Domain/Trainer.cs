namespace Domain;

public class Trainer : Person
{
    public string Specialization { get; set; }
    public List<Client> Clients { get; set; }
    public override string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}, Specialization: {Specialization}, Clients: {Clients.Count}";
    }
    public virtual void AddClient(Client client)
    {
        Clients.Add(client);
    }
}
