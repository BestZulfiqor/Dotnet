using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;

namespace Domain.Entity;

public class MessageStorage<T>
{
    public List<T> Messages { get; set; }
    public MessageStorage()
    {
        Messages = new List<T>();
    }
    public void Add(T massage)
    {
        Messages.Add(massage);
    }
    public List<T> GetLastMessages(int count)
    {
        if (count < 0)
        {
            throw new ArgumentException("Count must be positive!");
        }
        return Messages.Skip(Math.Max(0, Messages.Count - count)).ToList();
    }
    public void Clear()
    {
        Messages.Clear();
        System.Console.WriteLine("Messeges are cleared!");
    }
    public int Count(){
        return Messages.Count;
    }
}
