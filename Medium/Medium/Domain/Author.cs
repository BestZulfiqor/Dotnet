namespace Domain;

public class Author : User
{
    public List<Article> Articles { get; set; }
    public int SubscribersCount { get; set; }
    public string Bio { get; set; }
    public Author(int subscribersCount, string bio)
    {
        Articles = new List<Article>();
        this.SubscribersCount = subscribersCount;
        this.Bio = bio;
    }
}