using Domain.Enum;

namespace Domain.Entity;

public class User
{
    public string Name { get; set; }
    public UserStatus Status { get; set; }
    public List<string> Friends { get; set; }
    public User(string name)
    {
        this.Name = name;
        Friends = new List<string>();
    }
    public void ChangeStatus(UserStatus newStatus)
    {
        Status = newStatus;
        System.Console.WriteLine("Status changed to " + Status);
    }
    public bool AddFriend(string friendName)
    {
        Friends.Add(friendName);
        return true;
    }
    public List<string> GetFriends()
    {
        return Friends;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Status: {Status}, Friends Count: {Friends.Count}";
    }
}
