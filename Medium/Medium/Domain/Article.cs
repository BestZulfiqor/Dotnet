namespace Domain;

public class Article
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int AuthorID { get; set; }
    public DateTime PublishDate { get; set; }
    public int CategoryID { get; set; }
    public int LikesCount { get; set; }
    public int ViewsCount { get; set; }
    public int ReadingTimeMinutes { get; set; }

    public Article (string title, string content, int authorId, int categoryID, int likesCount, int viewsCount, int readingTime)
    {
        Title = title;
        Content = content;
        AuthorID = authorId;
        PublishDate = DateTime.Now;
        CategoryID = categoryID;
        LikesCount = likesCount;
        ViewsCount = viewsCount;
        ReadingTimeMinutes = readingTime;
    }
}