using Domain;

namespace Infrastructure;

public class MediumStore
{
    public List<Article> Articles { get; set; }
    public List<User> Users { get; set; }
    public List<Comment> Comments { get; set; }
    public List<Category> Categories { get; set; }
    public List<Subscription> Subscriptions { get; set; }
    public MediumStore()
    {
        Articles = new List<Article>();
        Users = new List<User>();
        Comments = new List<Comment>();
        Categories = new List<Category>();
        Subscriptions = new List<Subscription>();
    }
    public bool RegisterUser(User user)
    {
        int maxId = Users.Count();
        user.Id = maxId++;

        if (!user.Email.Contains("@")) return false;
        if (user.Password.Length < 6) return false;
        if (string.IsNullOrEmpty(user.Name)) return false;

        Users.Add(user);
        return true;
    }
    public bool Login(string email, string password)
    {
        foreach (var user in Users)
        {
            if (user.Email == email && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }
    public bool PublishArticle(Article article)
    {
        int maxId = Articles.Count();
        article.ID = maxId++;
        Articles.Add(article);
        return true;
    }
    public bool UpdateArticle(Article newArticle)
    {
        foreach (var article in Articles)
        {
            if (article.ID == newArticle.ID)
            {
                article.Title = newArticle.Title;
                article.AuthorID = newArticle.AuthorID;
                article.CategoryID = newArticle.CategoryID;
                article.Content = newArticle.Content;
                article.LikesCount = newArticle.LikesCount;
                article.ReadingTimeMinutes = newArticle.ReadingTimeMinutes;
                article.ViewsCount = newArticle.ViewsCount; 
                return true;
            }
        }
        return false;
    }
    public bool DeleteArticle(int id)
    {
        foreach (var item in Articles)
        {
            if (item.ID == id)
            {
                Articles.Remove(item);
                return true;
            }
        }
        return false;
    }
    public List<Article> GetAllArticles()
    {
        foreach (var article in Articles)
        {
            article.ViewsCount++;
        }
        return Articles;
    }
    public List<Article> GetArticlesByCategory(int categoryId)
    {
        List<Article> result = new List<Article>();
        foreach (var article in Articles)
        {
            if (article.CategoryID == categoryId)
            {
                result.Add(article);
            }
        }
        return result;
    }
    public List<Article> GetArticlesByAuthor(int id)
    {
        List<Article> articles = new List<Article>();
        foreach (var article in Articles)
        {
            if (article.AuthorID == id) articles.Add(article);
        }
        return articles;
    }
    public bool LikeArticle(int articleId)
    {
        foreach (var article in Articles)
        {
            if (article.ID == articleId)
            {
                article.LikesCount ++;
                return true;
            }
        }
        return false;
    }
    public bool AddComment(Comment comment)
    {
        int maxId = Comments.Count();
        comment.Id = maxId++;
        Comments.Add(comment);
        return true;
    }

    public bool Subscribe(int readerId, int authorId)
    {
        int maxId = Subscriptions.Count();
        var subscription = new Subscription();
        subscription.Id = maxId++;
        subscription.AuthorId = authorId;
        subscription.ReaderId = readerId;
        subscription.StartDate = DateTime.Now;
        subscription.EndDate = DateTime.Now.AddMonths(1);
        Subscriptions.Add(subscription);    
        return true;
    }
}
