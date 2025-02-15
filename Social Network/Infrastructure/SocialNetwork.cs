using Domain.Entity;
using Domain.Enum;


namespace Infrastructure;

public class SocialNetwork
{
    public static List<User> Users { get; set; } = new List<User>();
    public static MessageStorage<Message> Messages { get; set; } = new MessageStorage<Message>();
    public static User CurrentUser { get; set; }

    public SocialNetwork()
    {
        
    }

    public static bool RegisterUser(string name)
    {
        if (name.Length < 3)
        {
            System.Console.WriteLine("Error: name is too small!");
            return false;
        }
        CurrentUser = new User(name);
        Users.Add(CurrentUser);
        return true;
    }

    public static bool Login(string name)
    {
        return Users.Any(n => n.Name == name);
    }

    public static void SendMessage(string text, MessageType type)
    {
        Message message = new Message(CurrentUser.Name, text, type);
        Messages.Add(message);
        System.Console.WriteLine($"Message: {text}, Type: {type}");
    }

    public static List<Message> GetLastMessages(int count)
    {
        return Messages.GetLastMessages(count);
    }

    public static void ChangeUserStatus(UserStatus newStatus)
    {
        CurrentUser.ChangeStatus(newStatus);
    }
}