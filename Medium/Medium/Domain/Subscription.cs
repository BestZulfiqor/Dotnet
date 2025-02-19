namespace Domain;

public class Subscription
{
    public int Id { get; set; }
    public int ReaderId { get; set; }
    public int AuthorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
