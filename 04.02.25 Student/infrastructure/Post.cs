namespace infrastructure;

public class Post
{
    private static int counter = 1;
    public int ID { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreateAt { get; set; }
    public int CategoryId { get; set; }
    public Post(string Title, string Description, int CategoryId)
    {
        ID = counter++;
        this.Title = Title;
        this.CategoryId = CategoryId;
        this.Description = Description;
    }
}
